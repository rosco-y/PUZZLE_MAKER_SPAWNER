using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
namespace PuzzleMakerSpawner
{
    internal class Program
    {
        static string PATH = @"C:\Users\rossy\SUDO_WORKSPACES\SUDOGENv2\SUDOGEN\SUDOKUBED9X9\SUDOKUBED9X9\bin\x64\Release\netcoreapp3.1\";
        static string EXE = "SUDOKUBED9X9";
        static int NUMPROCESSES = 4;
        static void Main(string[] args)
        {
            Process[] processes = new Process[NUMPROCESSES];
            for (int i = 0; i < NUMPROCESSES; i++)
            {

                processes[i] = new Process();
                if (i == 0)
                {
                    processes[i].StartInfo.FileName = $"{PATH}{EXE}.exe";
                    processes[i].StartInfo.Arguments = "/i";
                }
                else
                {
                    processes[i].StartInfo.FileName = $"{PATH}{EXE}{i}.exe";
                    processes[i].StartInfo.UseShellExecute = true;
                    processes[i].StartInfo.RedirectStandardOutput = false;
                }
                processes[i].Start();
                Thread.Sleep(2000); // 2 seconds.
            }
        }
    }
}
