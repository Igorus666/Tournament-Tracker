using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        //Represent the team competing in this matchup
        public TeamModel? Winner { get; set; }
        //represents the winner of the matchup
        public int MatchupRound { get; set; }
        //represents the current round this matchup takes place
    }
}
