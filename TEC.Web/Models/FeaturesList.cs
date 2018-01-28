using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEC.Web.Models
{
    public class FeaturesList
    { 
        public string Name { get; set; }

        public string Intro { get; set; }

        public string Link { get; set; }

        public FeaturesList(string name, string intro, string link)
        {
            Name = name;
            Intro = intro;
            Link = link;
        }
    }
}