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
    public class CommentsController : ApiController
    {
        CommentRepository commentRepository = new CommentRepository();
        public IHttpActionResult Get()
        {
            return Ok(commentRepository.GetAll());
        }
        public IHttpActionResult Get(int id)
        {
            var comment = commentRepository.Get(id);
            if (comment == null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Ok(commentRepository.Get(id));
        }

        public IHttpActionResult Post(Comment comment)
        {
            commentRepository.Insert(comment);
            return Created("api/posts/" + comment.CommentID, comment);
        }
        public IHttpActionResult Put([FromUri]int id, [FromBody]Post comment)
        {
            comment.CommentID = id;
            commentRepository.Update(comment);
            return Ok(comment);
        }
        public IHttpActionResult Delete(int id)
        {
            commentRepository.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}

