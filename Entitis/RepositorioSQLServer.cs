namespace api.Entitis;

public class RepositorioSQLServer : IRepositorio
{
    private List<Genero> _generos;
    public RepositorioSQLServer()
    {
        _generos = new List<Genero>
        {
            new Genero { id = 1, nombre = "Comedia SQL" },
            new Genero { id = 2, nombre = "Acción SQL" }
        };
    }
    public List<Genero> ObtenerTodosLosGeneros()
    {
        return _generos;
    }
    public async Task<Genero?> ObtenerPorId(int id)
    {
        await Task.Delay(TimeSpan.FromSeconds(3));
        return _generos.FirstOrDefault(g => g.id == id);
    }
    public bool Existe(string nombre)
    {
        return _generos.Any(g => g.nombre == nombre);
    }
    public void UnMetodoNuevo()
    {
    }
    public void Crear(Genero genero)
    {
        throw new NotImplementedException();
    }

}
