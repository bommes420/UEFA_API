using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UEFA_API_v2.Models;

namespace UEFA_API_v2.Controllers
{
    public class PlayersController : ApiController
    {
        public IEnumerable<Players> GetPlayers()
        {
            using (UEFA_DBEntities db = new UEFA_DBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                return db.Players.ToList();
            }
        }
        public Players GetPlayer(int id)
        {
            using (UEFA_DBEntities db = new UEFA_DBEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.Players.Include("Nation").FirstOrDefault(p => p.Player_ID == id);
                
            }
        }
    }
}
