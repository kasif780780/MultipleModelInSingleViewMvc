using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lawyer.DTOModels
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryTitle { get; set; }
        public string CatDescription { get; set; }
    }
}