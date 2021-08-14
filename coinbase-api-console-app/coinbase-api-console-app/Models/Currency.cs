using coinbase_api_console_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace coinbase_api_console_app
{
    public class Currency
    {
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Rate { get; set; }
        public string Description { get; set; }
        public float Rate_Float { get; set; }
    }
}
