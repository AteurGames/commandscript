using System;
using System.Text.RegularExpressions; 
using TokenizerEngine;
using CommandRunner;
using static CommandRunner.CommandEngine;

namespace Parser {
	class LineParser {
		private const string SubCmdRegex = @"<\s*(.)*\s*>";

		public static string ParseLine(string Line) {
			string[] Tokens = Tokenizer.Tokens(Line);

			//Console.WriteLine(Tokens[1]);

			//Console.WriteLine(Line == null);

			for(int i = 0; i<Tokens.Length; i++) {
				Tokens[i] = ParseSubCmd(Tokens[i]);
			}

			ParsedTokenList TokenList = Tokenizer.TokenList(Tokens);

			return RunCommand(TokenList);
		}
		public static string ParseSubCmd(string PossibleSubCmd) {
			Console.WriteLine("P: "+PossibleSubCmd);
			if (PossibleSubCmd == null) return "";
			if(Regex.IsMatch(PossibleSubCmd,SubCmdRegex)) {
				return ParseLine(Regex.Replace(PossibleSubCmd,SubCmdRegex,"$1"));
			} else {
				return PossibleSubCmd;
			}
		}
	}
}