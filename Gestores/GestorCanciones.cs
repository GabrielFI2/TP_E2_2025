using SistemaDeGestionDeMusica.Modelos;


namespace SistemaDeGestionDeMusica.Gestores
{
    public class GestorCanciones
    {
        //varaible de la clase
        public List<Cancion> cancionesDisponibles;

        //constructor
        public GestorCanciones()
        {
            cancionesDisponibles = new List<Cancion>();
        }
        //Metodos

        public void AgregarCancion(string nombre, string artista, int duracionsegundos)
        {
            cancionesDisponibles.Add(new Cancion(nombre, artista, duracionsegundos));
        }

        public static (Cancion, int) BuscarPorNombre(List<Cancion> canciones, string nombre)
        {
            int i = 0;
            foreach (Cancion cancion in canciones)
            {
                i++;
                if(cancion.Nombre.Equals(nombre,StringComparison.OrdinalIgnoreCase))
                {
                    return (cancion, i);
                }
            }
            return (null, i);

        }
    }
}
