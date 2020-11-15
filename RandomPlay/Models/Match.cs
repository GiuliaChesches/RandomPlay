using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandomPlay.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}