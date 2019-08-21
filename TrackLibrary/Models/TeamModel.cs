using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        /// <summary>
        /// A list of people that make up a team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// A name for a team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
