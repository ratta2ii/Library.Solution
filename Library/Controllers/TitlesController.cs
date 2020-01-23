using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Library.Controllers
{
    public class TitlesController : Controller
    {
        private readonly LibraryContext _db;

        public TitlesController(LibraryContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Title> model = _db.Titles.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Title title)
        {
            _db.Titles.Add(title);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}


// TitleId shares a TitalId on books