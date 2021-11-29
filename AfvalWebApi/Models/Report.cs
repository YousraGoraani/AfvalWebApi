using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfvalWebApi.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }
        public string Problem { get; set; }
    }
}
