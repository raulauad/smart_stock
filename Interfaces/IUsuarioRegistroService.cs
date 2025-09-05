using smart_stock.Models;
using smart_stock.Dto;

namespace smart_stock.Interfaces
{
    public interface IUsuarioRegistroService
    {
        Task<Usuario> RegistrarUsuario(UsuarioRegistroDto usuarioRegistroDto);
        Task<bool> VerificarEmailUnico(string email);
    }
}
