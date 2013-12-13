using System;
using System.Collections;

namespace sharpssh.executable
{
	/// <summary>
	/// Summary description for Util.
	/// </summary>
	public class Util
	{
		/// <summary>
		/// Get input from the user
		/// </summary>
		public static SshConnectionInfo GetInput()
		{
			SshConnectionInfo info = new SshConnectionInfo();
			info.Host = Console.ReadLine();
			info.User = Console.ReadLine();
			info.Pass = Console.ReadLine();

			Console.WriteLine();
			return info;
		}
	}

	public struct SshConnectionInfo
	{
		public string Host;
		public string User;
		public string Pass;
	}
}
