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
            // Name, Side, Race, Class, Difficulty, location
            static void saveGame(string[] character)
            {
                string filename = character[0] + ".txt";
                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine(character[0] + " " + character[1] + " " + character[2] + " " + character[3] + " " + character[4] + " " + character[5]);
                sw.Close();
            }
            static string quit(string location)
            {
                location = location + ".quit";
                return location;
            }
            static string aroundactions(string location, string[] towns)
            {
                bool flag = false;
                string x = "";
                int otvet;
                int lenght = towns.Length;

                while (true)
                {
                    aroundLoc();
                    otvet = selectAction(0, 0);
                    switch (otvet)
                    {
                        case 0:
                            x = location;
                            break;
                    }
                    for (int i = 0; i < lenght; i++)
                    {
                        if (x == towns[i])
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        break;
                    }
                }
                return location;
            }
            static void aroundLoc()
            {
                Console.WriteLine("0.Exit");
            }
            static string Kelindorf(string[] KelindorfAround, string location)
            {
                int otvet, x;
                city();
                otvet = selectAction(0, 6);
                switch (otvet)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        x = aroundLocations(KelindorfAround);
                        otvet = selectAction(1, x);
                        switch (KelindorfAround[otvet - 1])
                        {
                            case "Kel's forest":
                                location = "Kel's forest";
                                break;
                            case "Abondoned caves":
                                location = "Abondoned caves";
                                break;
                        }
                        break;
                    case 0:
                        location = quit(location);
                        break;
                }
                return location;
            }
            static int aroundLocations(string[] aroundLocations)
            {
                int lenght = aroundLocations.Length;
                for (int i = 0; i < lenght; i++)
                {
                    Console.WriteLine("{0}.{1}", (i + 1), aroundLocations[i]);
                }
                return lenght;
            }
            static void city()
            {
                Console.WriteLine("1.Blacksmith");
                Console.WriteLine("2.Wizard");
                Console.WriteLine("3.Alchemy");
                Console.WriteLine("4.Merchant");
                Console.WriteLine("5.Guild");
                Console.WriteLine("6.Gates");
                Console.WriteLine("0.Save game and quit");
            }
            public static void startGame(string[] character)
            {
                bool quitGame = false;
                string[] towns = { "Kelindorf" };
                string location = character[5];
                int otvet;
                int x;
                string[] aroundLocation;
                string[] KelindorfAround = { "Kel's forest", "Abondoned caves" };
                string[] monsters = { "Cobold", "Wolf" };

                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("You now in {0}", location);
                    switch (location)
                    {
                        case "Kelindorf":
                            location = Kelindorf(KelindorfAround, location);
                            break;
                        case "Kel's forest":
                            location = aroundactions("Kelindorf", towns);
                            break;
                        case "Abondoned caves":
                            location = aroundactions("Kelindorf", towns);
                            break;

                        case "Merkland":
                            break;
                    }
                    switch (location)
                    {
                        case "Kelindorf.quit":
                            quitGame = true;
                            break;
                    }
                    if (quitGame == true)
                    {
                        saveGame(character);
                        break;
                    }
                }
            }
        }
        static void yesno()
        {
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
        }
        static void Main(string[] args)
        {
            string location;
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
                    if (Side == "Radiant")
                    {
                        location = "Kelindorf";
                    }
                    else
                    {
                        location = "Merkland";
                    }
                    sw.WriteLine(Name + " " + Side + " " + Race + " " + Class + " " + difficulty + " " + location);
                    sw.Close();
                    Console.WriteLine("Character {0} has been created", Name);
                    StreamReader sr1 = new StreamReader(filename);
                    string line1 = sr1.ReadLine();
                    character = line1.Split(' ');
                    sr1.Close();

                    Console.WriteLine("Start game?");
                    yesno();
                    otvet = selectAction(1, 2);
                    switch (otvet)
                    {
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
                    StartGame.startGame(character);
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
            }
        }
    }
}
