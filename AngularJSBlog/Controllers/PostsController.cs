using AngularJSBlog.Data;
using AngularJSBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularJSBlog.Controllers
{
    public class PostsController : ApiController
    {
        public IList<Post> Get()
        {
            using (var db= new ApplicationDbContext())
            {
                return db.Posts.ToList();
            }
        }
        public Post Get(int Id)
        {
            Post post = new Models.Post();

            using (var db = new ApplicationDbContext())
            {
                
                post = db.Posts.Where(x => x.Id == Id).FirstOrDefault();
                return post;
            }
        }

        public void Post(Post post)
        {
            using (var db = new ApplicationDbContext())
            {
                
                db.Posts.Add(post);
                db.SaveChanges();
              
            }
        }

        public void Put(Post post)
        {
            using (var db = new ApplicationDbContext())
            {

                db.Entry(post).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
        }

        public void Delete(int Id)
        {
            using (var db = new ApplicationDbContext())
            {
                Post post = new Models.Post();
                post = db.Posts.FirstOrDefault(x => x.Id == Id);

                db.Posts.Remove(post);
                db.SaveChanges();

            }
        }



    }
}
