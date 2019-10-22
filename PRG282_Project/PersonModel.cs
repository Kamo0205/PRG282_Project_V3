﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG282_Project
{
    class PersonModel
    {
        DataHandler dh;
        List<Person> people;

        public PersonModel()
        {
            dh = new DataHandler();
            this.people = dh.ReadPeople();
        }

        public List<Person> People { get => people;  }

        public void AddUser()
        {
            
        }

        public bool IsAboveOfficer(string username)
        {
            bool isOfficer = false;
            foreach (Person person in People)
            {
                if (username.ToLower() == person.Username.ToLower())
                {
                    foreach (string[] rank in dh.ReadRanks())
                    {
                        if (rank[1].ToLower() == person.Rank.ToLower())
                        {
                            if (int.Parse(rank[0]) > 4)
                            {
                                isOfficer = true;
                            }
                        }
                    }
                }
            }
            return isOfficer;
        }
    }
}
