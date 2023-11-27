using PortafolioKenneth.Models;

namespace PortafolioKenneth.Servicios
{
    public class RepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>(){ new Proyecto
            {
                Titulo="People Thrust",
                Descripcion="Outsourcing de desarrollo en .NET CORE",
                Link="https://peoplethrust.com",
                ImagenURL="/imagenes/amajpg.jpeg"
            },
            new Proyecto
            {
                Titulo="Dominion",
                Descripcion="Outsourcing de desarrollo en .NET MVC",
                Link="https://dominion.com",
                ImagenURL="/imagenes/amajpg.jpeg"
            },
            new Proyecto
            {
                Titulo="Juega OK",
                Descripcion="Recursos humanos",
                Link="https://juegaok.com",
                ImagenURL="/imagenes/amajpg.jpeg"
            },
            };
        }
    }
}
