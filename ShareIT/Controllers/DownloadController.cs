using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShareIT.Data;
using ShareIT.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;


namespace ShareIT.Controllers
{
    public class DownloadController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private IHostingEnvironment Environment;
        public DownloadController(UserManager<IdentityUser> _userManager, IHostingEnvironment _environment, ApplicationDbContext context, SignInManager<IdentityUser> _signInManager)
        {
            _context = context;
            userManager = _userManager;
            Environment = _environment;
            signInManager = _signInManager;

        }
        // GET: Download
        public ActionResult Index(string id)
        {
            
            if (id == null || id == "")
            {
                return View("NoFile");
            }
            else
            {
                
                UploadedFile fileDetails = _context.UploadedFile.FirstOrDefault(m => m.id == id);
                if (fileDetails==null)
                {
                    return View("NoFile");
                }
                else
                return View(fileDetails);
                //return RedirectToAction("CreateLink", new { filename = id });
            }
            
        }

        // GET: Download/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Download/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Download/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Download/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Download/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Download/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Download/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".mp3", "audio/mpeg"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".zip", "application/zip"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".mp4", "video/mp4"},
                {".rar", "application/octet-stream"}
                ,
                
            };
        }
        public async Task<IActionResult> CreateLink(string id)
        {
            string directory = "";
            if (id == null)
                return View("NoFile");
            string file = "";
            UploadedFile downloadable = await _context.UploadedFile.FirstOrDefaultAsync(m => m.id == id);

            if (downloadable.id == null)
            {
                return View("NoFile");
            }
            else
            {
                if (downloadable.userName == "NotRegistered")
                {
                    directory = "wwwroot\\Uploads\\NotRegistered";
                    file = id + downloadable.extension;
                }
                else
                {
                    directory = "wwwroot\\Uploads\\" + downloadable.userName;
                    file = id + downloadable.extension;
                }

            }
            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           directory, id + downloadable.extension);


            var memory = new MemoryStream();
            try
            {
                using (var stream = new FileStream(path, FileMode.Open))
                {
                    await stream.CopyToAsync(memory);
                }
                memory.Position = 0;
                //return File(memory, downloadable.extension, downloadable.fileName);
                return File(memory, GetContentType(path), downloadable.fileName+downloadable.extension); 
            }
            catch
            {
                return View("NoFile");
            }
        }
    }
}