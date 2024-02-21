using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerEtudiant
    {
        public int AjouterEtudiant(Etudiant etudiant)
        {
            int nombreDeLignesAffectees = 0;
            try
            {
                using (var myConnection = new SqlConnection(Properties.Settings.Default.maconnexionString)) //Creation d'une variable pour stocker la connexion
                {
                    using (var maCommande = new SqlCommand("ajouterEtudiant",myConnection)) //utilisation de la variable de connexion
                    {
                        //commandtype
                        maCommande.CommandType = CommandType.StoredProcedure;
                        //définir les paramètres et les ajouter à la commande
                        //ouvrir la connexion
                        //exécuter la commande
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
