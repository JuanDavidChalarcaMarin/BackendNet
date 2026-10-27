namespace api;

using api.Entitis;

public interface IRepositorio
{
    List<Genero> ObtenerTodosLosGeneros();
    Task<Genero?> ObtenerPorId(int id);
    bool Existe(string nombre);
    void Crear(Genero genero);
}
