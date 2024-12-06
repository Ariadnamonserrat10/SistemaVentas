﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntida;
using System.Reflection;
using System.Collections;
using System.Security.Claims;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace CapaDato
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder() ;
                    query.AppendLine("select u.IdUsuario,u.Documento,u.NombreCompleto,u.Correo,u.Clave,u.Estado,r.idRol,r.Descripcion from usuario u");
                    query.AppendLine("inner join rol r on r.IdRol = u.IdRol");
                    


                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.CommandType = CommandType.Text;
                    conexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                oROL=new ROL() { IdRol= Convert.ToInt32(dr["IdRol"]) ,Descripcion= dr["Descripcion"].ToString() }
                            });

                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }
        public int Registrar(Usuario obj,out String Mensaje )
        {
            int idusuariogenerado = 0;
            Mensaje=String.Empty;
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                   
                   SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", conexion);
                    cmd.Parameters.AddWithValue("Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("Nombrecompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("IdRol", obj.oROL.IdRol);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("IdUsuarioResultado",SqlDbType.Int).Direction=ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    idusuariogenerado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            { 
                idusuariogenerado=0;
                Mensaje=String.Empty;
            }
            return idusuariogenerado;

        }


        public bool Editar(Usuario obj, out String Mensaje)
        {
            bool respuesta = false;
            Mensaje = String.Empty;
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", conexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.IdUsuario);
                    cmd.Parameters.AddWithValue("Documento", obj.Documento);
                    cmd.Parameters.AddWithValue("Nombrecompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("IdRol", obj.oROL.IdRol);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta= Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = String.Empty;
            }
            return respuesta;

        }
        public bool Eliminar(Usuario obj, out String Mensaje)
        {
            bool respuesta = false;
            Mensaje = String.Empty;
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {

                    SqlCommand cmd = new SqlCommand("SP_ELIMINAUSUARIO", conexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.IdUsuario);
                    
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                Mensaje = ex.Message;
            }
            return respuesta;

        }
    }
}
    