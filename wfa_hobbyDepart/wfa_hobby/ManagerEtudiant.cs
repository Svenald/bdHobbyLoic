using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerEtudiant :Manager
    {
        public int AjouterEtudiant(Etudiant etudiant)
        {
            int nombreDeLignesAffectees = 0;
            try
            {
                using (var myConnection = GetConnection()) //Creation d'une variable pour stocker la connexion
                {
                    using (var maCommande = new SqlCommand("ajouterEtudiant",myConnection)) //utilisation de la variable de connexion
                    {
                        //commandtype
                        maCommande.CommandType = CommandType.StoredProcedure;
                        //définir les paramètres et les ajouter à la commande
                        maCommande.Parameters.Add(new SqlParameter("@prenom", (etudiant.Prenom==""?DBNull.Value:etudiant.Prenom)));
                        maCommande.Parameters.Add(new SqlParameter("@nom", (etudiant.Nom==""?DBNull.Value:etudiant.Nom)));
                        maCommande.Parameters.Add(new SqlParameter("@cellulaire", (etudiant.Cellulaire == "" ? DBNull.Value : etudiant.Cellulaire)));
                        maCommande.Parameters.Add(new SqlParameter("@humour", (etudiant.Humour == 0 ? DBNull.Value : etudiant.Humour)));
                        maCommande.Parameters.Add(new SqlParameter("@no_provenance", (etudiant.No_provenance == 0 ? DBNull.Value : etudiant.No_provenance)));
                        //ouvrir la connexion par la commande
                        maCommande.Connection.Open();
                        //exécuter la commande
                        nombreDeLignesAffectees = maCommande.ExecuteNonQuery();
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
