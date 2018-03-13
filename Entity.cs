﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Entity
    {
        static int counter = 0;

        String DayOfWeek;
        String Time;
        String Subject;
        String Teacher;
        String Group;
        String Room;
        public int Id;

        public Entity(String DayOfWeek, String Time, String Subject, String Teacher, String Group, String Room)
        {
            Random rnd = new Random();
            this.Id = rnd.Next(14881488);
            this.DayOfWeek = DayOfWeek;
            this.Time = Time;
            this.Subject = Subject;
            this.Teacher = Teacher;
            this.Group = Group;
            this.Room = Room;
        }

        public override string ToString()
        {
            return this.Id + ", " + this.DayOfWeek + ", " + this.Time + ", '" + this.Room + "', '" + this.Subject + "', " + this.Group + ", " + this.Teacher;
        }
    }
}
