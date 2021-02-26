using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ForumTest.Models
{
    public class ForumModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter subforum name")]
        [MaxLength(15, ErrorMessage = "Max lenght 15 characters exceeded")]
        [Display(Name = "Subforum name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter description")]
        [MaxLength(500, ErrorMessage = "Max lenght 500 characters exceeded")]
        public string Description { get; set; }
        public int TopicCount { get; set; }
        public int PostCount { get; set; }
        public IEnumerable<TopicModel> Topics { get; set; }
        public int UserId { get; set; }
        public ForumModel Forum { get; set; }
    }
}