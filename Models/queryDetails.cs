using System.Collections.Generic;

namespace nbaMVC{
    public class queryDetails{
        public string name {get; set;}
        public string season {get; set;}
        public Dictionary<string, bool> categories {get; set;}
        public List<string> catNames {get; set;}
        public List<bool> catValues {get; set;}

        public queryDetails(){
            this.categories = new Dictionary<string, bool>();
            this.categories.Add("pts", false);
            this.categories.Add("reb", false);
            this.categories.Add("fgm3", false);
            this.categories.Add("stl", false);
            this.categories.Add("blk", false);
            this.categories.Add("tov", false);
            this.categories.Add("mins", false);
            this.categories.Add("fgPer", false);
            this.categories.Add("ftPer", false);

            this.catNames = new List<string>();
            this.catNames.Add("pts");
            this.catNames.Add("reb");
            this.catNames.Add("fgm3");
            this.catNames.Add("stl");
            this.catNames.Add("blk");
            this.catNames.Add("tov");
            this.catNames.Add("mins");
            this.catNames.Add("fgPer");
            this.catNames.Add("ftPer");

            this.catValues = new List<bool>();
            for (int i=0; i < this.catValues.Count; i++){
                this.catValues.Add(false);
            }
        }
    }
}