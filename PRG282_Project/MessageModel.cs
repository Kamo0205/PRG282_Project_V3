using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG282_Project
{
    class MessageModel
    {
        List<Message> messages;
        DataHandler dh = new DataHandler();
        public MessageModel()
        {

        }

        public List<Message> Messages { get => messages; }

        public void AddMessage(Message message)
        {
            
        }
    }
}
