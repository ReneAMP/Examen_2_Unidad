namespace Datos.Entidades
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int Existencia { get; set; }
        public byte[] Imagen { get; set; }

        public Producto()
        {
        }

        public Producto(string codigo, string descripcion, int precio, int existencia, byte[] imagen)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Existencia = existencia;
            Imagen = imagen;
        }
    }
}
