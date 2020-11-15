using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RandomPlay.Models
{
    public class UserMatch
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int MatchId { get; set; }
        public int Score { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("MatchId")]
        public virtual Match Match { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}