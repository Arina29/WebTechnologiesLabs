using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eUseControl.Web.Models
{
    public class StyleTypes
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string StyleName { get; set; }

    }
}