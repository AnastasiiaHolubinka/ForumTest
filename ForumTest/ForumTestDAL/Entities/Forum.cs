using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTestDAL.Entities
{
    public class Forum : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TopicCount { get; set; }
        public int PostCount { get; set; }
        public virtual List<Topic> Topics { get; set; }
    }
}
