using Microsoft.AspNetCore.Identity;
using smart_stock.Dto;
using smart_stock.Interfaces;
using System.Text;

namespace smart_stock.Validators
{
    public class ContraseñaValidador : IUsuarioValidador
    {
        public void Validar(UsuarioDto usuario)
        {
            var errores = new List<string>();
            var password = usuario.Contraseña;

            if (string.IsNullOrWhiteSpace(password))
            {
                errores.Add("La contraseña es obligatoria"); //Obligamos al usuario a ingresar una contraseña
            }
            else
            {
                if (password.Length < 8)
                {
                    errores.Add("Debe contener al menos 8 caracteres");
                }

                if (!password.Any(char.IsUpper))
                {
                    errores.Add("Debe contener al menos una letra mayuscula");
                }

                if (!password.Any(char.IsLower))
                {
                    errores.Add("Debe contener al menos una letra minuscula");
                }

                if (!password.Any(char.IsDigit))
                {
                    errores.Add("Debe contener al menos un digito");
                }

                if (!password.Any(c => !char.IsLetterOrDigit(c))) //Si en contraseña, tal que c no es un caracter especial sino una letra o numero,
                {                                                //eso significa que no hay ningun caracter especial en nuestra contraseña.

                    errores.Add("Debe contener al menos un caracter especial");

                }//Otra opcion era utilizar Regex, pero el regex deberia contener todos los caracteres por ende no seria optimo =>
                 //if (!password.Any(c => "!@#$%^&*()_-+=[]{}|\\:;\"'<>,.?/~`".Contains(c))) y seria un desastre.
            }
            var contraseñaErrores = "La contraseña: ";

            if (errores.Any())
            {
                throw new ArgumentException($"{contraseñaErrores} {string.Join(" ", errores)}");
            }
        }
    }
}
