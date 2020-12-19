using RestAPIAssignment.Models;
using RestAPIAssignment.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestAPIAssignment.Controllers
{
    public class PostsController : ApiController
    {
        PostRepository postRepository = new PostRepository();
        public IHttpActionResult Get()
        {
            return Ok(postRepository.GetAll());
        }
        public IHttpActionResult Get(int id)
        {
            var post = postRepository.Get(id);
            if(post==null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Ok(postRepository.Get(id));
        }

        public IHttpActionResult Post(Post post)
        {
            postRepository.Insert(post);
            return Created("api/posts/"+post.PostID,post);
        }
        public IHttpActionResult Put([FromUri]int id,[FromBody]Post post)
        {
            post.PostID = id;
            postRepository.Update(post);
            return Ok(post);
        }
        public IHttpActionResult Delete(int id)
        {
            postRepository.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }

    
}
