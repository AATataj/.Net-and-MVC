using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using MySqlConnector;
using System;


namespace nbaMVC{
    public class queryDetails{
        nbaDB db {get;}
        public string name {get; set;}
        public string season {get; set;}

        //declare the car names as a static array of strings
        //this works becuase static variables are consistent among all instances of class
        public static string[] catNames = {"pts", "reb", "3fgm", "stl", "blk", "tov", "mins", "fgPer", "ftPer"};
        public List<Dictionary<string,dynamic>> results = new List<Dictionary<string,dynamic>>();
        public List<string> catValues {get; set;}
        public queryDetails(string name, string season, List<string> catvalues, nbaDB DB){
            this.db = DB;
            this.name = name;
            this.season = season;
            this.catValues = new List<string>();
            this.catValues.Add("date,");
            foreach (string cat in catvalues){
                this.catValues.Add(cat);
            }
        }
        public async Task<List<Dictionary<string,dynamic>>> runQuery(){
            string query = "select ";
            string startDate = string.Format("'{0}-09-01'", this.season.Substring(0, 4));
            string endDate = string.Format("'{0}-08-01'", this.season.Substring(5));
            using var cmd = db.Connection.CreateCommand();
            foreach(string cat in this.catValues){
                if (cat.Equals("reb,"))
                    query += "trb,";
                else
                    query += cat;
            }
            query = query.Remove(query.Length -1 );
            query += " from boxscores where name = '{0}' and date > {1} and date < {2};";
            query = string.Format(query, name, startDate, endDate);
            cmd.CommandText = query;
            Console.WriteLine(cmd.CommandText);
            DbDataReader reader = await cmd.ExecuteReaderAsync();
            using (reader){
                while (await reader.ReadAsync()){
                    Dictionary<string, dynamic> newDict = new Dictionary<string, dynamic>();
                    for(int i=0; i< catValues.Count; i++){
                        newDict.Add(catValues[i], reader.GetValue(i).ToString());
                    }
                    this.results.Add(newDict);
                }
            }
            foreach(var row in this.results){
                foreach( var value in row){
                    Console.WriteLine(value.Value);
                }
            }
            return this.results;
        }

    }
}