﻿using System.Web.Mvc;

namespace InstituteOfFineArts.Areas.Teacher
{
    public class TeacherAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Teacher";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Teacher_default",
                "Teacher/{controller}/{action}/{id}",
                new {controller = "Dashboard" ,action = "Index", id = UrlParameter.Optional },
                new [] { "InstituteOfFineArts.Areas.Teacher.Controllers"}
            );
        }
    }
}