using Microsoft.AspNetCore.Identity.Data;
using smart_stock.Models;

namespace smart_stock.Repositories
{
    public class InMemoryUsuarioRepositorio
    {
        private readonly List<Usuario> _usuarios = new();
        private int _nextId = 1;
        private readonly object _lock = new();

        public Task<bool> ExisteEmaiAsync(string email)
        {
            lock (_lock)
            {
                return Task.FromResult(
                    _usuarios.Any(
                        u => u.Email != null &&
                               email != null &&
                               u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)));
            }
        }
        
        public Task<Usuario> AgregarAsync(Usuario usuario)
        {
            lock (_lock)
            {
                usuario.Id_usuario = _nextId++;
                _usuarios.Add(usuario);
                return Task.FromResult(usuario);
            }
        }

        Task<IEnumerable<Usuario>> GetUsuariosAsync()
        {
            lock (_lock)
            {
                return Task.FromResult<IEnumerable<Usuario>>(_usuarios.ToList());
            }
        }
    }
}
