using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moment_3___CDsamling.Models
{
    public class CDskivor
    {
        //Properties

        public int Id { get; set; }

        public string Artist { get; set; }

        public string Album { get; set; }

        public int Utgivning { get; set; }
    }
}
