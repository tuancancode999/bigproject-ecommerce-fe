using eShopSolution.Data.Entities;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Utilities.Data
{
    public class Ultils
    {
        public static AppUser getCurrentUser(HttpContext session)
        
        {
            if (!session.Session.TryGetValue("AppUser", out byte[] _))
            {
                return null;
            }
            JObject us = JObject.Parse(session.Session.GetString("AppUser"));
            AppUser user = new AppUser();
            user.Id = Guid.Parse(us.SelectToken("Id").ToString());
            user.UserName = us.SelectToken("UserName").ToString();
            user.PasswordHash = us.SelectToken("Password").ToString();
            user.DisplayName = us.SelectToken("DisplayName").ToString();
            return user;
        }
    }
}
