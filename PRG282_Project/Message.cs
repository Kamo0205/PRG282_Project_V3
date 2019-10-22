using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG282_Project
{
    class Message
    {
        private Person person;
        private string content;

        public Message(Person person, string content)
        {
            this.person = person;
            this.content = content;
        }

        public string Content { get => content; }
        internal Person Person { get => person; }

        public override string ToString()
        {
            return string.Format("{0}#{1}#{2}",this.Person.Name,this.person.Surname,this.Content);
        }
    }
}
