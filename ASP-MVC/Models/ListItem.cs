using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MVC.Models
{
    public class ListItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string itemName { get; set; }
        public int time { get; set; }
        public int value { get; set; }
    
    
    }

}
