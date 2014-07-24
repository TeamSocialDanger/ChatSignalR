using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatSignalR.Models
{
    public class AddGroup
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}