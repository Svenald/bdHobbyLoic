using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerLierEtudiantHobby : Manager
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
                    using (var myCommand = CreateCommand("AssocierUnHobbyAUnEtudiant", myList)) //utilisation de la variable de connexion
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
    }
}
