using Freelancer.Domain;
using Freelancer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Freelancer.New.Controllers
{
    public class ManageUserController : Controller
    {
        IUsersServices userr = null;



        public ManageUserController()
        {
            userr = new UsersServices();
        }
        //
        // GET: /ManageUser/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /ManageUser/Details/5
        public ActionResult Details(int id)
        {

            user o = userr.getUserbyid(id);
            return View(o);
        }

        //
        // GET: /ManageUser/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ManageUser/Create
        [HttpPost]
        public ActionResult Create(user u)
        {
            if (ModelState.IsValid)
            {
                userr.AddService(u);
                return RedirectToAction("Authentication");
            }


            else
            {
                return View();
            }
        }

        //
        // GET: /ManageUser/Authentication
        public ActionResult Authentication()
        {
            return View();
        }

        //
        // POST: /ManageUser/Create
        [HttpPost]
        public ActionResult Authentication(string email, string password)
        {
            int ch = userr.Authentification(email, password);
            user user = new user();
            if (ch == 0)
            {

               
               
                int id = userr.FindByEmail(email);
                user=userr.getUserbyid(id);
                Session["name"] = user.first_name;
                Session["id"] = id;
                return RedirectToAction("Details/" + id);
            }


            else
            {
                return View();
            }
        }


        //
        // GET: /ManageUser/Edit/5
        public ActionResult Edit(int id)
        {

            user o = userr.getUserbyid(id);
            return View(o);
        }

        //
        // POST: /ManageUser/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, user o)
        {

            try
            {

                // TODO: Add update logic here
                userr.UpdateUser(o);
                return RedirectToAction("Details/" + id);
            }
            catch
            {

                return View();
            }
        }

        //
        // GET: /ManageUser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ManageUser/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult beforedet()
        {

            return RedirectToAction("Details/" + Session["id"]);

        }
    }
}
