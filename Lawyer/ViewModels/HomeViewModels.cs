using Lawyer.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lawyer.ViewModels
{
    public class HomeViewModels
    {
        
        
        public List<Award> _award { get; set; }
        public List<Clients> _clients { get; set; }
        public List<Case> _case { get; set; }
        public List<TLawyer> _lawyers { get; set; }
        public List<PracticeArea> _practiceAreas { get; set; }
        public List<Category> _category { get; set; }
        
    }
}