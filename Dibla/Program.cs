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
            public static int[] raceStats(int[] stats, string race)
            {
                switch (race)
                {
                    case "Human":
                        stats[0] = 20;
                        stats[1] = 20;
                        stats[2] = 20;
                        stats[3] = 20;
                        break;
                    case "Dwarf":
                        stats[0] = 25;
                        stats[1] = 16;
                        stats[2] = 21;
                        stats[3] = 19;
                        break;
                    case "NightElf":
                        stats[0] = 16;
                        stats[1] = 24;
                        stats[2] = 20;
                        stats[3] = 20;
                        break;
                    case "Gnom":
                        stats[0] = 15;
                        stats[1] = 22;
                        stats[2] = 20;
                        stats[3] = 23;
                        break;
                    case "Dreney":
                        stats[0] = 21;
                        stats[1] = 17;
                        stats[2] = 20;
                        stats[3] = 20;
                        break;

                    case "Orc":
                        stats[0] = 23;
                        stats[1] = 17;
                        stats[2] = 21;
                        stats[3] = 17;
                        break;
                    case "Undead":
                        stats[0] = 19;
                        stats[1] = 18;
                        stats[2] = 20;
                        stats[3] = 18;
                        break;
                    case "Tauren":
                        stats[0] = 25;
                        stats[1] = 16;
                        stats[2] = 21;
                        stats[3] = 16;
                        break;
                    case "Troll":
                        stats[0] = 21;
                        stats[1] = 22;
                        stats[2] = 20;
                        stats[3] = 16;
                        break;
                    case "BloodElf":
                        stats[0] = 17;
                        stats[1] = 22;
                        stats[2] = 20;
                        stats[3] = 23;
                        break;
                }
                return stats;
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
                        race = "NightElf";
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
                        race = "BloodElf";
                        break;
                }
                return race;
            }
            public static int[] classStats(int[] stats, string Class)
            {
                switch (Class)
                {
                    case "Priest":
                        stats[0] = 0;
                        stats[1] = 0;
                        stats[2] = 0;
                        stats[3] = 2;
                        break;
                    case "Bandit":
                        stats[0] = 1;
                        stats[1] = 3;
                        stats[2] = 1;
                        stats[3] = 0;
                        break;
                    case "Warrior":
                        stats[0] = 3;
                        stats[1] = 0;
                        stats[2] = 2;
                        stats[3] = 0;
                        break;
                    case "Hunter":
                        stats[0] = 0;
                        stats[1] = 3;
                        stats[2] = 1;
                        stats[3] = 0;
                        break;
                    case "Druid":
                        stats[0] = 1;
                        stats[1] = 0;
                        stats[2] = 0;
                        stats[3] = 2;
                        break;
                    case "Mag":
                        stats[0] = 0;
                        stats[1] = 0;
                        stats[2] = 0;
                        stats[3] = 3;
                        break;
                    case "Shaman":
                        stats[0] = 1;
                        stats[1] = 0;
                        stats[2] = 1;
                        stats[3] = 1;
                        break;
                    case "Warlock":
                        stats[0] = 0;
                        stats[1] = 0;
                        stats[2] = 1;
                        stats[3] = 2;
                        break;
                    case "Paladin":
                        stats[0] = 2;
                        stats[1] = 0;
                        stats[2] = 2;
                        stats[3] = 0;
                        break;
                    case "Deathknight":
                        stats[0] = 4;
                        stats[1] = 3;
                        stats[2] = 3;
                        stats[3] = 1;
                        break;
                }
                return stats;
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
                        Class = "Deathknight";
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
            int[] stats = { 0, 0, 0, 0 };
            int[] classStats = { 0, 0, 0, 0 };
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
                            stats = CreatingHero.raceStats(stats, RaceClass[0]);
                            classStats = CreatingHero.classStats(classStats, RaceClass[1]);
                            break;
                        case 2:
                            RaceClass = CreatingHero.choosenDire().Split(' ');
                            stats = CreatingHero.raceStats(stats, RaceClass[0]);
                            classStats = CreatingHero.classStats(classStats, RaceClass[1]);
                            break;
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        stats[i] = stats[i] + classStats[i];
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
                    sw.WriteLine(Name + " " + Side + " " + Race + " " + Class + " " + difficulty + " " + location + " " + stats[0] + " " +
                       stats[1] + " " + stats[2] + " " + stats[3]);
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
