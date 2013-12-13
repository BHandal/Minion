using System;
using System.Collections;
using Tamir.SharpSsh;
using System.IO;

namespace sharpssh.executable
{
	/// <summary>
	/// Summary description for SshExeTest.
	/// </summary>
	public class ssh_shell
	{
		public void Run()
		{
			try
			{
				SshConnectionInfo input = Util.GetInput();
				SshShell shell = new SshShell(input.Host, input.User);
				if(input.Pass != null) shell.Password = input.Pass;

				//This statement must be prior to connecting
				shell.RedirectToConsole();

				shell.Connect();

				while(shell.ShellOpened)
				{
					System.Threading.Thread.Sleep(500);
				}
				shell.Close();
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
