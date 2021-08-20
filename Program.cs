using System;

namespace Learning_C_
{
    class Wizard
    {
        public string name;
        public string favouriteSpell;
        public int spellSlots;
        public float experience;

        public static int Count;

        public Wizard(string _name, string _favouriteSpell) // Constructor
        {
            name = _name;
            favouriteSpell = _favouriteSpell;
            spellSlots = 3;
            experience = 0;

            Count++;
        }

        public void CastSpell()
        {
            Console.WriteLine(" " +name + " casts " + favouriteSpell);
            spellSlots--;
            experience += 0.3f;
        }
        public void Meditate()
        {
            Console.WriteLine(" " +name + " meditates to get back Mana.");
            spellSlots = 3;
        }
    }

    class Dragon_Hunter
    {
        public string name;
        public string favWeapon;
        public int weaponDamage;
        public int health;

        public Dragon_Hunter(string _name, string _favWeapon) 
        {
            name = _name;
            favWeapon = _favWeapon;
            weaponDamage = 50;
            health = 10;
        }

        public void Weaponswing()
        {
            Console.WriteLine(name + " swings " + favWeapon);
            weaponDamage--;
        }

        public void changeWeapon()
        {
            Console.WriteLine(name + " changes weapon.");
        }
    }

    class Dragon_Guardian
    {
        public string name;
        public string handSign; // weave hand signs to produce fire and water learnt from the dragon named: Agni(fire)
        public int energy; //aka chakra from naruto
        public int health;
        
        public Dragon_Guardian(string _name, string _handSign)
        {
            name = _name;
            handSign = _handSign;
            energy = 100;
            health = 10;
        }

