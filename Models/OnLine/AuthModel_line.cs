using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
namespace Apptest.Models.OnLine
{
    public enum httpveb
    {
        GET,
        POST,
        PUT,
        DELETE,
    }
    class AuthModel_line
    {
        public void http()
        {
            HttpClient client = new HttpClient();
        }
    }
}
