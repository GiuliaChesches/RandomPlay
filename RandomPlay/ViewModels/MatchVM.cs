using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandomPlay.ViewModels
{
    public class MatchVM
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string Message { get; set; }
    }
}