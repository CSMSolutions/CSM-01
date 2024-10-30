using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ModelViews.CustomerModelViews
{
    public class SearchRequest
    {
        public string CustomerName { get; set; } = "";
        public string CustomerPhone { get; set; } = "";
    }
}
