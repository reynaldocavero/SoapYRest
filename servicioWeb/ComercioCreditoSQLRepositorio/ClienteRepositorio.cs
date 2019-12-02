using ComercialCreditoContratoRepositorio;
using System;
using System.Collections.Generic;
using ComercialClienteDominio;
using System.Data.SqlClient;
using System.Data;

namespace ComercioCreditoSQLRepositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        Conexion objConexion = new Conexion();
        List<Cliente> listCliente = null;
        Cliente oCliente = null;

        public IEnumerable<Cliente> actualizarCliente(string xml)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> buscarCliente(string xml)
        {
            try
            {

                SqlConnection cn = objConexion.conectar();
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("spBuscarCliente", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("@xml", xml);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        listCliente = new List<Cliente>();
                        while (dr.Read())
                        {
                            oCliente = new Cliente()
                            {
                                id = dr.IsDBNull(dr.GetOrdinal("id")) ? -1 : dr.GetInt32(dr.GetOrdinal("id")),
                                cliente = dr.IsDBNull(dr.GetOrdinal("cliente")) ? "noData" : dr.GetString(dr.GetOrdinal("cliente")),
                                //numero = dr.IsDBNull(dr.GetOrdinal("numero")) ? Convert.ToDecimal(0) : dr.GetDecimal(dr.GetOrdinal("numero")),
                                numeroDoc = dr.IsDBNull(dr.GetOrdinal("numeroDoc")) ? "noData" : dr.GetString(dr.GetOrdinal("numeroDoc")),
                                activo = dr.IsDBNull(dr.GetOrdinal("activo")) ? -1 : dr.GetInt32(dr.GetOrdinal("activo"))
                            };
                            listCliente.Add(oCliente);
                        }
                    }

                }

                return listCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Cliente> eliminarCliente(string xml)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> listarCliente()
        {
            try
            {

                SqlConnection cn = objConexion.conectar();
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("spCliente", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    //cmd.Parameters.AddWithValue("@xml", xml);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        listCliente = new List<Cliente>();
                        while (dr.Read())
                        {
                            oCliente = new Cliente()
                            {
                                id = dr.IsDBNull(dr.GetOrdinal("id")) ? -1 : dr.GetInt32(dr.GetOrdinal("id")),
                                cliente = dr.IsDBNull(dr.GetOrdinal("cliente")) ? "noData" : dr.GetString(dr.GetOrdinal("cliente")),
                                //numero = dr.IsDBNull(dr.GetOrdinal("numero")) ? Convert.ToDecimal(0) : dr.GetDecimal(dr.GetOrdinal("numero")),
                                numeroDoc = dr.IsDBNull(dr.GetOrdinal("numeroDoc")) ? "noData" : dr.GetString(dr.GetOrdinal("numeroDoc")),
                                activo = dr.IsDBNull(dr.GetOrdinal("activo")) ? -1 : dr.GetInt32(dr.GetOrdinal("activo"))
                            };
                            listCliente.Add(oCliente);
                        }
                    }

                }

                return listCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<Cliente> registrarCliente(string xml)
        {
            try
            {

                SqlConnection cn = objConexion.conectar();
                cn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_insertarCliente", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("@xml", xml);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        listCliente = new List<Cliente>();
                        while (dr.Read())
                        {
                            oCliente = new Cliente()
                            {
                                //id = dr.IsDBNull(dr.GetOrdinal("id")) ? -1 : dr.GetInt32(dr.GetOrdinal("id")),
                                cliente = dr.IsDBNull(dr.GetOrdinal("cliente")) ? "noData" : dr.GetString(dr.GetOrdinal("cliente")),
                                //numero = dr.IsDBNull(dr.GetOrdinal("numero")) ? Convert.ToDecimal(0) : dr.GetDecimal(dr.GetOrdinal("numero")),
                                numeroDoc = dr.IsDBNull(dr.GetOrdinal("numeroDoc")) ? "noData" : dr.GetString(dr.GetOrdinal("numeroDoc")),
                                activo = dr.IsDBNull(dr.GetOrdinal("activo")) ? -1 : dr.GetInt32(dr.GetOrdinal("activo"))
                            };
                            listCliente.Add(oCliente);
                        }
                    }

                }

                return listCliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
