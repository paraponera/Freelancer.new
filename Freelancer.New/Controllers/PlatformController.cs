using Freelancer.Domain;
using Freelancer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Windows.Forms;


namespace Freelancer.New.Controllers
{
    public class PlatformController : Controller
    {
        //
        // GET: /Platform/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult View1()
        {
            return View();
        }

       

      





        public ActionResult PostClaim()
        {
            if (Session["name"] == null)
            {
                return RedirectToAction("../ManageUser/Authentication");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult PostClaim(claim claim)
        {
            if (ModelState.IsValid)
            {
                IClaimService a = new ClaimService();
                claim.email = (string)Session["email"];
                a.CreateClaim(claim);
                return RedirectToAction("View1");
            }
            else { return View(); }
        }



        public ActionResult TestAddFriend()
        {
            if (Session["name"] == null)
            {
                return RedirectToAction("../ManageUser/Authentication");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult TestAddFriend(user user2)
        {

            
          
           
           
        
            if (Session["name"] == null)
            {
                return RedirectToAction("../ManageUser/Authentication");
            }
            else
            {
                int userconnected = (int)Session["id"];
                IClaimService b = new ClaimService();
                if (b.test(userconnected, user2.e_mail) == true)
                {
                    return RedirectToAction("ListFriends");

                }
                else
                {
                    MessageBox.Show("The email address does not exist", "wrong email",
                   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return RedirectToAction("TestAddFriend");
                }

            }
        }


        public ActionResult ListRequest()
        {
            if (Session["name"] == null)
            {
                return RedirectToAction("../ManageUser/Authentication");
            }
            else
            {
                int userconnected = (int)Session["id"];
                IFriendlistService b = new FriendlistService();
                var t = b.listRequest(userconnected);
                return View(t);
            }
        }










        public ActionResult ListFriends()
        {
            if (Session["name"] == null)
            {
                return RedirectToAction("../ManageUser/Authentication");
            }
            else
            {
                int userconnected = (int)Session["id"];
                IFriendlistService b = new FriendlistService();
                var t = b.listFriend(userconnected);


                return View(t);
            }
        }

          [HttpGet]
        public ActionResult acc(int id)
        {
            int userconnected = (int)Session["id"];

            IFriendlistService frien = new FriendlistService();
            frien.acceptfriend(id, userconnected);
            return RedirectToAction("ListFriends");
        
        }
        [HttpGet]
          public ActionResult deny(int id)
          {
              int userconnected = (int)Session["id"];
              IFriendlistService friend = new FriendlistService();
              friend.denyfriend(id, userconnected);
              return RedirectToAction("ListRequest");

          }
        public ActionResult View2()
        {
          

            return View();
        }
        public ActionResult popup()
        {
            return View();
        }


        [HttpGet]
        public ActionResult remove(int id)
        {
            int userconnected = (int)Session["id"];
            IFriendlistService friend = new FriendlistService();
            friend.deletefriend(id,userconnected);
            return RedirectToAction("ListFriends");

        }
        public ActionResult Signout()
        {
            Session["name"] = null;
            Session["id"] = null;
            return RedirectToAction("../ManageUser/Authentication");
        }
        
       




             
        

	}
}