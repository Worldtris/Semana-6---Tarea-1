using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _06Publicaciones.config;
using System.Data.SqlClient;

namespace _06Publicaciones.Models
{
    
    class CiudadesModel
    {
        
        public int IdCiudad { get; set; }
        public string Detalle { get; set; }
        public int idPais { get; set; }

        public DataTable todosconrelacion() {
            var cadena = "SELECT Ciudades.IdCiudad, Ciudades.Detalle as Ciudad, Paises.IdPais, Paises.Detalle AS 'Pais' FROM Ciudades INNER JOIN Paises ON Ciudades.idPais = Paises.IdPais";
            using (var cn = Conexion.GetConnection()) {
                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(cadena, cn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
                catch (SqlException ex)
                {
                    ErrorHandler.ManejarErrorSql(ex, "Error al insertar el autor.");
                }
                catch (Exception ex)
                {
                    ErrorHandler.ManejarErrorGeneral(ex, "Error al insertar el autor.");
                }
                return null;
            }      
        }
    }

    //crud
    
    

}
