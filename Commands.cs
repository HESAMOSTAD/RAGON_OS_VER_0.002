using System;



namespace RAGON_OS
{
    class Commands
    {
       

        public static int input { get; private set; }
       

        public static void clear()
        {
            Console.Clear();
            Console.WriteLine(@"
   / __ \/   | / ____/ __ \/ | / /   / __ \/ ___/
  / /_/ / /| |/ / __/ / / /  |/ /   / / / /\__ \ 
 / _, _/ ___ / /_/ / /_/ / /|  /   / /_/ /___/ / 
/_/ |_/_/  |_\____/\____/_/ |_/____\____//____/  
                             /_____/        
");

        }
        public static void Halt()
        {
            Cosmos.System.power.shutdown();
        }
        public static void reboot()
        {
            Cosmos.System.Power.Reboot();
        }
        public static void backgroundcolor()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.Write("changed; ");
        }
        public static void version()
        {
            Console.WriteLine("RAGON_OS V 0.001 OPEN SOURCE LEARNING OPERATION SYSTEM");
            Console.WriteLine("POWERED BE C# COSMOS PROJECT");
        }
        public static void help()
        {
            Console.WriteLine(@"
  ___ 
 |__ \
   / /
  |_| 
  (_) 
      
");
            Console.WriteLine("1.change background text color to blue with .blue.cyan.red.blue.yellow/background");
            Console.WriteLine("clear commands with cls or clear");
            Console.WriteLine("shutdown or power off for shut down and restart or reboot for reboot");
            Console.WriteLine("type (banner) for recopy the banner");
        }
        public static void banner()
        {
            Console.WriteLine(@"
   / __ \/   | / ____/ __ \/ | / /   / __ \/ ___/
  / /_/ / /| |/ / __/ / / /  |/ /   / / / /\__ \ 
 / _, _/ ___ / /_/ / /_/ / /|  /   / /_/ /___/ / 
/_/ |_/_/  |_\____/\____/_/ |_/____\____//____/  
                             /_____/        
");

        }
        public static void BC()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            
            Console.Write("changed;");
        }
        public static void bc1()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            
            Console.Write("changed; ");
        }
        public static void bc2()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("changed; ");
        }
        public static void bc3()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("changed; ");
        }
   
    }
}
        



