﻿using CXMLDecompilerRCO.Ini;

namespace CXMLDecompilerRCO
{
	internal class IniConfig
	{
		public static IniFile Newini;

		public static string IP;
		public static string port;

		static IniConfig()
		{
			IniConfig.Newini = new IniFile("ip");
			IniConfig.IP = IniConfig.Newini.Read("PS4 IP", "IP");
			IniConfig.port = IniConfig.Newini.Read("PS4 port", "port");
		}
	}
}
