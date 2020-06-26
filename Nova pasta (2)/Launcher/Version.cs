using System;
using System.Reflection;

namespace PointBlank.Launcher
{
	public class Version
	{
		public static string Ver;

		static Version()
		{
			PointBlank.Launcher.Version.Ver = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		}

		public Version()
		{
		}

		public static string getVersion()
		{
			return PointBlank.Launcher.Version.Ver;
		}
	}
}