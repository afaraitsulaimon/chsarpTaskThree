using System;

namespace csharpTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            //secret number to guess for Easy, medium and hard
            int easySecretNumber = 3;
            int mediumSecretNumber = 18;
            int hardSecretNumber = 20;

            int userGuessedNo = 0;
            int timesGuessed = 0;
            
            // Number of times the users can guess for each level
            int easyGuessLimit = 6;
            int mediumGuessLimit = 4;
            int hardGuessLimit = 3;

            string gameLevel = "";

            

            Console.WriteLine("Welcome to your favourite guessing game");
            Console.Write("Select your game level (Easy , Medium or Hard) :");

            gameLevel = Console.ReadLine();


             if (gameLevel == "Easy")
            {
                Console.WriteLine("Welcome to Easy Level!!");
                Console.WriteLine("Guess between 1 to 10 and You have only 6 chances of guessing");
                // check if the user has not gotten the secret number
                //keep allowing the user to try,until the user gets to the limit guess which is 6
                // but if the user gets the secret number, display "Yes!!!,You got it right"
                while (userGuessedNo != easySecretNumber)
                {
                    if (timesGuessed < easyGuessLimit)
                    {
                        Console.Write("Guess the secret number:");
                        userGuessedNo = int.Parse(Console.ReadLine());
                        timesGuessed++;

                        //checking if the user has not gotten to the limit of guessing
                        //and has not gotten the secret number
                        // then display "Wrong Answer, Try again" before you allow them try again
                        if (timesGuessed < easyGuessLimit && userGuessedNo != easySecretNumber){

                            Console.WriteLine("Wrong Answer, Try again");
                              
                        }

                        // if the user has exceeded the limit
                        // and didn't get the answer, then dsplay "Game Over, Try again Later"
                    }else if(timesGuessed == easyGuessLimit && userGuessedNo != easySecretNumber)
                    {
                               Console.WriteLine("Game Over, Try again Later");
                               break;
                        
                    }

                }if(timesGuessed < easyGuessLimit && userGuessedNo == easySecretNumber){

                   Console.WriteLine("Yes!!!,You got it right");
                }
                
            }

            // checking if the user select medium level
            else if (gameLevel == "Medium")
            {
                Console.WriteLine("Welcome to Medium Level!!");
                Console.WriteLine("Guess between 1 to 20 and You have only 4 chances of guessing");
                // check if the user has not gotten the secret number
                //keep allowing the user to try,until the user gets to the limit guess which is 4
                // but if the user gets the secret number, display "Yes!!!,You got it right"
                while (userGuessedNo != mediumSecretNumber)
                {
                    if (timesGuessed < mediumGuessLimit)
                    {
                        Console.Write("Guess the secret number:");
                        userGuessedNo = int.Parse(Console.ReadLine());
                        timesGuessed++;

                         if (timesGuessed < mediumGuessLimit && userGuessedNo != mediumSecretNumber){

                            Console.WriteLine("Wrong Answer, Try again");
                              
                        }
                        
                    }else if(timesGuessed == mediumGuessLimit && userGuessedNo != mediumSecretNumber)
                    {
                               Console.WriteLine("Game Over, Try again Later");
                               break;
                        
                    }

                }if(timesGuessed < mediumGuessLimit && userGuessedNo == mediumSecretNumber){

                   Console.WriteLine("Yes!!!,You got it right");
                }
            }

            // checking if the user select Hard level
            else if (gameLevel == "Hard")
            {
                Console.WriteLine("Welcome to Hard Level!!");
                Console.WriteLine("Guess between 1 to 50 and You have only 3 chances of guessing");
                // check if the user has not gotten the secret number
                //keep allowing the user to try,until the user gets to the limit guess which is 3
                // but if the user gets the secret number, display "Yes!!!,You got it right"
                while (userGuessedNo != hardSecretNumber)
                {
                    if (timesGuessed < hardGuessLimit)
                    {
                        Console.Write("Guess the secret number:");
                        userGuessedNo = int.Parse(Console.ReadLine());
                        timesGuessed++;

                         if (timesGuessed < hardGuessLimit && userGuessedNo != hardSecretNumber){

                            Console.WriteLine("Wrong Answer, Try again");
                              
                        }
                        
                    }
                    
                      else if(timesGuessed == hardGuessLimit && userGuessedNo != hardSecretNumber)
                    {
                               Console.WriteLine("Game Over, Try again Later");
                               break;
                        
                    }

                }if(timesGuessed < hardGuessLimit && userGuessedNo == hardSecretNumber){

                   Console.WriteLine("Yes!!!,You got it right");
                }
            }

              

        }
    }
}
