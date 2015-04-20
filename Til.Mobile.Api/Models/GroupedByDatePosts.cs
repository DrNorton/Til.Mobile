using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Til.Mobile.Api.Models
{
    public class GroupedByDatePosts
    {
        public DateTime Date { get; set; }
        public List<Post> Posts { get; set; } 
    }


  
}
