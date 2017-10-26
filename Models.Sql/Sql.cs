using MyAirport.Pim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Pim.Entities;
using System.Configuration;
using System.Data.SqlClient;

namespace MyAirport.Pim.Models
{
    public class Sql : AbstractDefinition
    {

        string strCnx = ConfigurationManager.ConnectionStrings["MyAirport.Pim.Settings.DbConnect"].ConnectionString;

        string commandGetBagageIata = "SELECT b.ID_BAGAGE, c.NOM as compagnie, b.CODE_IATA, b.LIGNE, b.DATE_CREATION, b.ESCALE, cc.PRIORITAIRE ,cast(iif(b.CONTINUATION='N',0,1) as bit) as Continuation, cast(iif(bp.PARTICULARITE is null, 0, 1) as bit) as 'RUSH' FROM BAGAGE b LEFT OUTER JOIN BAGAGE_A_POUR_PARTICULARITE bap on bap.ID_BAGAGE = b.ID_BAGAGE LEFT OUTER JOIN BAGAGE_PARTICULARITE bp on bp.ID_PART = bap.ID_PARTICULARITE and bp.PARTICULARITE = 'RUSH' LEFT OUTER JOIN COMPAGNIE c on c.CODE_IATA = b.COMPAGNIE LEFT OUTER JOIN COMPAGNIE_CLASSE cc on cc.ID_COMPAGNIE = c.ID_COMPAGNIE and cc.CLASSE = b.CLASSE WHERE b.CODE_IATA = @codeIata;";
        string commandGetBagageId = "SELECT b.ID_BAGAGE, c.NOM as compagnie, b.CODE_IATA, b.LIGNE, b.DATE_CREATION, b.ESCALE, cc.PRIORITAIRE ,cast(iif(b.CONTINUATION='N',0,1) as bit) as Continuation, cast(iif(bp.PARTICULARITE is null, 0, 1) as bit) as 'RUSH' FROM BAGAGE b LEFT OUTER JOIN BAGAGE_A_POUR_PARTICULARITE bap on bap.ID_BAGAGE = b.ID_BAGAGE LEFT OUTER JOIN BAGAGE_PARTICULARITE bp on bp.ID_PART = bap.ID_PARTICULARITE and bp.PARTICULARITE = 'RUSH' LEFT OUTER JOIN COMPAGNIE c on c.CODE_IATA = b.COMPAGNIE LEFT OUTER JOIN COMPAGNIE_CLASSE cc on cc.ID_COMPAGNIE = c.ID_COMPAGNIE and cc.CLASSE = b.CLASSE WHERE b.id_bagage = @id;";

        public override List<BagageDefinition> GetBagage(string codeIataBagage)
        {
            List<BagageDefinition> list = new List<BagageDefinition>();
            BagageDefinition bagRes = new BagageDefinition();
            

            using (SqlConnection cnx = new SqlConnection(strCnx))
            {
                SqlCommand cmd = new SqlCommand(this.commandGetBagageIata, cnx);    
                cmd.Parameters.AddWithValue("@codeIata", codeIataBagage);
                cnx.Open();

                //Implémenter ici le code de récupération et de convertion
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        bagRes.CodeIata = sdr.GetString(sdr.GetOrdinal("code_iata"));
                        bagRes.Compagnie = sdr.GetString(sdr.GetOrdinal("compagnie"));
                        bagRes.DateVol = sdr.GetDateTime(sdr.GetOrdinal("date_creation"));  //            
                        bagRes.EnContinuation = sdr.GetBoolean(sdr.GetOrdinal("continuation")); //
                        bagRes.IdBagage = sdr.GetInt32(sdr.GetOrdinal("id_bagage")); //
                        bagRes.Itineraire = sdr.GetString(sdr.GetOrdinal("escale"));
                        bagRes.Ligne = sdr.GetString(sdr.GetOrdinal("ligne"));
                        bagRes.Prioritaire = sdr.GetBoolean(sdr.GetOrdinal("prioritaire")); //

                        list.Add(bagRes);
                    }
                }
            }
            return list;
        }

        public override BagageDefinition GetBagage(int idBagage)
        {
            //List<BagageDefinition> list = new List<BagageDefinition>();
            BagageDefinition bagRes =  new BagageDefinition();

            using (SqlConnection cnx = new SqlConnection(strCnx))
            {
                SqlCommand cmd = new SqlCommand(this.commandGetBagageId, cnx);
                cmd.Parameters.AddWithValue("@id", idBagage);
                cnx.Open();

                //Implémenter ici le code de récupération et de convertion
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
            
                        bagRes.CodeIata = sdr.GetString(sdr.GetOrdinal("code_iata"));
                        bagRes.Compagnie = sdr.GetString(sdr.GetOrdinal("compagnie"));
                        bagRes.DateVol = sdr.GetDateTime(sdr.GetOrdinal("date_creation"));  //            
                        bagRes.EnContinuation = sdr.GetBoolean(sdr.GetOrdinal("continuation")); //
                        bagRes.IdBagage = sdr.GetInt32(sdr.GetOrdinal("id_bagage")); //
                        bagRes.Itineraire = sdr.GetString(sdr.GetOrdinal("escale"));
                        bagRes.Ligne = sdr.GetString(sdr.GetOrdinal("ligne"));
                        bagRes.Prioritaire = sdr.GetBoolean(sdr.GetOrdinal("prioritaire")); //

                        //list.Add(bagRes);
                    }
                }
            }
            return bagRes;
        }

    }
}
