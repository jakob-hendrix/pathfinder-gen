using System;
using PathfinderTools.Core.Builder;

namespace PathfinderTools.ConsoleUi
{
    public static class App
    {
        private static CharacterBuilder _builder;

        public static void Run()
        {
            LoadData();

            bool continueRunning = true;
            while (true)
            {
                continueRunning = true;
                switch (ChooseMainAction())
                {
                    case AppMenuOptions.QuitProgram:
                        continueRunning = false;
                        break;
                    case AppMenuOptions.StartNewCharacter:
                        BuildNewCharacter();
                        break;
                    case AppMenuOptions.LoadCharacter:
                        Console.WriteLine("\n\nThe [Load] function is under development...press any key to continue");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("\n\nUnrecognized command. Please try another option...press any key to continue");
                        Console.ReadKey();
                        break;

                }

                if (!continueRunning)
                {
                    break;
                }
            }
        }

        private static void LoadData()
        {
            // Load Pathfinder data from data source

        }

        private static void BuildNewCharacter()
        {
            _builder = new CharacterBuilder();
        }

        private static AppMenuOptions ChooseMainAction()
        {
            AppMenuOptions selection;

            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|      Main Menu      |");
            Console.WriteLine("-----------------------");
            Console.WriteLine("\t1) Start New Character");
            Console.WriteLine("\t2) Load Character");
            Console.WriteLine("\t3) Quit");
            Console.WriteLine();
            Console.Write("Selection: ");
            var entry = Console.ReadKey();

            switch (entry.KeyChar.ToString())
            {
                case "1":
                    selection = AppMenuOptions.StartNewCharacter;
                    break;
                case "2":
                    selection = AppMenuOptions.LoadCharacter;
                    break;
                case "3":
                    selection = AppMenuOptions.QuitProgram;
                    break;
                default:
                    selection = AppMenuOptions.InvalidSelection;
                    break;
            }

            return selection;

        }
    }
}
