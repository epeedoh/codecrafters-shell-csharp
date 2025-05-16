using System.Net;
using System.Net.Sockets;








while (true)
{
    // Uncomment this line to pass the first stage
    Console.Write("$ ");

    // Wait for user input
    String? command = Console.ReadLine()?.Trim();

    //if (command == "exit")
    //    return;

    if (string.IsNullOrEmpty(command) || command.ToLower() == "exit")
       return;

   

    Console.WriteLine($"{command}: command not found");

    Console.Write("$ exit");
    return;

}