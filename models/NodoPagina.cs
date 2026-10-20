namespace Hoja_de_Trabajo_4.models
{
    public class NodoPagina
    {
        public string Url { get; set; }
        public NodoPagina Siguiente { get; set; }
        public NodoPagina Anterior { get; set; }

        public NodoPagina(string url)
        {
            Url = url;
            Siguiente = null;
            Anterior = null;
        }
    }
}