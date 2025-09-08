namespace smart_stock.Interfaces
{
    public interface IContraseñaHasher
    {
        string Hash(string input);
        bool Verificar(string input, string hash);
    }
}
