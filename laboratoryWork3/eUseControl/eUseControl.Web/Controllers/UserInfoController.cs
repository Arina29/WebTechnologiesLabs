using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.Web.Data;
using eUseControl.Web.Models;
using eUseControl.Web.ViewModels;

namespace eUseControl.Web.Controllers
{
    public class UserInfoController : Controller
    {

        private UserContext _context;

        public UserInfoController()
        {
            _context = new UserContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Designers(string sortOrder, string searchString)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_asc" : "";
            var users = from u in _context.Users select u;
           
            if(sortOrder == "name_asc")
            {
                users = users.OrderBy(u => u.Name);
                return View(users.Include(u => u.StyleTypes).ToList());
            }

            if(!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(u => u.Name.Contains(searchString));
                return View(users.Include(u => u.StyleTypes).ToList());
            }

            return View(_context.Users.Include(u => u.StyleTypes).ToList());
        }

        public ActionResult CustomerForm()
        {
            var designStyle = _context.designStyles.ToList();
            var newDesigner = new designerViewModel
            {
                User = new userInfo(),
                StyleTypes = designStyle
            };
            return View("CustomerForm", newDesigner);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(userInfo user)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new designerViewModel()
                {
                    User = user,
                    StyleTypes = _context.designStyles.ToList()
                };
                return View("CustomerForm", viewModel);
            }
            if (user.Id == 0)
                _context.Users.Add(user);
            else
            {
                var userInDb = _context.Users.SingleOrDefault(u => u.Id == user.Id);
                userInDb.Name = user.Name;
                userInDb.email = user.email;
                userInDb.phoneNumber = user.phoneNumber;
                userInDb.StyleTypesId = user.StyleTypesId;
                userInDb.PicturePath = user.PicturePath;
            }
            _context.SaveChanges();
            return RedirectToAction("Designers", "UserInfo");
        }

        public ActionResult Edit(int id)
        {
            var user = _context.Users.SingleOrDefault(c => c.Id == id);
            if (user == null)
                return HttpNotFound();

            var viewModel = new designerViewModel
            {
                User = user,
                StyleTypes = _context.designStyles.ToList()
            };
            return View("CustomerForm", viewModel);
        }

        public ActionResult Delete(int id)
        {
            var user = _context.Users.Single(c => c.Id == id);
            if (user == null)
                return HttpNotFound();

            _context.Users.Remove(user);
            _context.SaveChanges();
            return RedirectToAction("Designers", "UserInfo");

        }

        public ActionResult AddDesigner()
        {
            return RedirectToAction("CustomerForm", "UserInfo");
        }

        public ActionResult Details(int id)
        {

            var user = _context.Users.Include(u => u.StyleTypes).SingleOrDefault(u => u.Id == id);
            if (user == null)
                return HttpNotFound();
            return View(user);
        }

        public ActionResult SortByName()
        {
            var users = from u in _context.Users select u;
            users = users.OrderBy(u => u.Name);
            return View(users.Include(u => u.StyleTypes).ToList());
        }

        public ActionResult Upload()
        {
            return View();
        }

    }
}