using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Inventario
{
    class ProductoDAL
    {
        public static int retorno = 0;
        public static int Agregar(Producto pProducto)
        {
            using (SqlConnection Conn = BDComun.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Cafeteria (Nombre_Producto, Cantidad_del_Producto, Unidad_de_medida, Nombre_del_Proovedor, Empresa_del_Proovedor, Telefono) values ('" + pProducto.Nombre_Producto + "','" + pProducto.Cantidad_del_Producto + "','" + pProducto.Unidad_de_medida + "','" + pProducto.Nombre_del_Proovedor + "','" + pProducto.Empresa_del_Proovedor + "','" + pProducto.Telefono + "')"), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }

        public static List<Producto> BuscarProducto(String pNombre_Producto, String pEmpresa_del_Proovedor)
        {
            List<Producto> Lista = new List<Producto>();
            using (SqlConnection conexion = BDComun.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select Id_del_producto, Nombre_Producto, Cantidad_del_Producto, Unidad_de_medida,Empresa_del_Proovedor from Cafeteria where Nombre_Producto like '%{0}%' or Empresa_del_Proovedor like '%{1}%' ", pNombre_Producto, pEmpresa_del_Proovedor), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Producto pProducto = new Producto();
                    pProducto.Id_del_producto = reader.GetInt64(0);
                    pProducto.Nombre_Producto = reader.GetString(1);
                    pProducto.Cantidad_del_Producto = reader.GetString(2);
                    pProducto.Unidad_de_medida = reader.GetString(3);
                    pEmpresa_del_Proovedor = reader.GetString(4);

                    Lista.Add(pProducto);
                }
                conexion.Close();
                return Lista;

            }
        }
    }
}
