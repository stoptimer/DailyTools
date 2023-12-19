using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTools.Tools
{
    public class MarkdownService
    {
        public string ParseMarkdown(string markdownText)
        {
            return Markdig.Markdown.ToHtml(markdownText);
        }
    }
}
