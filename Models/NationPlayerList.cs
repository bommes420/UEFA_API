using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UEFA_API_v2.Models
{
    public class NationPlayerList
    {
        public List<Nation> Nation { get; set; }  //table

        public List<Players> Players { get; set; } //table
    }
}