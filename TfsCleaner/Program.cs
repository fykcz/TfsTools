using System;
using FYK.FykUtils;
using System.Reflection;
using System.IO;

namespace FYK.Tfs.TfsCleaner
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Out.WriteLine(string.Format("{0} running ...", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName));
			var arg = new Arguments(args);

			if (arg["crypt"] != null)
			{
				var p = arg["crypt"];
				Console.Out.WriteLine(Utils.Protect(p));
				return;
			}

			if (arg["decrypt"] != null)
			{
				var p = arg["decrypt"].ToString();
				Console.Out.WriteLine(Utils.UnProtect(p));
				return;
			}
			if (arg["debug"] != null)
				Utils.DebugFlag = true;

			if (arg["log"] != null)
			{
				var fName = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)),
											string.Format("{0}_{1}", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName,
																		DateTime.Now.ToString("yyyyMMddHHmmss"))) + ".txt";
				Utils.DebugWrite(string.Format("Log file: {0}", fName));
				Utils.LogFile = new StreamWriter(fName);
			}
			OperationsSection os = OperationsSection.GetConfig();
			var tfso = new TfsOperations(os);

			tfso.Login();
			tfso.RunOperations();

			if (arg["pressenter"] != null)
			{
				Console.WriteLine();
				Console.Write("Press Enter ...");
				Console.In.ReadLine();
			}

			if (Utils.LogFile != null)
			{
				Utils.LogFile.Flush();
				Utils.LogFile.Close();
			}
		}
	}
}
