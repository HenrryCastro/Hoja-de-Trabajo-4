namespace Hoja_de_Trabajo_4.models
{
    public class NodoEntero
    {
        public int Valor { get; set; }
        public NodoEntero Siguiente { get; set; }

        public NodoEntero(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }
}