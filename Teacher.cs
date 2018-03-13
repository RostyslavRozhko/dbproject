﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Teacher
    {
        private static int Counter = 0;

        public int Id;
        String Position;
        String Initials;
        String Lastname;
        public String Name;

        public Teacher(String Name)
        {
            Random rnd = new Random();
            this.Id = rnd.Next(14881488);
            this.Name = Name;
            string[] output = Name.Split(' ');
            this.Position = output[0];
            this.Initials = output[1];
            this.Lastname = output[2];

        }

        override public String ToString()
        {
            return "('" + this.Id + "', '" + this.Lastname + "', '" + this.Initials + "', '" + this.Position + "')";
        }
    }
}
