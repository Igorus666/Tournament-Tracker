using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
         public TeamModel? TeamCompeting { get; set; }
        //represents the team competing
        public double  Score { get; set; }
        //represents the score of the team
        public MatchupModel? ParentMatchup { get; set; }
        //represents the matchup in witch the team came winner

    }
}
