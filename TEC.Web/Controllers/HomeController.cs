using System.Web.Mvc;
using Umbraco.Web.Mvc;
using TEC.Web.Models;
using System.Collections.Generic;
using Umbraco.Web;
using Umbraco.Core.Models;
using System.Linq;
using Archetype.Models;

namespace TEC.Web.Controllers
{
    public class HomeController : SurfaceController
    {
        private string PartialViewPath(string name)
        {
            return $"~/Views/Partials/Content/{name}.cshtml";
        }

        public ActionResult RenderFeatured()
        {
            List<FeaturedItem> model = new List<FeaturedItem>();
            IPublishedContent homePage = CurrentPage.AncestorOrSelf("home");
            ArchetypeModel featuredItems = homePage.GetPropertyValue<ArchetypeModel>("featuredItems");

            foreach (ArchetypeFieldsetModel fieldset in featuredItems)
            {

                string imageUrl = fieldset.GetValue<IPublishedContent>("image").Url;

                string pageId = fieldset.GetValue<string>("page");
                IPublishedContent linkedToPage = Umbraco.TypedContent(pageId);
                string linkUrl = linkedToPage.Url;

                model.Add(new FeaturedItem(fieldset.GetValue<string>("name"), fieldset.GetValue<string>("category"),
                    imageUrl, linkUrl));
            }

            return PartialView(PartialViewPath("_Featured"), model);
        }


        public ActionResult RenderFeatures()
        {
            List<FeaturesList> model = new List<FeaturesList>();
            IPublishedContent homePage = CurrentPage.AncestorOrSelf("home");
            ArchetypeModel featuresList = homePage.GetPropertyValue<ArchetypeModel>("featuresList");

            foreach (ArchetypeFieldsetModel fieldset in featuresList)
            {
                string pageId = fieldset.GetValue<string>("link");
                IPublishedContent linkedToPage = Umbraco.TypedContent(pageId);
                string link = linkedToPage.Url;
                //string link = fieldset.GetValue<IPublishedContent>("link").Url;
                
                var intro = fieldset.GetValue<string>("intro");

                model.Add(new FeaturesList(fieldset.GetValue<string>("name"), intro, link
                    ));
            }

            return PartialView(PartialViewPath("_Features"), model);
        }

        public ActionResult RenderTestimonials()
        {
            return PartialView(PartialViewPath("_Testimonials"));
        }
    }
}