using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using MySqlConnector;

namespace nbaMVC{
    public class testQuery{
        public string name {get; set;}
        public int pts {get; set;}
        public int reb {get; set;}
        public int fgm3 {get; set;}
        public int stl {get; set;}
        public int blk {get; set;}
        public int tov {get; set;}
        public int mins {get; set;}
        public float fgPer {get; set;}
        public float ftPer {get; set;}
        public nbaDB db {get;}
        public testQuery(nbaDB DB){
            db = DB;
        }
        public async Task<List<testQuery>> runQuery(){
            using var cmd = db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT name, pts, trb, 3fgm, stl, blk, tov, minutes, fgPer, ftPer  FROM boxscores limit 5;";
            return await retrieveData(await cmd.ExecuteReaderAsync());
        }
        private async Task<List<testQuery>> retrieveData(DbDataReader reader)
        {
            var posts = new List<testQuery>();
            using (reader)
            {
                while (await reader.ReadAsync())
                {
                    var post = new testQuery(db)
                    {
                        name = reader.GetString(0),
                        pts = reader.GetInt16(1),
                        reb = reader.GetInt16(2),
                        fgm3 = reader.GetInt16(3),
                        stl = reader.GetInt16(4),
                        blk = reader.GetInt16(5),
                        tov = reader.GetInt16(6),
                        mins = reader.GetInt16(7),
                    };
                    if (reader.IsDBNull(8)){
                        post.fgPer = 0;
                    }else{
                        post.fgPer = (float)reader.GetDecimal(8);
                    }
                    if (reader.IsDBNull(9)){
                        post.ftPer = 0;
                    }else{
                        post.ftPer = (float)reader.GetDecimal(9);
                    }
                    posts.Add(post);
                }
            }
            return posts;
        }
    }
}