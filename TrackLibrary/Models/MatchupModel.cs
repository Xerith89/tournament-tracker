using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// A list of the teams competing in a matchup.
        /// </summary>
        public int Id { get; set; }
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// The winning team of a matchup.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// What round number this matchup was.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
