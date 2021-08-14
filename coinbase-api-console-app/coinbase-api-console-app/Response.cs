using coinbase_api_console_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coinbase_api_console_app
{
    public class Response
    {
        public Time Time { get; set; }

        public string Disclaimer { get; set; }

        public string ChartName { get; set; }

        public Bpi Bpi { get; set; }
    }
}
