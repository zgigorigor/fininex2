using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace fininex2.Models
{
    public class EntryModel
    {
        [Required(ErrorMessage = "You need to write entry name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You need to write entry amount!")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "You need to write entry currency!")]
        public string Currency { get; set; }

        [Required(ErrorMessage = "You need to write entry description!")]
        public string Description { get; set; }
    }
}