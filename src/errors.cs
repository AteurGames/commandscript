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
	public class CustomException {
		public string msg = "Custom Exception Thrown!";
		public CustomException(string Message) { msg = Message; }
	}
}