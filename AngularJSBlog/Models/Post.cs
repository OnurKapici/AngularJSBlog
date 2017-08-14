using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularJSBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        [StringLength(200)]
        [Required]
        [Display(Name ="Ad")]
        public string Name { get; set; }
        [Display(Name = "İçerik")]
        public string Body { get; set; }
        [Display(Name = "Yayın Tarihi")]
        public DateTime PublishDate { get; set; }
        [Display(Name = "Yayınlansın mı?")]
        public bool IsPublished { get; set; }
    }
}