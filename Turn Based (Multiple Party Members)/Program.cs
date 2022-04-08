using System;

namespace TurnBased
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 80;
            int player2Health = 10;
            int enemyHealth = 100;
            int playerDamage = new Random().Next(3, 8);

            while (playerHealth > 0 && enemyHealth > 0 && player2Health > 0)
            {

                Console.WriteLine("The player has " + playerHealth + " HP");
                Console.WriteLine("The 2nd player has " + player2Health + " HP");
                Console.WriteLine("The enemy has " + enemyHealth + " HP");
                Console.WriteLine("Write 'attack' to attack the enemy, 'heal' to heal yourself, 'buff' to increase attack, or 'block' to block an enemy attack");

                //Get the player's choice
                string choice = Console.ReadLine();
             
                int enemyDamage = new Random().Next(1, 5);
                int enemyHeal = new Random().Next(1, 5); //how much of the enemy's health is healed.
                int playerHeal = new Random().Next(2, 6); //how much of the player's health is healed.
                int player2Heal = new Random().Next(2, 6);
                
                Console.WriteLine("What should the 2nd player do?");

                string choice2 = Console.ReadLine();
                

                //process player action
                if (choice == "attack")
                {
                    //if the player attacks
                    Console.WriteLine("You attacked for " + playerDamage + " damage!");
                    enemyHealth -= playerDamage;
                    Console.WriteLine("The enemy attacked for " + enemyDamage + " damage!");
                    playerHealth -= enemyDamage;

                }

                if (choice2 == "attack")
                {
                    //if the player attacks
                    Console.WriteLine("Player2 also attacked for 2 damage!");
                    enemyHealth -= 2;
                    Console.WriteLine("The enemy attacked for " + enemyDamage + " damage against Player2!!");
                    player2Health -= enemyDamage;

                }


                if (choice == "heal")
                {

                    Console.WriteLine("You healed for " + playerHeal + " HP!");
                    playerHealth += playerHeal;

                    Console.WriteLine("The ENEMY also healed for " + enemyHeal + " HP!!");
                    enemyHealth += enemyHeal;

                }

                if (choice2 == "heal")
                {

                    Console.WriteLine("Player2 healed for " + playerHeal + " HP!");
                    player2Health += player2Heal;

                }


                if (choice == "block")
                {
                    Console.WriteLine("You blocked against the attack!");
                    Console.WriteLine("The enemy dealt " + enemyDamage / 2 + " damage!!");
                    playerHealth -= (enemyDamage) / 2;
                }

                if (choice2 == "block")
                {
                    Console.WriteLine("Player 2 blocked against the attack!");
                    Console.WriteLine("The enemy dealt " + enemyDamage / 2 + " damage against Player2!!");
                    player2Health -= (enemyDamage) / 2;
                }


                if (choice == "buff")
                {
                    //if the player attacks
                    Console.WriteLine("You buffed your attack!");
                    playerDamage *= 2 ;
                    Console.WriteLine("The enemy attacked for " + enemyDamage + " damage!");
                    playerHealth -= enemyDamage;

                }

                if (playerHealth <= 0)
                {
                    Console.WriteLine("You have lost...");
                }


                if (player2Health <= 0)
                {
                    Console.WriteLine("Player 2 is dead...");
                }


                if (enemyHealth <= 0)
                {
                    Console.WriteLine("You have WON!!");

                }

                if (playerHealth <= 0 && enemyHealth <= 0)
                {
                    Console.WriteLine("Therefore it's a Stalemate");
                }

            }
        }
    }
}

