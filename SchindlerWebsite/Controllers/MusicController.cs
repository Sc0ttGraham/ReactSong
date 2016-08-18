using SchindlerWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchindlerWebsite.Controllers
{
    public class MusicController : Controller
    {
        public ActionResult React()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateGraph(string search)
        {
            SongQuery query = new SongQuery(search);
            return View(query);
        }
    }
}