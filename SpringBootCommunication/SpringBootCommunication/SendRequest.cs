using System;
using System.Net;

namespace SpringBootCommunication
{
    class SendRequest
    {
        public void sendHttpRequest(string HWID)
        {
            Console.WriteLine(new WebClient().DownloadString("http://localhost:8080/check/?name=" + HWID));
        }
    }
}
