using RestAPIAssignment.Models;
using System;

namespace RestAPIAssignment.Repositories
{
    public class Comments
    {
        public class CommentRepository : Repository<Comment>
        {
            internal object Get()
            {
                throw new NotImplementedException();
            }
        }
    }
}