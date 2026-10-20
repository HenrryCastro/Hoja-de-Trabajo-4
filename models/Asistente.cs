namespace Hoja_de_Trabajo_4.models
{
    public class Asistente
    {
        public string Nombre { get; set; }
        public Asistente Siguiente { get; set; }

        public Asistente(string nombre)
        {
            Nombre = nombre;
            Siguiente = null;
        }
    }
}