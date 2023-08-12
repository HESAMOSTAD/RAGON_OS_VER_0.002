using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sys = Cosmos.System;

namespace RAGON_OS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("RAGON_OS   MADE WITH COSMOS PROJECT                      V0.001");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
   / __ \/   | / ____/ __ \/ | / /   / __ \/ ___/
  / /_/ / /| |/ / __/ / / /  |/ /   / / / /\__ \ 
 / _, _/ ___ / /_/ / /_/ / /|  /   / /_/ /___/ / 
/_/ |_/_/  |_\____/\____/_/ |_/____\____//____/  
                             /_____/                                                                                                                                                                                                        
");
      

        }

        protected override void Run()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("=> ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            var input = Console.ReadLine();
            switch (input)
               
            {
                case "":
                    break;
                case "bluebackground":
                    Commands.backgroundcolor();
                    break;
                case "clear":
                case "cls":
                    Commands.clear();
                    break;
                case "shutdown":
                case "poweroff":
                    Commands.Halt();
                    break;
                case "reboot":
                case "restart":
                    Commands.reboot();
                    break;

                case "version":
                case "about":
                    Commands.version();
                    break;
                case "help":
                case "commands":
                    Commands.help();
                    break;
                case "banner":
                    Commands.banner();
                    break;
                case "cyanbackground":
                    Commands.BC();
                    break;
                case "whitebackground":
                    Commands.bc3();
                    break;
                case "redbackground":
                    Commands.bc2();
                    break;
                case "yellowbackground":
                    Commands.bc1();
                    break;
                
             
                
                    
                   
                

                    
             
                
                
                    













            }
        }


    }
}