using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lawyer.DTOModels
{
    public class Social
    {
        public int SocialId { get; set; }

        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string SkypeUrl { get; set; }
        public string YoutubeUrl { get; set; }
        public string LinkedInUrl { get; set; }

    }
}