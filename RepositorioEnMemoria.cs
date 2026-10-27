namespace api;
using api.Entitis;

public class RepositorioEnMemoria : IRepositorio
{
    private List<Genero> __generos;
    public RepositorioEnMemoria()
    {
        __generos = new List<Genero>()
        {
            new Genero() { id = 1, nombre = "Acción" },
            new Genero() { id = 2, nombre = "Comedia" },
            new Genero() { id = 3, nombre = "Drama" },
            new Genero() { id = 4, nombre = "Terror" },
            new Genero() { id = 5, nombre = "Romance" }
        };
    }

    public List<Genero> ObtenerTodosLosGeneros()
    {
        return __generos;
    }

    public void Crear(Genero genero)
    {
        __generos.Add(genero);
    }

    public async Task<Genero?> ObtenerPorId(int id)
    {
        await Task.Delay(TimeSpan.FromSeconds(3));
        return __generos.FirstOrDefault(g => g.id == id);
    }

    public bool Existe(string nombre)
    {
        return __generos.Any(g => g.nombre == nombre);
    }
};
