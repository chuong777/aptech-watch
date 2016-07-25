using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AptechWatch.Dao;
using AptechWatch.Entity;

namespace AptechWatch.Service
{
    public class ChatService : BaseService<Chat>
    {
        public ChatService() : base(new ChatDao())
        {
        }
    }
}