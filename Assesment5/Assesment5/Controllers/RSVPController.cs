using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assessment5.Controllers
{
    public class RSVPController : Controller
    {
        // GET: RSVP
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult TakeInfo(RSVPInfo info)
        {
            ViewData["Name"] = info.FName + " " + info.LName;

            if (!info.Attend.Equals(false))
            {
                return View("bye");
            }
            else
            {

                return View("party");
            }

        }

        public ActionResult Bye()
        {
            return RedirectToAction("bye", "rsvp");
        }

        // GET: RSVP/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }


    }
}