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
			foreach(string i in Lines) {
				LineParser.ParseLine(i);
			}
  		}
	}
}