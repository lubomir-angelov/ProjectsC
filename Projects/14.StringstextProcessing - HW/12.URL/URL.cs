using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements. For example from the URL 
//http://www.devbg.org/forum/index.php the following information should be extracted:
//      [protocol] = "http"
//		[server] = "www.devbg.org"
//		[resource] = "/forum/index.php"

namespace _12.URL
{
    class URL
    {
        static void Main(string[] args)
        {
            string url = @"http://www.mysite.com/archive/2010.com";

            string protocol = null;
            string server = null;
            string resource = null;

            protocol = url.Substring(0, url.IndexOf(':'));

            int index = url.IndexOf('/', protocol.Length + 3);

            server = url.Substring(url.IndexOf('w'), url.Length - (protocol.Length + index) + 1);

            resource = url.Substring(index, url.Length - (server.Length + protocol.Length + 3));

            Console.WriteLine("[protocol] = {0}\n[sevrver] = {1}\n[resource] = {2}\n", protocol, server, resource);


            //Note it's 3:30AM don't judge my lack of logic and unstraitghtforward calculations
        }
    }
}
