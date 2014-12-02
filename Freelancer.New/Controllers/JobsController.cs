using Freelancer.Domain;
using Freelancer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Freelancer.New.Controllers
{
    public class JobsController : Controller
    {
        IJobsServices jobb = null;
        ICategorysServices catserv = null;


        public JobsController()
        {
            catserv = new CategorysServices();
            jobb = new JobsServices();
        }

        //
        // GET: /Jobs/
        public ActionResult Index(string jobcategory, string title)
        {
            var jobs = jobb.GetJobs();
            if ((title == null || title == "") && string.IsNullOrEmpty(jobcategory))
            {


                foreach (job j in jobs)
                {
                    int i = j.categ_fk.Value;
                    category categ = catserv.getCategorybyid(i);
                    j.state = categ.name;
                }

                var categorys = catserv.GetCategorys();
                var CategoryLst = new List<string>();


                var CategoryQry = from d in jobs
                                  orderby d.state
                                  select d.state;

                CategoryLst.AddRange(CategoryQry.Distinct());
                ViewBag.jobcategorys = new SelectList(CategoryLst);

                return View(jobs);

            }
            else
            {

                if (!string.IsNullOrEmpty(jobcategory))
                {
                    foreach (job j in jobs)
                    {
                        int i = j.categ_fk.Value;
                        category categ = catserv.getCategorybyid(i);
                        j.state = categ.name;
                    }
                    // jobs = jobb.GetJobBycategory(jobcategory);
                    jobs = jobs.Where(x => x.state == jobcategory);
                    // Console.WriteLine("jjjj");


                }
                if (!String.IsNullOrEmpty(title))
                {
                    jobs = jobb.GetJobByNom(title);

                }
                return View(jobs.ToList());

            }
        }

        //
        // GET: /Jobs/Details/5
        public ActionResult Details(int id)
        {
            job o = jobb.getJobbyid(id);
            int i = o.categ_fk.Value;
            category categ = catserv.getCategorybyid(i);
            o.state = categ.name;
            return View(o);
        }

        //
        // GET: /Jobs/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Jobs/Create
        [HttpPost]
        public ActionResult Create(job j)
        {
            if (ModelState.IsValid)
            {
                jobb.AddService(j);
                return RedirectToAction("Index");
            }


            else
            {
                return View();
            }
        }

        //
        // GET: /Jobs/Edit/5
        public ActionResult Edit(int id)
        {
            job o = jobb.getJobbyid(id);
            return View(o);
        }

        //
        // POST: /Jobs/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, job o)
        {
            try
            {
                // TODO: Add update logic here
                jobb.UpdateJob(o);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Jobs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Jobs/Delete/5
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
    }
}
