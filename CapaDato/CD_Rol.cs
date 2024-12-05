using CapaEntida;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntida;
namespace CapaDato
{
    public class CD_Rol
    {
        public List<ROL> Listar()
        {
            List<ROL> lista = new List<ROL>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdRol,Descripcion from ROL");
             

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ROL()
                            {
                                IdRol= Convert.ToInt32(dr["IdRol"]),
                                Descripcion = dr["Descripcion"].ToString()

                            });

                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<ROL>();
                }
            }
            return lista;
        }
    }
}
    
    