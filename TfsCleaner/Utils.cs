using System.Configuration;

namespace FYK.Tfs.TfsCleaner
{
	static public class Utils
	{
		public static readonly string TFSUrl = ConfigurationManager.AppSettings["tfsurl"];
		public static readonly string Project = ConfigurationManager.AppSettings["project"];
		public static readonly string TargetIterationPath = ConfigurationManager.AppSettings["targetIteration"];
	}
}
