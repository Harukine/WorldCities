﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCities.Data.Models
{
    public class City
    {
        #region Constructor
        public City()
        {

        }
        #endregion

        #region Properties
        /// <summary>
        /// The unique id and primary key for this City
        /// </summary>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// City name (in UTF8 format)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// City name (in ASCII format)
        /// </summary>
        public string Name_ACSII { get; set; }

        /// <summary>
        /// City latitude
        /// </summary>
        public decimal Lat { get; set; }

        /// <summary>
        /// City longitude
        /// </summary>
        public decimal Lon { get; set; }
        #endregion

        /// <summary>
        /// Country Id (foreign key)
        /// </summary>
        public int CountryId { get; set; }

    }
}