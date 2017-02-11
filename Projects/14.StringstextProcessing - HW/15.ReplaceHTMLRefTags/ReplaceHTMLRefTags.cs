using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags 
//[URL=…]…/URL]. Sample HTML fragment:
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course.
//   Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

//<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. 
//   Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

namespace _15.ReplaceHTMLRefTags
{
    class ReplaceHTMLRefTags
    {
        static void Main(string[] args)
        {
            string htmlFragment = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course." +
                                  @"Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

            htmlFragment = htmlFragment.Replace(@"<a href=""", "[URL=");
            htmlFragment = htmlFragment.Replace(@""">", "]");
            htmlFragment = htmlFragment.Replace("</a>", "[/URL]");

            Console.WriteLine(htmlFragment);

            string correctString = @"<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course." +
                                   @"Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>";
            Console.WriteLine(correctString);
        }
    }
}
