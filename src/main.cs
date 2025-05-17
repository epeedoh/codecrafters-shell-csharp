using System.Net;
using System.Net.Sockets;








while (true)
{
    // Uncomment this line to pass the first stage
    Console.Write("$ ");

    // Wait for user input
    String? command = Console.ReadLine()?.Trim();



    //if (string.IsNullOrEmpty(command) || command.ToLower() == "exit 0")
    //    break;
    if (command.Contains("echo "))
    {
          Console.WriteLine(command);
    }
       
    else {
      Console.WriteLine($"{command}: command not found");
    }
     

     if (command.ToLower() == "exit 0")
        break;

   // return;

}