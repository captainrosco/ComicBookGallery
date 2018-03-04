using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers {
    public class ComicBooksController : Controller {

       

    // GET: ComicBooks
    public ActionResult Index() {
            return View();
        }

        public ActionResult Detail() {

            var comicBook = new ComicBook() {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artists[] {
                    new Artists() {Name ="Script", Role ="Dan Slott"},
                    new Artists() {Name ="Penciles", Role ="Humberto Ramos"},
                    new Artists() {Name ="Inks", Role ="Victor Olazaba"},
                    new Artists() {Name ="Colors", Role ="Edgar Delgago"},
                    new Artists() {Name ="Letters", Role ="Chris Eliopoulos"},
                }
            };

            return View(comicBook);
        }
    }
}
