using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using smart_stock.Dto;
using smart_stock.Interfaces;

namespace smart_stock.Validators
{
    public class NombreValidador
    {
        public class UsernameValidator : IUsuarioValidador
        {
            public void Validar(UsuarioDto usuario)
            {
                if (string.IsNullOrWhiteSpace(usuario.Nombre))
                {
                    throw new ArgumentException("Ingrese un nombre de usuario");
                }

                if (!char.IsUpper(usuario.Nombre[0]))
                {
                    throw new ArgumentException("La primera letra debe ser mayuscula");
                }
            }
        }
    }
}
