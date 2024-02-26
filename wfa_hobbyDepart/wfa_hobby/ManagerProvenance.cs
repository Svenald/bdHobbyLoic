using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerProvenance
    {
        public List<Provenance> ListerProvenance()
        {
            var maListeProvenance = new List<Provenance>();
            try
            {
                using (var maConnexion = new SqlConnection(Properties.Settings.Default.maconnexionString))
                {
                    using (var maCommande = new SqlCommand("ListerProvenance", maConnexion))
                    {
                        // spécifier le commandtype
                        maCommande.CommandType = CommandType.StoredProcedure;
                        // donner les parametres
                        //maCommande.Parameters.Add(new SqlParameter("@provenance", ));
                        // ouvrir la connexion avec la commande
                        maCommande.Connection.Open();
                        // executer ma commande
                        // récupérer le résultat
                        using (var monDataReader = maCommande.ExecuteReader())
                        {
                            while (monDataReader.Read()) 
                            {
                                var maProvenance = new Provenance();
                                maProvenance.No_provenance = (int)monDataReader["no_provenance"];
                                maProvenance.ProvenanceDescription = (string)monDataReader["provenance"]/*.ToString()*/;
                                maListeProvenance.Add(maProvenance);
                            }
                            

                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            return maListeProvenance;

        }
    }
}
