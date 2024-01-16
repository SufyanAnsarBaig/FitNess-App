﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Specialized;
using System.Web;
namespace FitnessCare.Helpers
{
    public class ExtensionMethod
{
    public static NameValueCollection QueryString(this NavigationManager navigationManager)
    {
        return HttpUtility.ParseQueryString(new Uri(navigationManager.Uri).Query);
    }

    public static string QueryString(this NavigationManager navigationManager, string key)
    {
        return navigationManager.QueryString()[key];
    }
}
}

