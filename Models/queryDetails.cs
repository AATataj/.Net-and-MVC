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
            foreach (string cat in catvalues){
                this.catValues.Add(cat);
            }
        }
        public async Task<List<Dictionary<string,dynamic>>> runQuery(){//DbDataReader reader){
            string query = "select ";
            foreach(string cat in this.catValues){
                query += cat;
            }
            query += " ";
            query = query.Remove(query.Length -1 );
            query += "from boxscores where name = '{0}' and ";
            query = string.Format(query, name);
            Console.WriteLine(query);
            await Task.Delay(10);
            return this.results;
        }

    }
}