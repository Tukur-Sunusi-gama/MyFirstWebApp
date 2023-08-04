using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApp.Controllers
{
    public class ComicBookGalleryController: Controller
    {
        public ContentResult Detail()
        {
            return new ContentResult()
            {
                Content = "hello world"
            };
        }
    }
}