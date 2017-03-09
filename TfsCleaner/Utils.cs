using System;
using System.IO;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace FYK.Tfs.TfsCleaner
{
	static public class Utils
	{
		public static readonly string TFSUrl = ConfigurationManager.AppSettings["tfsurl"];
		public static readonly string Project = ConfigurationManager.AppSettings["project"];
		public static readonly string TargetIterationPath = ConfigurationManager.AppSettings["targetIteration"];
		public static bool DebugFlag = false;
		public static StreamWriter LogFile = null;

		private static byte[] aditionalEntropy = { 7, 2, 0, 4, 1, 1 };

		public static void DebugWrite(string msg)
		{
			if (DebugFlag)
				Console.Out.WriteLine(msg);
			if (LogFile != null)
				LogFile.WriteLine(msg);
		}

		public static void DebugWrite(string format, params Object[] pars)
		{
			DebugWrite(string.Format(format, pars));
		}

		public static string Protect(string text)
		{
			return Convert.ToBase64String(ProtectedData.Protect(Encoding.Unicode.GetBytes(text),
					aditionalEntropy,
					DataProtectionScope.LocalMachine));
		}
		public static string UnProtect(string text)
		{
			var s = Convert.FromBase64String(text);
			return Encoding.Unicode.GetString(ProtectedData.Unprotect(s,
				aditionalEntropy,
				DataProtectionScope.LocalMachine));
		}
	}
}
