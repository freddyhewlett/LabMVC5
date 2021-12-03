using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class LogModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }
        public string Operation { get; set; }


        protected LogModel()
        {         
        }

        public LogModel(string user, string op)
        {
            User = user;
            Operation = op;
            Date = DateTime.Now;
        }

        public LogModel(string user, string op, DateTime dt) : this (user, op)
        {
            Date = dt;
        }

        public override string ToString()
        {
            return "Executed action: \nUser: " + User + "\nAction: " + Operation + "\nDate: " + Date;
        }
    }


}