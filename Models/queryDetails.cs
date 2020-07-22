using System.Collections.Generic;

namespace nbaMVC{
    public class queryDetails{
        public string name {get; set;}
        public string season {get; set;}
        public Dictionary<string, bool> categories {get; set;}

        public queryDetails(){
            categories.Add("pts", false);
            categories.Add("reb", false);
            categories.Add("fgm3", false);
            categories.Add("stl", false);
            categories.Add("blk", false);
            categories.Add("tov", false);
            categories.Add("mins", false);
            categories.Add("fgPer", false);
            categories.Add("ftPer", false);
        }
    }
}