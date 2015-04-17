using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Til.Mobile.Api.Models
{
    public class GetPostsResponse
    {
        public int Count { get; set; }
      
        public List<Post> Posts { get; set; } 
    }
}
