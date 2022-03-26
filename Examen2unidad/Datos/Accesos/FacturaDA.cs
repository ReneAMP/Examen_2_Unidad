using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class FacturaDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen; Uid=root; Pwd=R3neamp18#;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public int InsertarFactura(Factura factura)
        {
            int idFactura = 0;
            try
            {
                string sql = "INSERT INTO factura (IdentidadCliente, Cliente, Fecha, Subtotal, Impuesto, Total) VALUES (@IdentidadCliente, @Cliente, @Fecha, @Subtotal, @Impuesto, @Total); select last_insert_id();";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdentidadCliente", factura.IdentidadCliente);
                cmd.Parameters.AddWithValue("@Cliente", factura.Cliente);
                cmd.Parameters.AddWithValue("@Fecha", factura.Fecha);
                cmd.Parameters.AddWithValue("@Subtotal", factura.SubTotal);
                cmd.Parameters.AddWithValue("@Impuesto", factura.ISV);
                cmd.Parameters.AddWithValue("@Total", factura.Total);

                idFactura = Convert.ToInt32(cmd.ExecuteScalar());

               
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            return idFactura;
        }

        public bool InsertarDetalle(DetalleFactura detalleFactura)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO detallefactura (IdFactura, CodigoProducto, Descripcion, Cantidad, Precio, Total) VALUES (@IdFactura, @CodigoProducto, @Descripcion, @Cantidad, @Precio, @Total); select last_insert_id();";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdFactura", detalleFactura.IdFactura);
                cmd.Parameters.AddWithValue("@CodigoProducto", detalleFactura.CodigoProducto);
                cmd.Parameters.AddWithValue("@Descripcion", detalleFactura.Descripcion);
                cmd.Parameters.AddWithValue("@Cantidad", detalleFactura.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", detalleFactura.Precio);
                cmd.Parameters.AddWithValue("@Total", detalleFactura.Total);

                cmd.ExecuteNonQuery();

                inserto = true;
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            return inserto;
        }
    }
}
