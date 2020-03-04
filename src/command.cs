using System;
using static CommandRunner.VarManager.VarsList;
using static Extensions.Extend;
using System.Text.RegularExpressions;
using TokenizerEngine;
using Base;

namespace CommandRunner {
	public class CommandEngine {
		public static string RunCommand(string Command, string[] Args, string[] Flags) {
			switch(Command.ToLower()) {
				case "create":
					return CommandList.Create(Args,Flags);
				case "remove":
					return CommandList.Remove(Args,Flags);
				case "math":
					return CommandList.Math(Args,Flags);
				case "get":
					return CommandList.Get(Args,Flags);
				case "disp":
					return CommandList.Disp(Args,Flags);
				case "throw":
					return CommandList.Throw(Args,Flags);
				default:
					throw new UnknownCommandException(Command);
			}
		}
		public static string RunCommand(ParsedTokenList Tokens) {
			return RunCommand(Tokens.Name,Tokens.Args,Tokens.Flags);
		}
	}
	public class CommandList {
		public static string Create(string[] Args, string[] Flags) {
			if(Args.Length < 2) throw new TooLittleArgumentsException();
			Console.WriteLine(Args[0]);
			Console.WriteLine(Args[1]);
			Vars.Add(Args[0],Args[1]);
			return Args[1];
		}
		public static string Remove(string[] Args, string[] Flags) {
			if(Args.Length < 1) throw new TooLittleArgumentsException();
			Vars.Remove(Args[0]);
			return null;
		}
		public static string Math(string[] Args, string[] Flags) {
			if(Contains<string>(Flags,"add")) {
				return (Int32.Parse(Args[0]) + Int32.Parse(Args[1])).ToString();
			} else if(Contains<string>(Flags,"multi")) {
				return (Int32.Parse(Args[0]) * Int32.Parse(Args[1])).ToString();
			} else if(Contains<string>(Flags,"sub")) {
				return (Int32.Parse(Args[0]) - Int32.Parse(Args[1])).ToString();
			} else if(Contains<string>(Flags,"div")) {
				return (Int32.Parse(Args[0]) / Int32.Parse(Args[1])).ToString();
			} else if(Contains<string>(Flags,"rem")) {
				return (Int32.Parse(Args[0]) % Int32.Parse(Args[1])).ToString();
			}
			return null;
		}
		public static string Get(string[] Args, string[] Flags) {
			if(Args.Length < 1) throw new TooLittleArgumentsException();
			try {
				return Vars[Args[0]];
			} catch(Exception e) {
				return null;
			}
		}
		public static string Disp(string[] Args, string[] Flags) {
			if(Args.Length < 1) throw new TooLittleArgumentsException();
			Console.WriteLine(Regex.Replace(Args[0],"'",""));
			return Regex.Replace(Args[0],"[\"']","");
		}
		public static string ContainsCmd(string[] Args, string[] Flags) {
			if(Regex.IsMatch(Args[0],Args[1])) return "T"; else return "F";
		}
		public static string Throw(string[] Args, string[] Flags) {
			throw new Exception(Args[0]);
		}
	}
}