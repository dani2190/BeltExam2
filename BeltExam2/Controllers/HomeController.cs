using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BeltExam2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BeltExam2.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context { get; set; } 

        public HomeController(MyContext context)
        {
            _context = context;
        }
        

        [HttpGet ("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("CreateUser")]
    public IActionResult CreateUser(User user)
    {
        if(ModelState.IsValid)
        {
            // If a User exists with provided email
            if(_context.Users.Any(u => u.Email == user.Email))
            {
                ModelState.AddModelError("Email", "Email already in use!");
                return View("Index");
            }
            else
            {
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            user.Password = Hasher.HashPassword(user, user.Password);
            _context.Users.Add(user);
            _context.SaveChanges();
            Console.WriteLine("hello");
            HttpContext.Session.SetInt32("UserId", user.UserId);
            return RedirectToAction("Home");
            }
        }
        return View("Index");
    } 
    [HttpPost("Login")]
    public IActionResult Logged(LoginUser userSubmission)
    {
        if(ModelState.IsValid)
        {
            // If inital ModelState is valid, query for a user with provided email
            var userInDb = _context.Users.FirstOrDefault(u => u.Email == userSubmission.LogEmail);
            // If no user exists with provided email
            if(userInDb == null)
            {
                // Add an error to ModelState and return to View!
                ModelState.AddModelError("LogEmail", "Invalid Email/Password");
                return View("Index");
            }
            
            
            var hasher = new PasswordHasher<LoginUser>();
            
            // verify provided password against hash stored in db
            var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LogPassword);
            
            // result can be compared to 0 for failure
            if(result == 0)
            {
            ModelState.AddModelError("LogPassword", "Invalid Email/Password");
            return View("Index");
            }
            else
            {
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Home");
            }
        }
        return View("Index");
    }

    [HttpGet("Home")]
    public IActionResult Home()
    {
        User userInDb = _context.Users.FirstOrDefault( u => u.UserId ==  (int)HttpContext.Session.GetInt32("UserId"));
        List<DojoActivity> AllActivities = _context.DojoActivities.Include(a=>a.Creator)
                                                                .Include(a => a.ActivityList)
                                                                .ThenInclude(t => t.NavUser )
                                                                .OrderBy(d=>d.ActivityDate)
                                                                .ToList();
        if(userInDb == null)
        {
            return RedirectToAction("Logout");
        }
        ViewBag.User = userInDb;
        return View(AllActivities);
    }

    [HttpGet("join/{dojoActivityId}/{userId}")]
            public IActionResult Join(int dojoActivityId, int userId)
            {
                Invite join = new Invite();
                join.UserId = userId;
                join.DojoActivityId = dojoActivityId;
                _context.Invites.Add(join);
                _context.SaveChanges();
                return RedirectToAction("Home");  
        }

        [HttpGet("leave/{dojoActivityId}/{userId}")]
        public IActionResult Leave(int dojoActivityId, int userId)
        {
            Invite remove = _context.Invites.FirstOrDefault
            ( t => t.UserId == userId && t.DojoActivityId == dojoActivityId);
            _context.Invites.Remove(remove);
            _context.SaveChanges();
            return RedirectToAction("Home");
        }

            [HttpGet("cancel/{dojoActivityId}")]
        public IActionResult DeleteWedding(int dojoActivityId)
        {
            DojoActivity delete = _context.DojoActivities.FirstOrDefault( e=> e.DojoActivityId == dojoActivityId);
            _context.DojoActivities.Remove(delete);
            _context.SaveChanges();
            return RedirectToAction("Home");
        }

        [HttpPost("Create")]
    public IActionResult NewActivity(DojoActivity newDojoActivity)
    {
        if(ModelState.IsValid)
        {
            newDojoActivity.UserId = (int)HttpContext.Session.GetInt32("UserId");
            _context.DojoActivities.Add(newDojoActivity);
            _context.SaveChanges();
            return Redirect($"single/{newDojoActivity.DojoActivityId}");

        }
        else
        {
            return View("NewActivity");
        }
    }
    [HttpGet("NewActivity")]
    public IActionResult NewActivity()
    {
        return View();
    }

    [HttpGet("single/{dojoActivityId}")]
        public IActionResult SingleActivity(int dojoActivityId)
        {
            User userInDb = _context.Users.FirstOrDefault( u => u.UserId ==  (int)HttpContext.Session.GetInt32("UserId"));
            DojoActivity SingAct = _context.DojoActivities
                                        .Include(e=>e.ActivityList)
                                        .ThenInclude(e=>e.NavUser)
                                        .FirstOrDefault(w =>w.DojoActivityId == dojoActivityId);
            ViewBag.Maker = _context.DojoActivities.Include(u => u.Creator).FirstOrDefault(u=>u.DojoActivityId== dojoActivityId);
            ViewBag.User = userInDb;
            return View(SingAct);
        }

        [HttpGet("Logout")]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }




        
    }
}
