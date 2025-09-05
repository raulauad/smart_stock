
namespace smart_stock.Dto
{
    public class UsuarioDto
    {
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
