using System.Security.Cryptography.X509Certificates;

namespace FighterOOP
{
    class Program
    {
        static void Main()
        {
            int kickerwins = 0;
            int puncherwins = 0;
            Console.WriteLine("Welcome to the Fighting Game!");

            kicker p1 = new kicker();
            puncher p2 = new puncher();

            while (true)
            {
                fight game = new fight(p1, p2);

                if (game.result == 1)
                {
                    kickerwins += 1;
                    p2 = new puncher();
                } else
                {
                    puncherwins += 1;
                    p1 = new kicker();
                }

                Console.WriteLine($"The new score is: \nKicker {kickerwins} - {puncherwins} Puncher");

                Console.WriteLine("Do you want to let them fight again? (y/n)");
                string input = Console.ReadLine();
                if (input.ToLower() == "y" || input.ToLower() == "yes")
                {
                    continue;
                }
                break;
            }
        }
    }

    class fight
    {
        public int result = 0;
        public fight(kicker player1, puncher player2)
        {
            Random randomObj = new Random();
            while (true)
            {
                if (player1.hp > 0 && player2.hp > 0)
                {
                    int attacker = 0;
                    if (randomObj.Next(1, 3) == 1)
                    {
                        attacker = 1;
                    } else
                    {
                        attacker = 2;
                    }
                    int attack = randomObj.Next(1, 3);

                    string name = "";
                    string attck = "";
                    if (attacker == 1 && attack == 1) {
                        player1.attack(player2);
                        name = "Kicker";
                        attck = "Standard";
                    } else if (attacker == 2 && attack == 1) {
                        player2.attack(player1);
                        name = "Puncher";
                        attck = "Standard";
                    } else if (attacker == 1 && attack == 2) {
                        player1.specialAttack(player2);
                        name = "Kicker";
                        attck = "Kick";
                    } else if (attacker == 2 && attack == 2) {
                        player2.specialAttack(player1);
                        name = "Puncher";
                        attck = "Punch";
                    }

                    Console.WriteLine($"\n{name} does a {attck} attack.");
                    Console.WriteLine($"Kicker is now at {player1.hp} and Puncher is now at {player2.hp}.");
                    
                } else { break;}
            }

            if (player2.hp <= 0)
            {
                Console.WriteLine("Puncher is surrendering. Kicker has won the fight!");
                result = 1;
            }
            else if (player1.hp <= 0)
            {
                Console.WriteLine("Kicker is surrendering. Puncher has won the fight!");
                result = 2;
            }
        }
    }

    class fighter
    {
        // Variables
        public int hp = 100;
        public int dmg = 10;

        public fighter() // Initialization function
        {
            
        }

        public void attack(fighter enemy) // Takes the enemy object and removes dmg amount of health from the enemies hp.
        {
            enemy.hp -= dmg;
        }
    }

    class kicker: fighter // Inherited from fighter class. This is 1 of the 2 versions of the fighter. Has the special attack kick.
    {
        public int footSize = 2;  
        
        public void specialAttack(fighter enemy)
        {
            enemy.hp -= dmg * footSize;
        }
    }

    class puncher: fighter // Inherited from fighter class. This is 1 of the 2 versions of the fighter. Has the special attack punch.
    {
        public int fistSize = 2;

        public void specialAttack(fighter enemy)
        {
            enemy.hp -= dmg * fistSize;
        }
    }
}