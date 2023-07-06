using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTK_Akademi.Models
{
    public static class Repository
    {
        private static List<CandidateModel> applications;

        static Repository()
        {
            applications = new List<CandidateModel>();
        }

        public static IEnumerable<CandidateModel> Applications => applications;

        public static void Add(CandidateModel model)
        {
            applications.Add(model);
        }
    }
}