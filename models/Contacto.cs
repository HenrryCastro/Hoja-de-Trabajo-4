namespace Hoja_de_Trabajo_4.models
{
    public class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Contacto Siguiente { get; set; }
        public Contacto Anterior { get; set; }

        public Contacto(string nombre, string telefono, string correo)
        {
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Siguiente = null;
            Anterior = null;
        }
    }
}