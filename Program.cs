using System;

namespace BilVerksted
{
    class Program
    {
        static void Main(string[] args)
        {
            var workshop = new CommandHandler(new Workshop());

            while (true)
            {
                workshop.DisplayCommands();
                var command = Console.ReadLine();
                workshop.HandleCommand(command);
            }
        }
    }
}
