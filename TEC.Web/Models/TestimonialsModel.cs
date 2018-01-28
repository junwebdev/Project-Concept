using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEC.Web.Models
{
    public class TestimonialsModel
    {
        public string LightTitle { get; set; }
        public string Title { get; set; }
        public string Introduction { get; set; }
        public List<TestimonialModel> Testimonials { get; set; }
        public bool HasTestimonials { get { return Testimonials != null && Testimonials.Count > 0; } }

        public TestimonialsModel(string lightTitle, string title, string introduction, List<TestimonialModel> testimonials)
        {
            LightTitle = lightTitle;
            Title = title;
            Introduction = introduction;
            Testimonials = testimonials;
        }
    }
}