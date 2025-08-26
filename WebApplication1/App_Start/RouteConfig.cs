using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "student/index",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "ContactUs",
                url: "student/contactUs",
                defaults: new { controller = "Home", action = "ContactUs", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "AboutUs",
                url: "student/aboutUs",
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Information",
                url: "student/Information",
                defaults: new { controller = "Home", action = "employeeInformation", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Add",
                url: "student/addEmployee",
                defaults: new { controller = "Home", action = "AddEmployee", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Added",
                url: "student/addedEmployeeDetails",
                defaults: new { controller = "Home", action = "PostUsingStronglyBinding", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Details",
                url: "student/Details/{id}",
                defaults: new { controller = "Home", action = "findDetails", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Update",
                url: "student/update/{id}",
                defaults: new { controller = "Home", action = "Update", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Updated",
                url: "student/UpdatedEmployeeDetails",
                defaults: new { controller = "Home", action = "UpdateUsingStronglyBinding", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Delete",
                url: "student/delete/{id}",
                defaults: new { controller = "Home", action = "Delete", id = UrlParameter.Optional }
            );
        }
    }
}
