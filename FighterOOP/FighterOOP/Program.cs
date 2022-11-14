namespace FighterOOP
{
    class Program
    {
        static void Main()
        {
            Random randomObj = new Random();
            Console.WriteLine("Welcome to the Fighting Game!");

            Kicker k = new Kicker();
            Puncher p = new Puncher();
            Kicker oldKicker = new Kicker();
            Puncher oldPuncher = new Puncher();
            Fighter loser;

            int winner = 1;
            int newFighter = 2;

            Fight game;

            while (true)
            {
                if (winner == 1)
                {
                    if (newFighter == 1)
                    {
                        k = new Kicker();
                        game = new Fight(oldKicker, k);
                        if (game.fightWinner == 1)
                        {
                            loser = k;
                        } else if (game.fightWinner == 2)
                        {
                            loser = oldKicker;
                            oldKicker = k;
                        }
                    } else if (newFighter == 2)
                    {
                        p = new Puncher();
                        game = new Fight(oldKicker, p);
                        if (game.fightWinner == 1)
                        {
                            loser = k;
                        }
                        else if (game.fightWinner == 2)
                        {
                            loser = oldKicker;
                            oldKicker = k;
                        }
                    }
                } else if (winner == 2)
                {
                    if (newFighter == 1)
                    {
                        k = new Kicker();
                        game = new Fight(oldPuncher, k);
                        if (game.fightWinner == 1)
                        {
                            loser = k;
                        }
                        else if (game.fightWinner == 2)
                        {
                            loser = oldPuncher;
                            oldKicker = k;
                        }
                    } else if (newFighter == 2)
                    {
                        p = new Puncher();
                        game = new Fight(oldPuncher, p);
                        if (game.fightWinner == 1)
                        {
                            loser = k;
                        }
                        else if (game.fightWinner == 2)
                        {
                            loser = oldPuncher;
                            oldPuncher = p;
                        }
                    }
                }

                if (winner == 1)
                {
                    Console.WriteLine($"{oldKicker.name} now has {oldKicker.wins} wins.");
                } else if (winner == 2)
                {
                    Console.WriteLine($"{oldPuncher.name} now has {oldPuncher.wins} wins.");
                }

                Console.WriteLine("Do you want to do another fight? (y/n)");
                string input = Console.ReadLine();
                if (input.ToLower() == "y" || input.ToLower() == "yes")
                {
                    Console.WriteLine("What type should the new fighter be? (k/p)");
                    string f = Console.ReadLine();
                    if (f == "k")
                    {
                        newFighter = 1;
                    } else
                    {
                        newFighter = 2;
                    }
                    continue;
                }
                break;
            }
        }
    }

    class Fight
    {
        public int fightWinner = 0;
        public int winnerType = 0;

        public void bothFighters(Kicker fighter1, Puncher fighter2)
        {
            fighter1.name = "Kicker";
            fighter2.name = "Puncher";
            Random randomObj = new Random();
            while (true)
            {
                if (fighter1.hp > 0 && fighter2.hp > 0)
                {
                    int attacker = randomObj.Next(1, 3);
                    int attack = randomObj.Next(1, 3);

                    if (attacker == 1)
                    {
                        if (attack == 1)
                        {
                            fighter1.attack(fighter2);
                        } else
                        {
                            fighter1.specialAttack(fighter2);
                        }
                    } else if (attacker == 2)
                    {
                        if (attack == 1)
                        {
                            fighter2.attack(fighter1);
                        }
                        else
                        {
                            fighter2.specialAttack(fighter1);
                        }
                    }

                    printAttack(fighter1, fighter2, attacker, attack);
                    
                } else { break;}
            }

            int winner = 0;
            if (fighter1.hp <= 0) { winner = 2; } else if (fighter2.hp <= 0) { winner = 1; }
            printResult(fighter1, fighter2, winner);
        }

        public Fight(Kicker fighter1, Puncher fighter2)
        {
            bothFighters(fighter1, fighter2);
        }

        public Fight(Puncher fighter1, Kicker fighter2)
        {
            bothFighters(fighter2, fighter1);
        }

        public Fight(Kicker fighter1, Kicker fighter2)
        {
            fighter1.name = "Kicker";
            fighter2.name = "Kicker 2";
            Random randomObj = new Random();
            while (true)
            {
                if (fighter1.hp > 0 && fighter2.hp > 0)
                {
                    int attacker = randomObj.Next(1, 3);
                    int attack = randomObj.Next(1, 3);

                    if (attacker == 1)
                    {
                        if (attack == 1)
                        {
                            fighter1.attack(fighter2);
                        }
                        else
                        {
                            fighter1.specialAttack(fighter2);
                        }
                    }
                    else if (attacker == 2)
                    {
                        if (attack == 1)
                        {
                            fighter2.attack(fighter1);
                        }
                        else
                        {
                            fighter2.specialAttack(fighter1);
                        }
                    }

                    printAttack(fighter1, fighter2, attacker, attack);

                }
                else { break; }
            }

            int winner = 0;
            if (fighter1.hp <= 0) { winner = 2; } else if (fighter2.hp <= 0) { winner = 1; }
            printResult(fighter1, fighter2, winner);
        }

        public Fight(Puncher fighter1, Puncher fighter2)
        {
            fighter2.name = "Puncher";
            fighter2.name = "Puncher 2";
            Random randomObj = new Random();
            while (true)
            {
                if (fighter1.hp > 0 && fighter2.hp > 0)
                {
                    int attacker = randomObj.Next(1, 3);
                    int attack = randomObj.Next(1, 3);

                    if (attacker == 1)
                    {
                        if (attack == 1)
                        {
                            fighter1.attack(fighter2);
                        }
                        else
                        {
                            fighter1.specialAttack(fighter2);
                        }
                    }
                    else if (attacker == 2)
                    {
                        if (attack == 1)
                        {
                            fighter2.attack(fighter1);
                        }
                        else
                        {
                            fighter2.specialAttack(fighter1);
                        }
                    }

                    printAttack(fighter1, fighter2, attacker, attack);

                }
                else { break; }
            }
            int winner = 0;
            if (fighter1.hp <= 0) { winner = 2; } else if (fighter2.hp <= 0) { winner = 1; }
            printResult(fighter1, fighter2, winner);
        }

        private void printAttack(Fighter fighter1, Fighter fighter2, int attacker, int attack)
        {
            Fighter attckr = fighter1;
            string attck = "";
            if (attacker == 1)
            {
                attckr = fighter1;
            }
            else if (attacker == 2)
            {
                attckr = fighter2;
            }

            if (attack == 1)
            {
                attck = "Standard";
            } else if (attack == 2 && attckr.name.Contains("Kicker"))
            {
                attck = "Kick";
            } else if (attack == 2 && attckr.name.Contains("Puncher"))
            {
                attck = "Punch";
            }

            Console.WriteLine($"\n{attckr.name} does a {attck} attack.");
            Console.WriteLine($"{fighter1.name} is now at {fighter1.hp} and {fighter2.name} is now at {fighter2.hp}.");
        }

        private void printResult(Fighter fighter1, Fighter fighter2, int winner)
        {
            if (fighter2.hp <= 0)
            {
                string winnerName = fighter1.name;
                string loserName = fighter2.name;
                fightWinner = 1;
                fighter1.wins += 1;

                Console.WriteLine($"{loserName} is surrendering. {winnerName} has won the fight!");
                winner = 1;
                
            }
            else if (fighter1.hp <= 0)
            {
                string winnerName = fighter2.name;
                string loserName = fighter1.name;
                fightWinner = 2;
                fighter2.wins += 1;

                Console.WriteLine($"{loserName} is surrendering. {winnerName} has won the fight!");
                winner = 2;
            }
        }
    }

    class Fighter
    {
        // Variables
        public int hp = 100;
        public int dmg = 10;
        public int wins = 0;
        public string name = "Fighter";
        public string attackName = "";
        public int fighterType = 0;

        public Fighter() // Initialization function
        {
            
        }

        public void attack(Fighter enemy) // Takes the enemy object and removes dmg amount of health from the enemies hp.
        {
            enemy.hp -= dmg;
        }
    }

    class Kicker: Fighter // Inherited from fighter class. This is 1 of the 2 versions of the fighter. Has the special attack kick.
    {
        public int footSize = 2;  

        public Kicker()
        {
            name = "Kicker";
            attackName = "Kick";
            fighterType = 1;
        }
        
        public void specialAttack(Fighter enemy)
        {
            enemy.hp -= dmg * footSize;
        }
    }

    class Puncher: Fighter // Inherited from fighter class. This is 1 of the 2 versions of the fighter. Has the special attack punch.
    {
        public int fistSize = 2;

        public Puncher()
        {
            name = "Puncher";
            attackName = "Punch";
            fighterType = 2;
        }

        public void specialAttack(Fighter enemy)
        {
            enemy.hp -= dmg * fistSize;
        }
    }
}