using System;
using System.Diagnostics;

namespace CmdController
{
    class Program
    {
        static void Main(string[] args)
        {
            Process p = new Process();
            String str = null;

            p.StartInfo.FileName = "cmd.exe";

            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            //p.StartInfo.CreateNoWindow = true; //不跳出cmd視窗

            p.Start();
            p.StandardInput.WriteLine("ipconfig");
            p.StandardInput.WriteLine("exit");

            str = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            p.Close();


            Console.WriteLine(str);
            Console.ReadKey();

            //來源 https://dotblogs.com.tw/jj_lifenote/2018/04/24/200342
        }
    }
}
