using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ragistration_from.Models
{
    public class Stdmodel
    {
        public int Id { get; set; }
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Lname { get; set; }
        [Required]
        public string Qalification { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}