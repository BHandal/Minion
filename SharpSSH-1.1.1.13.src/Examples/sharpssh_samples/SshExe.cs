using System;
using System.Collections;
using Tamir.SharpSsh;

namespace sharpssh.executable
{
	/// <summary>
	/// Summary description for SshExeTest.
	/// </summary>
	public class ssh_exe
    {
        SshExec exec;
		public void Run()
		{
			try
			{
                SshConnectionInfo input = Util.GetInput();
                exec = new SshExec(input.Host, input.User);
                if (input.Pass != null) exec.Password = input.Pass;
                exec.Connect();
				string command = Console.ReadLine();
				string output = exec.RunCommand(command);				
				Console.WriteLine(output);				
                exec.Close();
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