        public void HandSign()
        {
            Console.WriteLine(name + " weaves " + handSign + " and shoots a big Fire Ball!!!!");
            energy-= 2;
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            /* BTS Fantasy Universe
            Characters: Kim Namjoon and Min Yoongi as Wizards, UTILIZED
            Kim Seokjin and Jeon Jungkook as Dragon Hunters 
            Jung Hoseok as Queen's knight
            Kim Taehyung as Black smith's son (Story's pov); character development from smith to The Greatest wizard
            Park Jimin as The Dragon guardian,
            Enemy: Self interest driven evil character someone like orochimaru Evil Wizard
            ARMYs as Queens BTS will protect */

            GetAppInfo();

            string part1 = " Once appeared Demon Dragon faster than Light. Its Mighty Breath could turn Mountains to Ashes and cause Tsumanis.\n To fight the Demon The Palace Assembled All the Warriors and Wizards from the Village. \n One Brave Wizard was able to chase The Demon away, But because of that He lost his Life. \n That Wizard was called The 4th Greatest Wizard in Purple Nation's History! \n";
            PrintColorMessage(ConsoleColor.Green, part1);
            string part2 = " 8 years Later! \n Enter Kim Taehyung, The son of an Ordinary Black Smith who dreams to become The Greatest Wizard with no Magic powers.\n";
            PrintColorMessage(ConsoleColor.Blue, part2);
            string part3 =  " Bzzzttt Bzzzztt \n Oh! Looks like You have been transported to the World of Purple Nation! Help Kim Taehyung achieve his dreams... \n Please enter your Name: ";
            PrintColorMessage(ConsoleColor.DarkYellow, part3);
            string name  = Console.ReadLine();
            
            
            string part4 = " " + name + " ready for an adventure with Kim Taehyung, As he becomes the Greatest Wizard of Purple Nation! \n Type Yes or No";
            PrintColorMessage(ConsoleColor.Yellow, part4);
            string ans = Console.ReadLine().ToUpper();

            if (ans == "YES")
            {
                string part5 = " Player " + name + " you and Kim Taehyung enter the Dragons cave together. \n You found a Purple Dice inside! \n The Demon Dragon attacks!!! The fate of this Village lies in your Luck " + name;
                PrintColorMessage(ConsoleColor.Yellow, part5);

                //For calling Wizards
                string part6 = " Press E to Roll the dice: ";
                PrintColorMessage(ConsoleColor.Yellow, part6);
                string key = Console.ReadLine().ToUpper();
                
                if (key == "E")
                {
                    // Rolls the die
                    if (RollingDie()<=3)
                    {
                        Wizard wizard01 = new Wizard(" Kim Namjoon" , "Golden Tip!");
                        string part7 = " Wizard " + wizard01.name + " is here!!!";
                        PrintColorMessage(ConsoleColor.Magenta, part7);
                        wizard01.CastSpell();
                        string part8 = " " + wizard01.name + ": What are you kids doing here?\t It's Dangerous!!! \t Run Away Hurry!!! \n You have been saved by " + wizard01.name;
                        PrintColorMessage(ConsoleColor.Magenta, part8);
                        while (wizard01.spellSlots!=0)
                        {
                            string part11 = " The Dragon attacks!!";
                            PrintColorMessage(ConsoleColor.Red, part11);
                            wizard01.CastSpell();
                        }
                        string part12 = " Oh no! " +wizard01.name + " is out of Mana!!!";
                        PrintColorMessage(ConsoleColor.Red, part12);
                        wizard01.Meditate();
                        
                    }
                    else
                    {
                        Wizard wizard02 = new Wizard("Min Yoongi", "Minstradamus!");
                        string part9 = " Wizard " + wizard02.name + " is here!!!";
                        PrintColorMessage(ConsoleColor.Magenta, part9);
                        wizard02.CastSpell();
                        string part10 = " " + wizard02.name + ": Stupid kids!!!\t It's Dangerous!!! \t Run Away Hurry!!!\n You have been saved by " + wizard02.name;
                        PrintColorMessage(ConsoleColor.Magenta, part10);
                        while (wizard02.spellSlots!=0)
                        {
                            string part11 = " The Dragon attacks!!";
                            PrintColorMessage(ConsoleColor.Red, part11);
                            wizard02.CastSpell();
                        }
                        string part12 = " Oh no! " +wizard02.name + " is out of Mana!!!";
                        PrintColorMessage(ConsoleColor.Red, part12);
                        wizard02.Meditate();
                    }

                    //For calling Dragon hunters
                    string part13 = " " +name +" We are in a dire situation...\n Press K to Roll the die again...";
                    PrintColorMessage(ConsoleColor.Red, part13);
                    string key2 = Console.ReadLine().ToUpper();

                    if (key2 == "K")
                    {
                        if (RollingDie()<=3)
                        {
                            Dragon_Hunter hunter01 = new Dragon_Hunter("Kim Seokjin", "Impaca!");
                            hunter01.Weaponswing();
                        }
                        else
                        {
                            Dragon_Hunter hunter02 = new Dragon_Hunter("Jeon Jungkook", "Dynanananana!");
                            hunter02.Weaponswing();
                        }
                    }

                }
                

            }




            
            /* Wizard wizard01 = new Wizard("Kim Namjoon" , "Golden Tip!");
            wizard01.CastSpell();

            Wizard wizard02 = new Wizard("Min Yoongi", "Minstradamus!");
            wizard02.CastSpell();

            Dragon_Hunter hunter01 = new Dragon_Hunter("Kim Seokjin", "Impaca!");
            hunter01.Weaponswing();

            Dragon_Hunter hunter02 = new Dragon_Hunter("Jeon Jungkook", "Dynanananana!");
            hunter02.Weaponswing();

            Dragon_Hunter queensKnight = new Dragon_Hunter("Jung Hoseok", "Kawsssss!");
            queensKnight.Weaponswing();

            Dragon_Guardian guardian = new Dragon_Guardian("Park Jimin", "Horse, Serpent, Ram, Monkey, Boar, Horse, Tiger!");
            guardian.HandSign(); */

            Console.ReadKey();
        }

        static void GetAppInfo()
        {
            // Set app variables
            string gameName = "Greatest Wizard";
            string gameVersion = "1.0.0";
            string gameAuthor = "Khushi Agarwal";

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("{0}: Version {1} by {2}", gameName, gameVersion, gameAuthor);

            Console.ResetColor();
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static int RollingDie()
        {
            Random random;
            int side = 6;
            random = new Random();

            return random.Next(1, side + 1);
        }

    }
}
