using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Represents a person's first name.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents a person's last name.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents a person's email address.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents a person's mobile number.
        /// </summary>
        public string MobileNumber { get; set; }
    }
}
