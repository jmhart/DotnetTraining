using Markdig;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Web.Helpers
{
    public static class HtmlHelpers
    {
        public static HtmlString MarkdownToHtml(this IHtmlHelper htmlHelper, string markdown)
        {
            var html = Markdown.ToHtml(markdown, new MarkdownPipelineBuilder().UseAdvancedExtensions().Build());

            return new HtmlString(html);
        }
    }
}