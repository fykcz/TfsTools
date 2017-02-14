using System;
using FYK.FykUtils;

namespace FYK.Tfs.TfsCleaner
{
	class Program
	{
		static void Main(string[] args)
		{
			var arg = new Arguments(args);

			if (arg["debug"] != null)
				Utils.DebugFlag = true;

			OperationsSection os = OperationsSection.GetConfig();
			var tfso = new TfsOperations(os);

			tfso.Login();
			tfso.RunOperations();

			if (Utils.DebugFlag)
			{
				Console.WriteLine();
				Console.Write("Press Enter ...");
				Console.In.ReadLine();
			}
		}
	}
}
