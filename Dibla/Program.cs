using System;
using System.IO;

namespace Dibla
{
    class Program
    {
        static void mainMenu()
        {
            Console.WriteLine("1.New Game");
            Console.WriteLine("2.Continue");
            Console.WriteLine("3.Delete character");
        }
        static int selectAction(int i, int y)
        {
            bool check = false;
            int otvetCode;
            while (true)
            {
                check = false;
                Console.Write("Choose action: ");
                try
                {
                    otvetCode = Convert.ToInt32(Console.ReadLine());
                    if ((otvetCode >= i) && (otvetCode <= y))
                    {
                        check = false;
                    }
                    else
                    {
                        Console.WriteLine("Undefined action");
                        check = true;
                    }
                }
                catch (Exception e)
                {
                    check = true;
                    Console.WriteLine("Undefined action");
                    continue;
                }
                if (check == false)
                    break;
            }
            Console.WriteLine();
            return otvetCode;
        }
        class CreatingHero
        {
            public static void difficulty()
            {
                Console.WriteLine("Choose difficulty");
                Console.WriteLine("1.Default");
                Console.WriteLine("2.Exspert");
                Console.WriteLine("3.Master");
            }
            public static void chooseSide()
            {
                Console.WriteLine("Choose your side:");
                Console.WriteLine("1.Radiant");
                Console.WriteLine("2.Dire");
            }
            public static void radiantRace()
            {
                Console.WriteLine("Choose your race:");
                Console.WriteLine("1.Human");
                Console.WriteLine("2.Dwarf");
                Console.WriteLine("3.Night Elf");
                Console.WriteLine("4.Gnom");
                Console.WriteLine("5.Dreney");
            }
            public static string choosenRadiantRace(int otvet)
            {
                string race = "";
                switch (otvet)
                {
                    case 1:
                        race = "Human";
                        break;
                    case 2:
                        race = "Dwarf";
                        break;
                    case 3:
                        race = "Nught Elf";
                        break;
                    case 4:
                        race = "Gnom";
                        break;
                    case 5:
                        race = "Dreney";
                        break;
                }
                return race;
            }
            public static void direRace()
            {
                Console.WriteLine("Choose your race:");
                Console.WriteLine("1.Orc");
                Console.WriteLine("2.Undead");
                Console.WriteLine("3.Tauren");
                Console.WriteLine("4.Troll");
                Console.WriteLine("5.Blood Elf");
            }
            public static string choosenDireRace(int otvet)
            {
                string race = "";
                switch (otvet)
                {
                    case 1:
                        race = "Orc";
                        break;
                    case 2:
                        race = "Undead";
                        break;
                    case 3:
                        race = "Tauren";
                        break;
                    case 4:
                        race = "Troll";
                        break;
                    case 5:
                        race = "Blood Elf";
                        break;
                }
                return race;
            }
            public static void raceClass()
            {
                Console.WriteLine("Choose your class:");
                Console.WriteLine("1.Priest");
                Console.WriteLine("2.Bandit");
                Console.WriteLine("3.Warrior");
                Console.WriteLine("4.Hunter");
                Console.WriteLine("5.Druid");
                Console.WriteLine("6.Mag");
                Console.WriteLine("7.Shaman");
                Console.WriteLine("8.Warlock");
                Console.WriteLine("9.Paladin");
                Console.WriteLine("10.Death knight");
            }
            public static string choosenClass(int otvet)
            {
                string Class = "";
                switch (otvet)
                {
                    case 1:
                        Class = "Priest";
                        break;
                    case 2:
                        Class = "Bandit";
                        break;
                    case 3:
                        Class = "Warrior";
                        break;
                    case 4:
                        Class = "Hunter";
                        break;
                    case 5:
                        Class = "Druid";
                        break;
                    case 6:
                        Class = "Mag";
                        break;
                    case 7:
                        Class = "Shaman";
                        break;
                    case 8:
                        Class = "Warlock";
                        break;
                    case 9:
                        Class = "Paladin";
                        break;
                    case 10:
                        Class = "Death knight";
                        break;
                }
                return Class;
            }
            public static string choosenRadiant()
            {
                string Class = "";
                int otvet;
                string Race = "";
                string itog = "";
                CreatingHero.radiantRace();
                otvet = selectAction(1, 5);
                Race = CreatingHero.choosenRadiantRace(otvet);
                CreatingHero.raceClass();
                otvet = selectAction(1, 10);
                Class = CreatingHero.choosenClass(otvet);
                itog = Race + " " + Class;
                return itog;
            }
            public static string choosenDire()
            {
                string Class = "";
                int otvet;
                string Race = "";
                string itog = "";
                CreatingHero.direRace();
                otvet = selectAction(1, 5);
                Race = CreatingHero.choosenDireRace(otvet);
                CreatingHero.raceClass();
                otvet = selectAction(1, 10);
                Class = CreatingHero.choosenClass(otvet);
                itog = Race + " " + Class;
                return itog;
            }
        }
        class StartGame
        {
            public static void startGame(string[] character) { 
                
            }
        }
        static void yesno()
        {
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
        }
        static void Main(string[] args)
        {
            string[] character;
            string difficulty;
            int otvet;
            string Side = "";
            string Class;
            string Race;
            string Name;
            string[] RaceClass = { "", "" };

            mainMenu();
            otvet = selectAction(1, 4);

            switch (otvet)
            {
                case 1:
                    Console.WriteLine("Creating Hero");
                    Console.WriteLine();
                    CreatingHero.chooseSide();
                    otvet = selectAction(1, 2);
                    switch (otvet)
                    {
                        case 1:
                            Side = "Radiant";
                            break;
                        case 2:
                            Side = "Dire";
                            break;
                    }
                    switch (otvet)
                    {
                        case 1:
                            RaceClass = CreatingHero.choosenRadiant().Split(' ');
                            break;
                        case 2:
                            RaceClass = CreatingHero.choosenDire().Split(' ');
                            break;
                    }
                    Race = RaceClass[0];
                    Class = RaceClass[1];
                    Console.Write("Enter yours character name: ");
                    Name = Console.ReadLine();
                    CreatingHero.difficulty();
                    otvet = selectAction(1, 3);
                    switch (otvet)
                    {
                        case 1:
                            difficulty = "Default";
                            break;
                        case 2:
                            difficulty = "Exspert";
                            break;
                        case 3:
                            difficulty = "Master";
                            break;
                        default:
                            difficulty = "";
                            break;
                    }
                    string filename = Name + ".txt";
                    StreamWriter sw = new StreamWriter(filename);
                    sw.WriteLine(Name + " " + Side + " " + Race + " " + Class + " " + difficulty);
                    sw.Close();
                    Console.WriteLine("Character {0} has been created", Name);
                    StreamReader sr1 = new StreamReader(filename);
                    string line1 = sr1.ReadLine();
                    character = line1.Split(' ');
                    sr1.Close();\
                    Console.WriteLine("Start game?");
                    yesno();
                    otvet = selectAction(1,2);
                    switch (otvet) {
                        case 1:
                            StartGame.startGame(character);
                            break;
                        case 2:
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Write your character's name: ");
                    Name = Console.ReadLine();
                    filename = Name + ".txt";
                    StreamReader sr = new StreamReader(filename);
                    string line = sr.ReadLine();
                    character = line.Split(' ');
                    sr.Close();
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
            }
        }
    }
}
