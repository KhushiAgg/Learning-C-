using System;

namespace Learning_C_
{
    class Wizard
    {
        public string name;
        public string favouriteSpell;
        public int spellSlots;
        public float experience;

        public static int Count; // static variables  are used for defining constants because their values can be retrieved by invoking the class without creating an instance of it.

        public Wizard(string _name, string _favouriteSpell) // Constructor; for initializing
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
            weaponDamage = 5;
            health = 2;
        }

        public void Weaponswing()
        {
            Console.WriteLine(name + " swings " + favWeapon);
            weaponDamage--;
        }

        public void changeWeapon(string favweapon2)
        {
            Console.WriteLine(name + " swings another sword " + favweapon2);
            health--;
        }

    }

    class Dragon_Guards
    {
        public string name;
        public string handSign; // weave hand signs to produce fire and water learnt from the dragon named: Agni(fire)
        public string potion; // to restore health
        public int energy; //aka chakra from naruto
        public int health;
        
        public Dragon_Guards(string _name, string _handSign, string _potion)
        {
            name = _name;
            handSign = _handSign;
            energy = 6;
            health = 3;
            potion = _potion;
        }

        public void HandSign()
        {
            if ( handSign == "Agni" )
            {
                Console.WriteLine(name + " weaves " + handSign + " and shoots a big Fire Ball!!!!");
            }
            else if (handSign == "Pani" )
            {
                Console.WriteLine(name + " weaves " + handSign + " and floods the Cave!!!!");
            }
            energy-= 2;
            health--;
        }
        public void restoreJuice()
        {
            Console.WriteLine(name + " drinks " + potion+ " to recharge his energy!");
            energy = 6;
            health = 3;
        }

    }



    class Program
    {
        public static object KeyPress { get; private set; }

        static void Main(string[] args)
        {
            /* BTS Fantasy Universe
            Characters: Kim Namjoon and Min Yoongi as Wizards, UTILIZED
            Kim Seokjin and Jeon Jungkook as Dragon Hunters, UTILIZED
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
                    PrintColorMessage(ConsoleColor.Gray, part13);
                    string key2 = Console.ReadLine().ToUpper();

                    if (key2 == "K")
                    {
                        if (RollingDie()<=3)
                        {
                            Dragon_Hunter hunter01 = new Dragon_Hunter("Kim Seokjin", "Impaca!");
                            string part25 = " Dragon Hunter "+hunter01.name + " has appeared right on time!!!";
                            PrintColorMessage(ConsoleColor.DarkBlue, part25);
                            hunter01.Weaponswing();
                            while(hunter01.weaponDamage!=0)
                            {
                                string part14 = " The Dragon attacks " + hunter01.name;
                                PrintColorMessage(ConsoleColor.DarkMagenta, part14);
                                hunter01.Weaponswing();
                            }
                            string part15 = " " +hunter01.name + "'s Weapon is Damaged!!!";
                            PrintColorMessage(ConsoleColor.DarkCyan, part15);
                            hunter01.changeWeapon("Tupaca!!");
                            while(hunter01.health != 0)
                            {
                                string part16 = " The Dragon attacks " + hunter01.name;
                                PrintColorMessage(ConsoleColor.DarkMagenta, part16);
                                hunter01.changeWeapon("Tupaca!!");
                            }
                            string part18 = " " +hunter01.name +" has been defeated";
                            PrintColorMessage(ConsoleColor.DarkGreen, part18);
                            
                        }
                        else
                        {
                            Dragon_Hunter hunter02 = new Dragon_Hunter("Jeon Jungkook", "Dynanananana!");
                            string part25 = " Dragon Hunter " +hunter02.name+ " has appeared right on time!!!";
                            PrintColorMessage(ConsoleColor.DarkBlue, part25);
                            hunter02.Weaponswing();
                            while(hunter02.weaponDamage!=0)
                            {
                                string part16 = " The Dragon attacks " + hunter02.name;
                                PrintColorMessage(ConsoleColor.DarkMagenta, part16);
                                hunter02.Weaponswing();
                            }
                            string part17 = " " +hunter02.name + "'s Weapon is Damaged!!!";
                            PrintColorMessage(ConsoleColor.DarkCyan, part17);
                            hunter02.changeWeapon("Bananana!!");
                            while(hunter02.health != 0)
                            {
                                string part19 = " The Dragon attacks " + hunter02.name;
                                PrintColorMessage(ConsoleColor.DarkMagenta, part19);
                                hunter02.changeWeapon("Bananana!!");
                            }
                            string part20 = " " +hunter02.name +" has been defeated";
                            PrintColorMessage(ConsoleColor.DarkGreen, part20);
                            
                        }

                        //For calling Dragon Guards
                        string part21 = " " +name +" This Demon Dragon is very powerful!!!\n Press W to Roll the die again...";
                        PrintColorMessage(ConsoleColor.Gray, part21);
                        string key3 = Console.ReadLine().ToUpper();

                        if(key3 == "W")
                        {
                            if (RollingDie()<=3)
                            {
                                Dragon_Guards guards01 = new Dragon_Guards("Park Jimin", "Agni", "Coconut potion");
                                string part26 = " Looks like you summoned a very powerful fighter!!! \n Queen's personal Guard " + guards01.name;
                                PrintColorMessage(ConsoleColor.DarkBlue, part26);

                                guards01.HandSign();
                                while(guards01.health !=0 )
                                {
                                    string part22 = " The Dragon attacks!!" + guards01.name;
                                    PrintColorMessage(ConsoleColor.Red, part22);
                                    guards01.HandSign();
                                }
                                string part23 = " Oh no! " +guards01.name + " is out of Chakra!!!";
                                PrintColorMessage(ConsoleColor.Red, part23);
                                guards01.restoreJuice();
                            }
                            else
                            {
                                Dragon_Guards guards02 = new Dragon_Guards("Jung Hoseok", "Pani", "Coconut potion");
                                string part26 = " Looks like you summoned a very powerful fighter!!! \n Queen's personal Guard " + guards02.name;
                                PrintColorMessage(ConsoleColor.DarkBlue, part26);
                                guards02.HandSign();
                                while(guards02.health !=0 )
                                {
                                    string part22 = " The Dragon attacks!!" + guards02.name;
                                    PrintColorMessage(ConsoleColor.Red, part22);
                                    guards02.HandSign();
                                }
                                string part24 = " Oh no! " +guards02.name + " is out of Chakra!!!";
                                PrintColorMessage(ConsoleColor.Red, part24);
                                guards02.restoreJuice();
                            }
                            
                            string part27 = " Ohhh Kim Taehyung has found an ancient book!!!\n Flip flip Flip \n " + name +" You have obtained the power of the book: Telepathy!!!!\n You need to guess a number between 0-10 which Kim Taehyung is thinking...\n You'll be given 5 chances if you guess wrong You die, We die Everybody die!!!\n Good luck! " +name;
                            PrintColorMessage(ConsoleColor.Cyan, part27);

                            for (int i = 4; i>=0; i--)
                            {
                                if (GuessNumber() == 1)
                                {
                                    PrintColorMessage(ConsoleColor.DarkGreen, "CORRECT guess!!!\n\n");
                                    PrintColorMessage(ConsoleColor.DarkCyan, " Kim Taehyung casts Purple Sparkle...\t Congratulations!!! \tYou have defeated the Demon Dragon!!!");
                                    break;
                                }
                                else
                                {
                                    PrintColorMessage(ConsoleColor.Red, "You guessed the Wrong number...");
                                    PrintColorMessage(ConsoleColor.Blue, "Chances left: " + i);
                                    if(i == 0)
                                    {
                                        PrintColorMessage(ConsoleColor.DarkYellow, "Demon Dragon burns everyone!!!" );
                                    }
                                }
                            }
                            
                        }
                    }

                }
                

            }

            Console.ReadKey();
        }

        // A static method in C# is a method that keeps only one copy of the method

        static void GetAppInfo()
        {
            // Set app variables
            string gameName = "Greatest Wizard";
            string gameVersion = "1.0.0";
            string gameAuthor = "Khushi Aggarwal";

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
            Random random = new Random();
            int side = 6;

            return random.Next(1, side + 1);
        }

        static int GuessNumber()
        {
            Random random = new Random(); 
            int correctNum = random.Next(1, 10);
            int guess = 0;
            int temp = 1;
            Console.WriteLine("Guess a number between 1 and 10: ");

            while (guess != correctNum)
            {
                string mynum = Console.ReadLine();
                if (!int.TryParse(mynum, out guess))
                {
                    PrintColorMessage(ConsoleColor.Red, "Input a number!");
                    continue;
                }
                guess = Int32.Parse(mynum);

                if(guess != correctNum)
                {
                    temp = 0;
                    return temp;
                    //PrintColorMessage(ConsoleColor.Gray, "You guessed the Wrong number...");
                }
            }
            return temp;
            //PrintColorMessage(ConsoleColor.DarkGreen, "CORRECT guess!!!");
            
        }

    }
}
