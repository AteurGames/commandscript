using System;

namespace Base {
	[InterperterException]
	public class TooLittleArgumentsException : Exception {
		public static string message = "Too little arguments given.";
		public TooLittleArgumentsException()
			: base(message)
		{}
	}
	[InterperterException]
	public class UnknownCommandException : Exception {
		public UnknownCommandException(string command) : base("Unknown command `"+command+"`.") {}
	}
	[InterperterException]
	public class UnknownVariableException : Exception {
		public UnknownVariableException(string var) : base("Unknown variable `"+var+"`.") {}
	}

	[AttributeUsage(System.AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
	public class InterperterExceptionAttribute : Attribute {
		public bool IsInterperter = true;
		public InterperterExceptionAttribute() {}
		/*public static bool IsInterperterException(Type type) {
			try {
				Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(Attribute.GetCustomAttribute(type, typeof(InterperterExceptionAttribute)));
			} catch(Exception) {
				return false;
			}
			return true;
		}*/
	}
}