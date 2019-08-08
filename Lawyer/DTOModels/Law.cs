using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lawyer.DTOModels
{
    public class Law
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Question { get; set; }
        public string Answere { get; set; }

    }
}