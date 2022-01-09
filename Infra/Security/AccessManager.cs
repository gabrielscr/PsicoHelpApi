using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using PsicoHelpApi.Infra.Dto;
using PsicoHelpApi.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;

namespace PsicoHelpApi.Infra.Security
{
    public class AccessManager
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;
        private readonly SigningConfigurations _signingConfigurations;
        private readonly TokenConfiguration _tokenConfigurations;

        public AccessManager(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, SigningConfigurations signingConfigurations, TokenConfiguration tokenConfigurations)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _signingConfigurations = signingConfigurations;
            _tokenConfigurations = tokenConfigurations;
        }

        public async Task<bool> ValidarCredenciais(UsuarioAuthDto user)
        {
            bool credenciaisValidas = false;
            if (user != null && !string.IsNullOrWhiteSpace(user.Email))
            {
                var userIdentity = await _userManager
                    .FindByEmailAsync(user.Email);

                credenciaisValidas = await VerificarSeCredenciaisValidas(user, credenciaisValidas, userIdentity);
            }

            return credenciaisValidas;
        }

        private async Task<bool> VerificarSeCredenciaisValidas(UsuarioAuthDto request, bool credenciaisValidas, Usuario userIdentity)
        {
            if (userIdentity != null)
            {
                var resultadoLogin = await _signInManager
                    .CheckPasswordSignInAsync(userIdentity, request.Senha, false);

                if (resultadoLogin.Succeeded)
                {
                    credenciaisValidas = true;
                }
                else
                {
                    credenciaisValidas = true;
                }
            }

            return credenciaisValidas;
        }

        public TokenDto GerarToken(UsuarioAuthDto user)
        {
            ClaimsIdentity identity = new(
                new GenericIdentity(user.Email!, "EMAIL"),
                new[] {
                        new Claim("EMAIL", user.Email!),
                }
            );

            DateTime dataCriacao = DateTime.Now;
            DateTime dataExpiracao = dataCriacao + TimeSpan.FromSeconds(_tokenConfigurations.Seconds);

            var handler = new JwtSecurityTokenHandler();
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _tokenConfigurations.Issuer,
                Audience = _tokenConfigurations.Audience,
                SigningCredentials = _signingConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = dataCriacao,
                Expires = dataExpiracao
            });
            var token = handler.WriteToken(securityToken);

            return new TokenDto()
            {
                Autenticado = true,
                CriadoEm = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                ExpiraEm = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                Token = token,
                Mensagem = "OK"
            };
        }
    }
}
