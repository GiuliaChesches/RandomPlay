using Microsoft.AspNet.Identity.Owin;
using RandomPlay.Mappers;
using RandomPlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RandomPlay.Controllers
{
    [Authorize]
    public class PlayController : Controller
    {
        private ApplicationDbContext _dbContext; 
        private ApplicationSignInManager _signInManager;
        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }
        public ApplicationDbContext DbContext
        {
            get
            {
                return _dbContext ?? HttpContext.GetOwinContext().Get<ApplicationDbContext>();
            }
            private set
            {
                _dbContext = value;
            }
        }

        public PlayController()
        {

        }

        // GET: Play
        public async Task<ActionResult> Index()
        {
            var currentMatch = DbContext.Matches.OrderBy(x => x.ExpireDate).FirstOrDefault(x => x.ExpireDate > DateTime.UtcNow);
            var userId = await SignInManager.GetVerifiedUserIdAsync();
            var userAlredyPlayed = currentMatch == null ? false :
                    DbContext.UserMatches.Any(x => x.MatchId == currentMatch.Id);

            return View(MatchMapper.MapMatchModelToViewModel(currentMatch, message: "You have already played this match"));
        }

        [HttpPost]
        public async Task<ActionResult> PlayMatch(int matchId)
        {
            try
            {
                var userId = await SignInManager.GetVerifiedUserIdAsync();
                var random = new Random();
                var number = random.Next(0, 100);

                DbContext.UserMatches.Add(new UserMatch()
                {
                    MatchId = matchId,
                    Score = number,
                    UserId = userId,
                    CreatedDate = DateTime.UtcNow
                });
                return Json(new { RandomNumber = random });
            }
            catch (Exception ex)
            {
                return Json(new { ErrorMessage = "An error occured" });
            }

        }

        // GET: Play/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Play/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Play/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Play/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Play/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Play/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Play/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
