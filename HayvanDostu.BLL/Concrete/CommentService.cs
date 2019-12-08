using HayvanDostu.BLL.Abstract;
using HayvanDostu.DAL.Abstarct;
using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.Concrete
{
    public class CommentService : ICommentService
    {
        ICommentDAL _commentDAL;

        public CommentService(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }
        public bool Delete(Comment model)
        {
            return _commentDAL.Delete(model) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            Comment Comment = Get(entityID);
            return Delete(Comment);
        }

        public Comment Get(int entityID)
        {
            return _commentDAL.Get(a => a.ID == entityID);
        }

        public List<Comment> GetAll()
        {
            return _commentDAL.GetAll().ToList();
            
        }

        public bool Insert(Comment model)
        {
            return _commentDAL.Add(model) > 0;
        }

        public bool Update(Comment model)
        {
            return _commentDAL.Update(model) > 0;
        }
    }
}
