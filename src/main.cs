using System.Net;
using System.Net.Sockets;








while (true)
{
    // Uncomment this line to pass the first stage
    Console.Write("$ ");

    // Wait for user input
    String? command = Console.ReadLine()?.Trim();



    
    if (string.IsNullOrEmpty(command) || command.ToLower() == "exit 0")
        break;

    if (command.Contains("echo "))
    {
        command = command.Replace("echo ", "");
          Console.WriteLine(command);
    }else if(command.Contains("type "))
    {
        command = command.Replace("type ", "");

        Console.WriteLine(command + " is a shell builtin");
    }

    else {
      Console.WriteLine($"{command}: command not found");
    }
     
 

   

   // return;

}