using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.App_Start
{
    public class GameController : Controller
    {
        // GET: Game
        //public string Name(string name)
        //{
        //    return "Welcome to " + name;
        //}
        public string Name(string first = "", string last = "")
        {
            if (!string.IsNullOrEmpty(first))
            {
                if (last != "")
                {
                    return "Your first name is " + first + " and last name is " + last;
                }
                else
                {
                    return "Your first name is " + last;
                }
            }
            else
            {
                if (last != null)
                {
                    return "Your last name is " + last;
                }
                else
                {
                    return "";
                }
            }
        }
    }

}