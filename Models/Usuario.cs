namespace smart_stock.Models
{
    public class Usuario
    {
        public int Id_usuario { get; set; }
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? ContraseñaHash { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
