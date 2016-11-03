using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_3.Models;

namespace Task_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string str = Task_3.Models.Connect.getJSON("https://jsonplaceholder.typicode.com/albums", "");
            var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Task_3.Models.Album>>(str);
            return View(list);
        }

        public ActionResult Photos()
        {
            return View(new List<Photo>());
        }

        public ActionResult GetPhotos(string id)
        {
            string str = Task_3.Models.Connect.getJSON("https://jsonplaceholder.typicode.com/photos", "?albumId=" + id);
            var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Task_3.Models.Photo>>(str);
            return View("Photos", list);
        }
    }
}
