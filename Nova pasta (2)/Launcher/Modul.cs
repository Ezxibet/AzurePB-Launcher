using System;

namespace PointBlank.Launcher
{
	public class Modul
	{
		public static string Name;

		public static string Ver;

		public static int Version;

		public static string WEB;

		static Modul()
		{
			Modul.Name = "Fireway Launcher";
			Modul.Ver = "fireway.version";
			Modul.Version = 1;
			Modul.WEB = "https://nothingz.com.br/api_kkorn/";
		}

		public Modul()
		{
		}
	}
}