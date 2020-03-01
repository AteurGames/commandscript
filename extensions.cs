using System;
using System.Collections.Generic;

namespace Extensions {
	static class Extend {
		public static bool Contains<T>(T[] Arr, T Match) {
			return Array.Exists(Arr, element => element.Equals(Match));
		}
		public static string[] ToStringArray(this char[] Chars) {
			List<string> Output = new List<string>();

			foreach(char i in Chars) {
				Output.Add(i.ToString());
			}

			return Output.ToArray();
		}
	}
}