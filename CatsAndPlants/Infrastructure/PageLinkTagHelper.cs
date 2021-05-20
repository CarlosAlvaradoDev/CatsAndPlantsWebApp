using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using CatsAndPlants.Models;
using System.Collections.Generic;

namespace CatsAndPlants.Infrastructure
{
   [HtmlTargetElement("div", Attributes = "page-model")] // <div page-model="__" page-action="". . . >
   public class PageLinkTagHelper
      : TagHelper
   {
      //   F i e l d s   &   P r o p e r t i e s

      private IUrlHelperFactory _urlHelperFactory;

      public string      PageAction        { get; set; }

      public string      PageClass         { get; set; }

      public bool        PageClassEnabled  { get; set; } = false;

      public string      PageClassNormal   { get; set; }

      public string      PageClassSelected { get; set; }

      public PagingInfo  PageModel         { get; set; }

      // <div ... page-url-category="Soccer" page-url-page="1">
      [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
      public Dictionary<string, object> PageUrlValues { get; set; }
         = new Dictionary<string, object>();

      [ViewContext]
      [HtmlAttributeNotBound]
      public ViewContext ViewContext       { get; set; }


      //   C o n s t r u c t o r s

      public PageLinkTagHelper(IUrlHelperFactory helperFactory)
      {
         _urlHelperFactory = helperFactory;
      }

      //   M e t h o d s

      public override void Process(TagHelperContext context, TagHelperOutput output)
      {
         IUrlHelper urlHelper = _urlHelperFactory.GetUrlHelper(ViewContext);
         TagBuilder result = new TagBuilder("div");
         for (int i = 1; i <= PageModel.TotalPages(); i++)
         {
            TagBuilder anchorTag = new TagBuilder("a");

            PageUrlValues["productPage"] = i;
            anchorTag.Attributes["href"] = urlHelper.Action(PageAction, PageUrlValues);

            if (PageClassEnabled)
            {
               anchorTag.AddCssClass(PageClass);
               if (i == PageModel.CurrentPage)
               {
                  anchorTag.AddCssClass(PageClassSelected);
               }
               else
               {
                  anchorTag.AddCssClass(PageClassNormal);
               }
            }

            anchorTag.InnerHtml.Append($"Page {i}");
            result.InnerHtml.AppendHtml(anchorTag);
         }
         output.Content.AppendHtml(result.InnerHtml);
      } // end Process( )
   }
}
