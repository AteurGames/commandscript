using System;
using System.Text.RegularExpressions; 
using System.Collections.Generic; 
using System.Linq;
using Extensions;

namespace TokenizerEngine {
	public class Tokenizer {
		private const string FlagRegex = @"(?<=-|(--))[\w\d]+";
		private const string ArgsRegex = @"((?<!-|(--))[\w\d]+)|(<[ 	]*.+[ 	]*>)";
		public const string WhitespaceRegex = @"[ 	]+(?=([^<>]*[<>][^<>]*[<>])*[^<>]*$)(?=([^']*['][^']*['])*[^']*$)";

		public static ParsedTokenList TokenList(string[] Input) {
			return new ParsedTokenList {
				Name = Name(Input),
				Flags = Flags(Input),
				Args = Args(Input)
			};
		}

		private static string[] SplitArgs(string Input) {
			return Regex.Split(Input,WhitespaceRegex);
		}

		public static string[] Tokens(string Input) {
			return SplitArgs(Input);
		}

		public static string Name(string[] Input) {
			try {
				return Input[0];
			} catch(Exception e) {
				return "";
			}
		}
		public static string[] Flags(string[] Input) {
			List<string> j = new List<string>();
			foreach(string i in Input) {
				if(i==null) continue;
				if(Regex.IsMatch(i,FlagRegex)) {
					j.Add(i);
				}
			}
			return j.ToArray();
		}
		public static string[] Args(string[] Input) {
			List<string> j = new List<string>();
			foreach(string i in Input) {
				//if(i == j[0]) continue;
				
				if(i==null) continue;

				if(Regex.IsMatch(i,ArgsRegex) && !Regex.IsMatch(i,FlagRegex)) {
					j.Add(i);
				}
			}
			j.RemoveAt(0);
			return j.ToArray();
		}
	}
	public class ParsedTokenList {
		public string Name {get; set;}
		public string[] Flags {get; set;}
		public string[] Args {get; set;}

		public ParsedTokenList(string Name,string[] Flags,string[] Args) {
			this.Name = Name;
			this.Flags = Flags;
			this.Args = Args;
		}
		public ParsedTokenList() {}
	}
}