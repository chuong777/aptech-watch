using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Message:BaseEntity
    {
        [Required]
        public int ChatId { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public string Content { get; set; }
        public bool IsAdmin { get; set; }

        public Message()
        {

        }
        public Message(int chatId, DateTime time, string content, bool isAdmin)
        {
            ChatId = chatId;
            Time = time;
            Content = content;
            IsAdmin = isAdmin;
        }
    }
}