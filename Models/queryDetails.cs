using System.Collections.Generic;

namespace nbaMVC{
    public class queryDetails{
        public string name {get; set;}
        public string season {get; set;}
        //declare the car names as a static array of strings
        //this works becuase static variables are consistent among all instances of class
        public static string[] catNames = {"pts", "reb", "3fgm", "stl", "blk", "tov", "mins", "fgPer", "ftPer"};
        public List<string> catValues {get; set;}
        public queryDetails(string name, string season, List<string> catvalues){
            this.name = name;
            this.season = season;
            foreach (string cat in catvalues){
                this.catValues.Add(cat);
            }
        }

    }
}