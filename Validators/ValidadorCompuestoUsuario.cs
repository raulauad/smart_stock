using Microsoft.AspNetCore.Identity;
using smart_stock.Dto;
using smart_stock.Interfaces;

namespace smart_stock.Validators
{
    public class ValidadorCompuestoUsuario : IUsuarioValidador
    {
        private readonly List<IUsuarioValidador> _validadores;

        public ValidadorCompuestoUsuario(IEnumerable<IUsuarioValidador> validar)
        {
            _validadores = validar.ToList();
        }

        public void Validar(UsuarioDto usuario)
        {
            foreach (var validar in _validadores)
            {
                validar.Validar(usuario);
            }
        }
    }
}
