using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class ClaseNegocio
    {
        ClaseDatos objd = new ClaseDatos();

        public DataTable N_listarProductos()
        {
            return objd.D_listarProductos();
        }

        public DataTable N_buscarProductos(ClaseEntidad obje)
        {
            return objd.D_buscarProductos(obje);
        }

        public String N_mantenimientoProductos(ClaseEntidad obje)
        {
            return objd.D_mantenimientoProductos(obje);
        }
    }
}
