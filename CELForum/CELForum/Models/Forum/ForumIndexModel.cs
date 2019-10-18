using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CELForum.Models
{
    public class ForumIndexModel
    {
        public IEnumerable<ForumListingModel> ForumList { get; set; }
    }
}
