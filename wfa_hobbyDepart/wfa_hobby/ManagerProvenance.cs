using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerProvenance :Manager
    {
        public List<Provenance> ListerProvenance()
        {
            List<Provenance> maListeProvenance = new List<Provenance>();
            try
            {
                using (var myConnection = GetConnection())
                {
                    using (var myCommand = CreateCommand("ListerProvenance", null))
                    {
                        // executer ma commande
                        // récupérer le résultat
                        using (var monDataReader = myCommand.ExecuteReader())
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
