using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatApp.Models
{
    public class ChatModel
    {
        public List<ChatUser> Users;
        public List<ChatMessage> Messages;

        public ChatModel()
        {
            Users = new List<ChatUser>();
            Messages = new List<ChatMessage>();

            Messages.Add(new ChatMessage() { Text = "чат запущен" });
        }
    }

    public class ChatUser
    {
        public string Name;
        public DateTime LoginTime; 
        public DateTime LastPing;
    }

    public class ChatMessage
    {
        public ChatUser User;
        public DateTime Date = DateTime.Now;
        public string Text = "";
    }
}