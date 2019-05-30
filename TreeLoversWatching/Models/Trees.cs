using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace TreeLoversWatching.Models
{
    public class Trees
    {
        public int ID { get; set; }

        [Display(Name = "Tree Name")]
        public string TreeName { get; set; }

        [Display(Name = "Latin Name")]
        public string Latin { get; set; }

        [Display(Name = "Tree Description")]
        public string TreeType { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Tree Category")]
        public string Category { get; set; }

        public Point GeoLocation { get; set; }
 
    }
}
