﻿using System.Web;
using System.Web.Mvc;

namespace Travel_Pakistan_With_Us
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
