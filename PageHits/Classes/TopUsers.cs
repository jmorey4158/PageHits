using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PageHits.Classes
{
    public static class UserMetrics
    {
        public static List<User> TopUsers(this List<User> ulist, List<Hit> hits)
        {
            var topUsers = new List<User>();

            //LINQ query

            return topUsers;

        }


        public static Dictionary<string,string> RecentVisit(this List<User> ulist, List<Hit> hits)
        {
            var recentVisits = new Dictionary<string, string>();
            var yesterday = DateTime.Now + TimeSpan.FromDays(-1);


            var recentPages =
                from user in ulist
                join page in hits
                on user.Id equals page.UserId
                where (page.Date == yesterday)
                select new {Person =  user.FirstName + " " + user.LastName, Page = page.Url };

            foreach (var p in recentPages)
            {
                recentVisits.Add(p.Person, p.Page);
            }

            return recentVisits;

        }

    }
}