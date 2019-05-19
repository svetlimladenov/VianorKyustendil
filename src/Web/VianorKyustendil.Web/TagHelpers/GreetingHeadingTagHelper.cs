using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace VianorKyustendil.Web.TagHelpers
{
    [HtmlTargetElement("abbr")]
    public class GreetingHeadingTagHelper : TagHelper
    {
        //asp-name
        public string AspName { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetContent($"Hello, {this.AspName}");
        }
    }
}
