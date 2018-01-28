using System.Collections.Generic;


namespace TEC.Web.Models
{
    public class TestimonialModel
    {
        public string Name { get; set; }
        public string Quote { get; set; }
        public string ImageUrl { get; set; }
        public string Author { get; set; }

        public TestimonialModel(string name, string quote, string imageUrl)
        {
            Name = name;
            Quote = quote;
            ImageUrl = imageUrl;
        }
        
    }
}