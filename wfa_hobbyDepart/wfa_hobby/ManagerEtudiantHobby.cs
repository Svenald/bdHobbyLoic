using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerEtudiantHobby : Manager
    {
        private List<SqlParameter> DefindParametersAdd(Etudiant etudiant, Hobby hobby)
        {
            List<SqlParameter> myList = new List<SqlParameter>();
            myList.Add(new SqlParameter("@no_etudiant", (etudiant.No_provenance == 0 ? DBNull.Value : etudiant.No_etudiant)));
            myList.Add(new SqlParameter("@no_hobby", (hobby.No_hobby == 0 ? DBNull.Value : hobby.No_hobby)));
            return myList;
        }
        public int LierHobbyAvecEtudiant(Etudiant etudiant, Hobby hobby)
        {
            int nombreDeLignesAffectees = 0;
            List<SqlParameter> myList = DefindParametersAdd(etudiant, hobby);
            try
            {
                using (var myConnection = GetConnection()) //Creation d'une variable pour stocker la connexion
                {
                    using (var myCommand = CreerCommande("AssocierUnHobbyAUnEtudiant", myList)) //utilisation de la variable de connexion
                    {
                        nombreDeLignesAffectees = myCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException SQLex)
            {
                if (SQLex.Number == 2627)
                {
                    throw new Exception("Cet étudiant aime déjà ce hobby");
                }
                else
                    throw;
            }

            catch (Exception)
            {
                throw;
            }
            return nombreDeLignesAffectees;
        }

        public int CompterNombreHobby(int no_etudiant)
        {
            List<SqlParameter> mesParametres = new List<SqlParameter>();
            mesParametres.Add(new SqlParameter("@no_etudiant", (no_etudiant == 0 ? DBNull.Value : no_etudiant)));
            int compterNombreHobby = 0;
            try
            {
                using (var maConnexion = GetConnection())
                {
                    using (var maCommande = CreerCommande("CompterNombreDeHobby", mesParametres))
                    {
                        compterNombreHobby = (int)maCommande.ExecuteScalar();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return compterNombreHobby;
        }

        public List<Hobby> ListerLesHobbyDeLEtudiant(int no_etudiant)
        {
            List<Hobby> maListeDeHobby = new List<Hobby>();
            List<SqlParameter> mesParametres = new List<SqlParameter>();
            mesParametres.Add(new SqlParameter("@no_etudiant", (no_etudiant == 0 ? DBNull.Value : no_etudiant)));
            try
            {
                using (var maConnexion = GetConnection())
                {
                    using (var maCommande = CreerCommande("ListerHobbyDeLEtudiant", mesParametres))
                    {
                        using (var monDataReader = maCommande.ExecuteReader())
                        {
                            while (monDataReader.Read())
                            {
                                var monHobby = new Hobby();
                                monHobby.No_hobby = (int)monDataReader["no_hobby"];
                                monHobby.NomHobby = Convert.ToString(monDataReader["hobby"])/*.ToString()*/;
                                maListeDeHobby.Add(monHobby);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return maListeDeHobby;
        }
    }
}
