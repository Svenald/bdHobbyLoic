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

        public List<Etudiant> AfficherEtudiant()
        {
            List<Etudiant> maListeDEtudiant = new List<Etudiant>();
            try
            {
                using (var myConnection = GetConnection())
                {
                    using (var myCommand = CreerCommande("AfficherEtudiant", null))
                    {
                        // executer ma commande
                        // récupérer le résultat
                        using (var monDataReader = myCommand.ExecuteReader())
                        {
                            while (monDataReader.Read())
                            {
                                //private int no_etudiant;
                                //private string prenom;
                                //private string nom;
                                //private string cellulaire;
                                //private int humour;
                                //private int no_provenance;
                                //private string nomComplet;

                                var monEtudiant = new Etudiant();

                                monEtudiant.No_etudiant = (int)monDataReader["no_etudiant"];
                                monEtudiant.Prenom = (string)monDataReader["prenom"]/*.ToString()*/;
                                monEtudiant.Nom = (string)monDataReader["nom"]/*.ToString()*/;
                                monEtudiant.Cellulaire = Convert.ToString(monDataReader["cellulaire"]);/*(string)monDataReader["cellulaire"];*/
                                //if (monDataReader["humour"] is not null)
                                //{
                                //    monEtudiant.Humour = (int)monDataReader["humour"];
                                //}
                                monEtudiant.No_provenance = (int)monDataReader["no_provenance"];
                                maListeDEtudiant.Add(monEtudiant);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return maListeDEtudiant;
        }

    }
}
