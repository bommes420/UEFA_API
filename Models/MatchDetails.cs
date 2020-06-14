using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UEFA_API_v2.Models
{
    public class MatchDetails
    {
        public MatchDetails()
        {
            // we maken een nieuw object aan voor HomeTeamStats (van het type MatchStats).
            HomeTeamStats = new MatchStats();
            AwayTeamStats = new MatchStats();
            YellowCardsHomeTeam = new MatchStats();
            RedCardsHomeTeam = new MatchStats();
            YellowCardsAwayTeam = new MatchStats();
            RedCardsAwayTeam = new MatchStats();
            // hier ook de andere subobjecten even eenmalig aanmaken.
            // YellowCardsHomeTeam
            // RedCardsHomeTeam
            // etc 
            // etc

        }

        public int MatchID { get; set; }

        public Team HomeTeam { get; set; }
        public int HomeTeamId { get; set; }

        public Team AwayTeam { get; set; }
        public int AwayTeamId { get; set; }

        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }

        public MatchStats YellowCardsHomeTeam { get; set; }

        public MatchStats RedCardsHomeTeam { get; set; }

        public MatchStats YellowCardsAwayTeam { get; set; }

        public MatchStats RedCardsAwayTeam { get; set; }

        public MatchStats AwayTeamStats { get; set; }

        public MatchStats HomeTeamStats { get; set; }
    }
}