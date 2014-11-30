using Freelancer.Domain;
using Freelancer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return View();
        }

        [HttpPost]
        public ActionResult PostClaim(claim claim)
        {
            IClaimService a = new ClaimService();
            a.CreateClaim(claim);
            return RedirectToAction("View1");
        }



        public ActionResult TestAddFriend()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TestAddFriend(user user2)
        {
            int userconnected = 3;
             IClaimService b = new ClaimService();
             if (b.test(userconnected, user2.e_mail) == true)
              {
                  return RedirectToAction("View1");
          
            }
              else{

                  return RedirectToAction("ListClaims");
            }

          }


        public ActionResult ListRequest()
        {
            int userconnected = 2;
            IFriendlistService b = new FriendlistService();
            var t = b.listRequest(userconnected);
            return View(t);
        }
       
      
       
    
        
  
        
      
        

        public ActionResult ListFriends()
        {
            int userconnected = 2;
            IFriendlistService b = new FriendlistService();
            var t = b.listFriend(userconnected);

           
            return View(t);
        }

          [HttpGet]
        public ActionResult acc(int id)
        {
            int userconnected = 2;

            IFriendlistService frien = new FriendlistService();
            frien.acceptfriend(id, userconnected);
            return RedirectToAction("ListFriends");
        
        }
        [HttpGet]
          public ActionResult deny(int id)
          {
             int userconnected = 2;
              IFriendlistService friend = new FriendlistService();
              friend.denyfriend(id, userconnected);
              return RedirectToAction("ListRequest");

          }
        public ActionResult View2()
        {
          

            return View();
        }

        [HttpGet]
        public ActionResult remove(int id)
        {
            int userconnected = 2;
            IFriendlistService friend = new FriendlistService();
            friend.deletefriend(id,userconnected);
            return RedirectToAction("ListFriends");

        }
   




             
        

	}
}