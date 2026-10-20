namespace Hoja_de_Trabajo_4.models
{
    public class Cancion
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public Cancion Siguiente { get; set; }
        public Cancion Anterior { get; set; }

        public Cancion(string titulo, string artista)
        {
            Titulo = titulo;
            Artista = artista;
            Siguiente = null;
            Anterior = null;
        }
    }
}