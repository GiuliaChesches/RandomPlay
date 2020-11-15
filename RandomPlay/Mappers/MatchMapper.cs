using RandomPlay.Models;
using RandomPlay.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandomPlay.Mappers
{
    public class MatchMapper
    {
        public static MatchVM MapMatchModelToViewModel(Match match, string message)
        {
            if (match == null)
                return new MatchVM();
            else
                return new MatchVM()
                {
                    Id = match.Id,
                    Name = match.Name,
                    ExpireDate = match.ExpireDate, 
                    Message = message
                };
        }
    }
}