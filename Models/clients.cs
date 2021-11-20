using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ctrl_Gallery_2._0.Models
{
    
    public class Ctrl_users
    {
        public int ID {get;set; }
        public string username{get;set; }

        public string name{get; set;}

        //public ICollection<Upload> Uploads{get; set;}
    }
}