namespace Hoja_de_Trabajo_4.models
{
    public class NodoEstudiante
    {
        public string Nombre { get; set; }
        public NodoEstudiante Siguiente { get; set; }

        public NodoEstudiante(string nombre)
        {
            Nombre = nombre;
            Siguiente = null;
        }
    }
}