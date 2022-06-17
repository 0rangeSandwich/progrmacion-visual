using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;

namespace CapaDatos
{
    public class ClaseDatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql]"].ConnectionString);


        public DataTable D_listarProductos()
        {
            SqlCommand cmd = new SqlCommand("sp_listarProductos", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable D_buscarProductos(ClaseEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscarProductos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public string D_mantenimientoProductos(ClaseEntidad obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimientoProductos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", obje.codigo);
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            cmd.Parameters.AddWithValue("@descripcion", obje.descripcion);
            cmd.Parameters.AddWithValue("@unidades", obje.unidades);
            cmd.Parameters.AddWithValue("@precioProveedor", obje.PrecioProveedor);
            cmd.Parameters.AddWithValue("@precioUnitario", obje.PrecioUnitario);
            cmd.Parameters.AddWithValue("@precioPublico", obje.PrecioPublico);
            cmd.Parameters.AddWithValue("@presentacion", obje.presentacion);
            cmd.Parameters.AddWithValue("@fechaEntrada", obje.fecha);
            cmd.Parameters.AddWithValue("@categoria", obje.categoria);

            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
    }
}
