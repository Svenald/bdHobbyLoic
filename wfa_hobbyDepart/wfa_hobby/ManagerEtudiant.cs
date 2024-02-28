using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerEtudiant : Manager
    {
        private List<SqlParameter> DefindParametersAdd(Etudiant etudiant)
        {
            List<SqlParameter> myList = new List<SqlParameter>();
            myList.Add(new SqlParameter("@prenom", (etudiant.Prenom == "" ? DBNull.Value : etudiant.Prenom)));
            myList.Add(new SqlParameter("@nom", (etudiant.Nom == "" ? DBNull.Value : etudiant.Nom)));
            myList.Add(new SqlParameter("@cellulaire", (etudiant.Cellulaire == "" ? DBNull.Value : etudiant.Cellulaire)));
            myList.Add(new SqlParameter("@humour", (etudiant.Humour == 0 ? DBNull.Value : etudiant.Humour)));
            myList.Add(new SqlParameter("@no_provenance", (etudiant.No_provenance == 0 ? DBNull.Value : etudiant.No_provenance)));
            return myList;
        }
        public int AjouterEtudiant(Etudiant etudiant)
        {
            int nombreDeLignesAffectees = 0;
            try
            {
                using (var myConnection = new SqlConnection(Properties.Settings.Default.maconnexionString)) //Creation d'une variable pour stocker la connexion
                {
                    using (var myCommand = new SqlCommand("ajouterEtudiant", myConnection)) //utilisation de la variable de connexion
                    {
                        //commandtype
                        myCommand.CommandType = CommandType.StoredProcedure;
                        //définir les paramètres et les ajouter à la commande
                        List<SqlParameter> myList = DefindParametersAdd(etudiant);
                        myCommand.Parameters.AddRange(myList.ToArray());

                        //ouvrir la connexion par la commande
                        myCommand.Connection.Open();
                        //exécuter la commande
                        nombreDeLignesAffectees = myCommand.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception)
            {
                throw;
            }
            return nombreDeLignesAffectees;
        }

    }
}
