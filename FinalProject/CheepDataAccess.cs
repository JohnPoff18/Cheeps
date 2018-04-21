using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;

namespace FinalProject
{
    public class CheepDataAccess
    {
        public static List<Cheep> getCheeps()
        {
            List<Cheep> cheepList = new List<Cheep>();

  

            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString))
            {
                db.Open();

                using (SqlCommand selectAllCheeps = new SqlCommand("SELECT TOP(5) Uname, Cheep, Date FROM [CHEEPS] ORDER BY Date ASC", db))
                {
                    using (SqlDataReader cheepsTableReader = selectAllCheeps.ExecuteReader())
                    {
                        while (cheepsTableReader.Read())
                        {
                            Cheep newCheep = new Cheep();
                            newCheep.username = Convert.ToString(cheepsTableReader["Uname"]);
                            newCheep.cheep = Convert.ToString(cheepsTableReader["Cheep"]);
                            newCheep.date = Convert.ToDateTime(cheepsTableReader["Date"]);

                        

                            cheepList.Add(newCheep);
                        }
                    }
                }
            }

            return cheepList;
        }
    }
}