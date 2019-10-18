using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CELForum.Models
{
    public class ForumTopicModel
    {
        public ForumListingModel Forum { get; set; }
        public IEnumerable<PostListingModel> Posts { get; set; }
    }
}
