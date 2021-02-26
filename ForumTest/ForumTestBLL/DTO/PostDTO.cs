﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTestBLL.DTO
{
    public class PostDTO
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime? PostTime { get; set; }
        public int TopicId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}
