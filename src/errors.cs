using System;

namespace Base {
	public class TooLittleArgumentsException : Exception {
		public static string message = "Too little arguments given.";
		public TooLittleArgumentsException()
			: base(message)
		{}
	}
	public class UnknownCommandException : Exception {
		public UnknownCommandException(string command) : base("Unknown command `"+command+"`.") {}
	}
	public class UnknownVariableException : Exception {
		public UnknownVariableException(string var) : base("Unknown variable `"+var+"`.") {}
	}
}