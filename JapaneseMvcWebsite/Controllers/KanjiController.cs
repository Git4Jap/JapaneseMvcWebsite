using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JapaneseMvcWebsite.JapaneseService;

namespace JapaneseMvcWebsite.Controllers
{
    public class KanjiController : Controller
    {
        // GET: /Kanji/
        public ActionResult AddKanji()
        {
            return View();
        }

        // GET: /Kanji/
        [HttpPost]
        public ActionResult AddKanji(Kanji newKanji)
        {
            if (ModelState.IsValid)
            {
                var serviceClient = new JapaneseServiceClient();
                serviceClient.InsertKanji(newKanji);
            }

            return View(newKanji);
        }
    }
}