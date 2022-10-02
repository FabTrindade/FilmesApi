using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuariosApi.Data.Requests;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class LoginService
    {
        private SignInManager<CustomIdentityUser> _signInManager;
        private TokenService _tokenService;

        public LoginService(SignInManager<CustomIdentityUser> signInManager, TokenService tokenService)
        {
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public Result LogaUsuario(LoginRequest request)
        {
            var resultIdentity = _signInManager
                .PasswordSignInAsync(request.Username, request.Password, false, false);
            if(resultIdentity.Result.Succeeded)
            {
                var identityUser = _signInManager
                    .UserManager
                    .Users
                    .FirstOrDefault(usuario =>
                    usuario.NormalizedUserName == request.Username.ToUpper());
                
                Token token = _tokenService.CreateToken(
                    identityUser,
                    _signInManager.UserManager.GetRolesAsync(identityUser).Result.FirstOrDefault());
                
                return Result.Ok().WithSuccess(token.Valor);
            }
            return Result.Fail("Login falhou!");
        }

        public Result SolicitaResetSenhaUsuario(ResetRequest request)
        {
            CustomIdentityUser identityUser = RecuperaUsuarioPorEmail(request.Email);

            if (identityUser!= null)
            {
                string codigoRecuperacao = _signInManager
                    .UserManager
                    .GeneratePasswordResetTokenAsync(identityUser).Result;
                return Result.Ok().WithSuccess(codigoRecuperacao);
            }

            return Result.Fail("Falha ao solicitar redefinição de senha");
        }

        public Result ResetSenhaUsuario(EfetuaResetRequest request)
        {
            CustomIdentityUser identityUser = RecuperaUsuarioPorEmail(request.Email);

            IdentityResult identityResult = _signInManager
                .UserManager
                .ResetPasswordAsync(identityUser, request.Token, request.RePassword).Result;


            if (identityResult.Succeeded)
            {
                return Result.Ok().WithSuccess("Senha alterada com sucesso!");
            }
            return Result.Fail("Erro ao alterar senha!");
        }

        private CustomIdentityUser RecuperaUsuarioPorEmail(string email)
        {
            return _signInManager
                            .UserManager
                            .Users
                            .FirstOrDefault(u => u.NormalizedEmail == email.ToUpper());
        }
    }
}
