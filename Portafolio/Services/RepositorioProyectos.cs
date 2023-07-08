using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerListaDeProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerListaDeProyectos()
        {
            return new List<Proyecto> {
                new Proyecto{
                Titulo= "Sistema de matricula",
                Descripcion="Sistema en el cual...",
                Link="https://amazon.com",
                UrlImagen="/imagenes/tesis.png",
                },
                new Proyecto{
                Titulo= "Generador de tickets",
                Descripcion="Sistema en el cual...",
                Link="https://google.com",
                UrlImagen="/imagenes/boleto.png",
                }, new Proyecto
                {
                Titulo= "ReportesUdec",
                Descripcion="Sistema en el cual..",
                Link="https://reddit.com",
                UrlImagen="imagenes/informe.png",
                }
            };
        }
    }
}
