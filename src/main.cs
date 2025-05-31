using System.Linq;
using System.Net;
using System.Net.Sockets;








while (true)
{
    // Uncomment this line to pass the first stage
    Console.Write("$ ");

    // Wait for user input
    String? command = Console.ReadLine()?.Trim();

    var listCommands = new List<string> { "echo", "type", "exit" };

    
    if (string.IsNullOrEmpty(command) || command.ToLower() == "exit 0")
        break;

    if (command.Contains("echo "))
    {
        command = command.Replace("echo ", "");
          Console.WriteLine(command);
    }else if(command.Contains("type "))
    {
        command = command.Replace("type ", "");

        var existCommand = listCommands.FirstOrDefault(x => x == command);

        if (existCommand != null)
            Console.WriteLine(command + " is a shell builtin");
        else
        {
            string? pathEnv = Environment.GetEnvironmentVariable("PATH");
            if(pathEnv !=null)
            {
                var paths = pathEnv.Split(';');
                //Console.WriteLine(paths);
                //Console.WriteLine(pathEnv);

                bool found = false;

                foreach (string path in paths)
                {
                    string fullPath = Path.Combine(path, command);
                    if (File.Exists(fullPath) && (new FileInfo(fullPath).Attributes & FileAttributes.Directory) == 0)
                    {
                        Console.WriteLine($"{command} is {fullPath}");
                        found = true;
                        break;
                    }
                }

                if(!found)
                {
                    Console.WriteLine($"{command}: not found");
                }
            }
            else
            {
                Console.WriteLine("PATH variable not found");
            }
        }
        //else
        //    Console.WriteLine(command + ": not found");


    }

    else {
        Console.WriteLine($"{command}: command not found");
    }
     
 

   

   // return;

}