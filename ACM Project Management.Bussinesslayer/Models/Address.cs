using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_Project_Management.Bussinesslayer.Models
{
    public class Address
    {
        /// <summary>
        /// Gets or sets the apartment or house number.
        /// </summary>
        public int? AptOrHosueNumber { get; set; }

        /// <summary>
        /// Gets or sets the city name.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the country name.
        /// </summary>
        public string Country { get;  set; }

        /// <summary>
        /// Gets or sets the lane.
        /// </summary>
        public string Lane { get;  set; }

        /// <summary>
        /// Gets or sets the state name.
        /// </summary>
        public string State { get;  set; }

        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        public int ZipCode{ get;  set; }
    }
}
