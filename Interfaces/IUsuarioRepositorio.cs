using smart_stock.Models;

namespace smart_stock.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<bool> ExisteEmailAsync(string Email);
        Task<Usuario?> GetEmailAsync(string Email);
        Task<Usuario> AgregarAsync(Usuario usuario);
        Task<IEnumerable<Usuario>> GetUsuariosAsync();
    }
}
