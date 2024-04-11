using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerHobby :Manager
    {
        public List<Hobby> ListerHobby()
        {
            List<Hobby> maListeDeHobby = new List<Hobby>();
            try
            {
                using (var myConnection = GetConnection())
                {
                    using (var myCommand = CreerCommande("AfficherHobby", null))
                    {
                        // executer ma commande
                        // récupérer le résultat
                        using (var monDataReader = myCommand.ExecuteReader())
                        {
                            while (monDataReader.Read())
                            {
                                var monHobby = new Hobby();
                                monHobby.No_hobby = (int)monDataReader["no_hobby"];
                                monHobby.NomHobby = (string)monDataReader["hobby"]/*.ToString()*/;
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
