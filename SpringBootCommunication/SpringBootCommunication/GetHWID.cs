using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SpringBootCommunication
{
    class GetHWID
    {
        public string GetVolID()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();

            process.StandardInput.WriteLine("vol");
            process.StandardInput.Flush();

            process.StandardInput.Close();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            //Console.Write(output);


            return output.Substring(output.IndexOf("Volume Serial Number is ") + 24, 9);
        }
    }
}
