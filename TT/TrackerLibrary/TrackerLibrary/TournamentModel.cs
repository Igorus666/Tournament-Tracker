using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        public string? TournamentName { get; set; }
        // the name of the tournament
        public decimal EntryFee { get; set; }
        //entry each team have to pay
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        //list of the entered teams
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        //the prizes distributed to the winning places
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
        //a list of list, represents the rounds played, if a list of matchups is a round, a list of a list covers all the rounds in the tournament
    }
}
