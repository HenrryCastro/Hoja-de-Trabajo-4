namespace Hoja_de_Trabajo_4.models
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Producto Siguiente { get; set; }

        public Producto(string codigo, string nombre, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Siguiente = null;
        }
    }
}