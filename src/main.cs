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
            Console.WriteLine("invalid_command: not found");


    }

    else {
        Console.WriteLine($"{command}: command not found");
    }
     
 

   

   // return;

}