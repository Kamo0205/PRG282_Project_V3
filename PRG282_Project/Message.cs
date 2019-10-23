using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG282_Project
{
    class Message
    {
        private string content;

	    public string Content
	    {
		    get { return content;}
		    set { content = value;}
	    }

        private Person person;

        internal Person Person
        {
            get { return person; }
            set { person = value; }
        }
        

        public Message(Person person, string content)
        {
            this.person = person;
            this.content = content;
        }

        public override string ToString()
        {
            return string.Format("{0}#{1}#{2}",this.Person.Name,this.person.Surname,this.Content);
        }
    }
}
