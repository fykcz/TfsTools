using System;
using System.Configuration;

namespace FYK.Tfs.TfsCleaner
{
	static public class Utils
	{
		public static readonly string TFSUrl = ConfigurationManager.AppSettings["tfsurl"];
		public static readonly string Project = ConfigurationManager.AppSettings["project"];
		public static readonly string TargetIterationPath = ConfigurationManager.AppSettings["targetIteration"];
		public static bool DebugFlag = false;

		public static void DebugWrite(string msg)
		{
			if (DebugFlag)
				Console.Out.WriteLine(msg);
		}

		public static void DebugWrite(string format, params Object[] pars)
		{
			DebugWrite(string.Format(format, pars));
		}
	}
}
