using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using Importador_de_Compras.modelos;
using System.Data;

namespace Importador_de_Compras.controladores
{
    public class FirebirdDAL
    {
        private FbConnection Connection;
        private FbCommand Command;
        private FbDataAdapter Adapter;

        public FirebirdDAL()
        {
            Connection = new FbConnection(ObtenerStringDeConexion());
            
            Command = new FbCommand();
            Command.Connection = Connection;

            Adapter = new FbDataAdapter();
        }

        private string ObtenerStringDeConexion()
        {
            FbConnectionStringBuilder miString = new FbConnectionStringBuilder();

            var Configuraciones = Properties.Settings.Default;

            miString.DataSource = Configuraciones.Servidor;
            miString.Database = Configuraciones.BaseDeDatos;
            miString.UserID = Configuraciones.Usuario;
            miString.Password = Configuraciones.Contraseña;
            miString.Port = Convert.ToInt32(Configuraciones.Puerto);

            return miString.ToString();
        }

        public List<Articulos> ObtenerArticulos(string[] arrTokens)
        {
            List<Articulos> lstArticulos = new List<Articulos>();

            Connection.Open();
            Command.CommandText = 
                string.Format(@"SELECT 
                                  A.ARTICULO_ID,
                                  C.CLAVE_ARTICULO,
                                  A.NOMBRE
                                FROM
                                  CLAVES_ARTICULOS C
                                  INNER JOIN ARTICULOS A ON (C.ARTICULO_ID = A.ARTICULO_ID)
                                  INNER JOIN ROLES_CLAVES_ARTICULOS R ON (C.ROL_CLAVE_ART_ID = R.ROL_CLAVE_ART_ID)
                                WHERE
                                  R.ES_PPAL = 'S' AND (");

            for (int i = 0; i < arrTokens.Length; i++)
            {
                Command.CommandText += string.Format("A.NOMBRE LIKE '%{0}%' ", arrTokens[i]);
                if (i == (arrTokens.Length - 1))
                    Command.CommandText += "OR ";
            }
            Command.CommandText += ")";

            Adapter.SelectCommand = Command;
            DataTable dtRespuesta = new DataTable();
            Adapter.Fill(dtRespuesta);

            Articulos articulo;
            foreach(DataRow fila in dtRespuesta.Rows)
            {
                articulo = new Articulos();
                articulo.ID = Convert.ToInt32(fila["ARTICULO_ID"]);
                articulo.Clave = Convert.ToString(fila["CLAVE_ARTICULO"]);
                articulo.Nombre = Convert.ToString(fila["NOMBRE"]);

                lstArticulos.Add(articulo);
            }

            return lstArticulos;
        }
    }
}
