using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CD_Cliente
    {
        public List<Cliente> SelectCliente()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection cn = new SqlConnection(Coneccion.GetConeccion()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SelectCliente";
                cmd.Connection = cn;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                        cliente.Nombres = dr["Nombres"].ToString();
                        cliente.Apellidos = dr["Apellidos"].ToString();
                        cliente.DNI = dr["DNI"].ToString();
                        cliente.EMail = dr["EMail"].ToString();
                        cliente.IdTipoCliente = Convert.ToInt32(dr["IdTipoCliente"]);
                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;
        }

        public int InsertCliente(Cliente cliente)
        {
            int idCliente;

            using (SqlConnection cn = new SqlConnection(Coneccion.GetConeccion()))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_InsertCliente";
                cmd.Connection = cn;
                cmd.Parameters.Add("IdCliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("Nombres", cliente.Nombres);
                cmd.Parameters.AddWithValue("Apellidos", cliente.Apellidos);
                cmd.Parameters.AddWithValue("DNI", cliente.DNI);
                cmd.Parameters.AddWithValue("EMail", cliente.EMail);
                cmd.Parameters.AddWithValue("IdTipoCliente", cliente.IdTipoCliente);
                cn.Open();

                cmd.ExecuteNonQuery();

                idCliente = Convert.ToInt32(cmd.Parameters["IdCliente"].Value);
            }

            return idCliente;
        }
    }
}
