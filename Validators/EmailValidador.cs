using smart_stock.Dto;
using smart_stock.Interfaces;
using smart_stock.Models;
using System.Net.Mail;
using System.Diagnostics.Contracts;

namespace smart_stock.Validators
{
    public class EmailValidador : IUsuarioValidador
    {
        public void Validar(UsuarioDto usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Email))
                throw new ArgumentException("El email no es valido. Ingrese de nuevo correctamente");

            try
            {
                var mailAddress = new MailAddress(usuario.Email); //Comprueba que el email tenga un formato valido segun RFC 5322
            }
            catch
            {
                Console.WriteLine("El email no es valido. Ingrese de nuevo correctamente");
            }
        }
    }
}
