using System;
using System.Diagnostics;
using System.IO;

namespace SpringBootCommunication
{
    class Program
    {
        
        static void Main(string[] args)
        {
            GetHWID hwid = new GetHWID();
            string volID = hwid.GetVolID();
            Console.WriteLine(volID);
            SendRequest request = new SendRequest();
            request.sendHttpRequest(volID);
        }
    }

}
