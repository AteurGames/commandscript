// IMPORTANT!!!!!!!
// To boot up USE THE COMMAND: mono main.exe program.cmdsc
// OR IT WILL NOT WORK!!!!!!!!

using System;
using System.IO;
using TokenizerEngine;
using CommandRunner.VarManager;
using CommandRunner;
using Parser;

namespace Main {
	class MainClass {
  		public static void Main (string[] args) {
			if(args.Length < 1) return;
			string[] Lines = System.Text.RegularExpressions.Regex.Split(File.ReadAllText(args[0]),@"\n");
			int j = 1;
			foreach(string i in Lines) {
				try {
					if(i!="") LineParser.ParseLine(i);
				} catch (Exception e) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($"`{i}`\n{e.GetType().Name}: {e.Message}\nAt line {j.ToString()}");
					Console.ResetColor();
					return;
				}
				j++;
			}
  		}
	}
}