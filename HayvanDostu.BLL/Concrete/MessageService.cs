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
   public class MessageService :IMessageService
    {
        IMessageDAL _messageDAL;
        public MessageService(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }
        public bool Delete(Message model)
        {
            return _messageDAL.Delete(model) > 0;
        }

        public bool DeleteByID(int entityID)
        {
            Message Message = Get(entityID);
            return Delete(Message);
        }

        public Message Get(int entityID)
        {
            return _messageDAL.Get(a => a.ID == entityID);
        }

        public List<Message> GetAll()
        {
            return _messageDAL.GetAll().ToList();
        }

        public bool Insert(Message model)
        {
            return _messageDAL.Add(model) > 0;
        }

        public bool Update(Message model)
        {
            return _messageDAL.Update(model) > 0;

        }

    }
}
