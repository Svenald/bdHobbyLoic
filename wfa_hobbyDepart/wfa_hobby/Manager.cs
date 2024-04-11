using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class Manager
    {
        // protected signifie utilisable que par ses filles, sans new
        protected SqlConnection GetConnection()
        {
            var myConnection = new SqlConnection(Properties.Settings.Default.maconnexionString);
            return myConnection;
        }
        protected SqlCommand CreerCommande(string nomProcedureStockee, List<SqlParameter> MySqlParameters)
        {
            SqlCommand myCommand = new SqlCommand(nomProcedureStockee, GetConnection());
            //Defind commandType
            myCommand.CommandType = CommandType.StoredProcedure;
            //associate parameters with the command
            if (MySqlParameters != null)
            {
                myCommand.Parameters.AddRange(MySqlParameters.ToArray());
            }
            //Open the connection with the command
            myCommand.Connection.Open();
            return myCommand;
        }
    }
}
