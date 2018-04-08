using System;
namespace CubeField

{
    public class User
    {

        private bool invalidated = true;
        private DateTime gameTime = DateTime.Now;
        private static Random randomNumber = new Random();
        private DateTime scoreTime = DateTime.Now;              //used to add to the score

        //Levels callNewLevel = new Levels();

        //TitleScreen newLevel;       //declare object


        private bool specialLevel = false;

        public int score = 0;



        public bool hitBarrier     //property used to control loop for collision detection
        {
            get;
            set;
        }

        public string response  // y or n to play the game again
        {
            get;
            set;
        }

        Barriers buildBarriers = new Barriers();

        const char toWrite = ' ';


        int x = 40, y = 1;       //positions of the user
        int scoreX = 50, scoreY = 5;   //position of the score count


        int smallBarrierPosition = 0;
        int mediumBarrierPosition = 0;
        int largeBarrierPosition = 0;
        int hitBarrierPosition = 0;

        int checkYCord = 0;






        public void MoveMent()                  //controls user movement in game
        {

            //Console.BackgroundColor = ConsoleColor.White;

            //Console.ForegroundColor = ConsoleColor.Black;

            hitBarrier = false;

            int bXCord = 20;
            int bYCord = 0;
            //int moveDown = 0;


            while (hitBarrier == false)
            {


                ConsoleKeyInfo keyInfo;
                if (Console.KeyAvailable)
                {

                    keyInfo = Console.ReadKey();        //switch statement to control side to side user movements
                    switch (keyInfo.Key)
                    {


                        case ConsoleKey.RightArrow:




                            x++;



                            invalidated = true;
                            break;

                        case ConsoleKey.LeftArrow:


                            if (x > 0)
                            {

                                x--;

                            }


                            invalidated = true;
                            break;

                        case ConsoleKey.S:          //secret level

                            specialLevel = true;
                            break;

                        default:
                            break;

                            //add case for the secret level

                    }

                    WriteMovement(toWrite, x, y);       //display the updated movement
                                                        //buildBarriers.displaySmallBarrier();
                    WriteScore(score, scoreX, scoreY);

                }//end of if statement

                Console.SetCursorPosition(x, Console.CursorTop);

                UpdateGame(bXCord, bYCord);               //might have to change this

                Console.SetCursorPosition(x, Console.CursorTop);
                //bYCord++;

                int smallBarrierPositionRange = smallBarrierPosition + 1;
                int medBarrierPositionRange = mediumBarrierPosition + 2;
                int largeBarrierPositionRange = largeBarrierPosition + 4;




                //code to check collision   
                if ((hitBarrierPosition >= smallBarrierPosition &&
                    hitBarrierPosition <= smallBarrierPositionRange) || 
                    (hitBarrierPosition >= mediumBarrierPosition && 
                     hitBarrierPosition <= medBarrierPositionRange ) ||
                    (hitBarrierPosition >= largeBarrierPosition &&
                     hitBarrierPosition <= largeBarrierPositionRange))
                { //need to fix this

                    //if (checkYCord >= bYCord)           //fix this!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    //{

                        Console.BackgroundColor = ConsoleColor.Red;

                        Console.ForegroundColor = ConsoleColor.Black;
                        System.Threading.Thread.Sleep(1000);
                        
                        hitBarrier = true;          //sets property to true, which stops the loop
                        endGameFunction();      //calls the end game function

                        //if (hitBarrier == false) {

                        //MoveMent();
                        //}
                        //if (hitBarrier == true) {
                        //Console.Clear();
                        //}

                    //}
                }


            }//end of the while loop












        }//end of movement method






        public static void WriteMovement(char toWrite, int x, int y)        //updates the movement
        {



            try
            {
                if (x >= 0 && y >= 0) // 0-based
                {
                    //Console.Clear();
                    Console.SetCursorPosition(x, y);        //updates the position of the cursor
                    Console.Write(toWrite);
                }
            }
            catch (Exception)
            {

            }
        }

        public static void WriteScore(int score, int x, int y)        //prints out the score
        {



            try
            {
                if (x >= 0 && y >= 0) // 0-based
                {
                    //Console.Clear();
                    Console.SetCursorPosition(x, y);        //updates the position of the cursor
                    Console.Write(score);
                }
            }
            catch (Exception)
            {

            }
        }







        private void UpdateGame(int xCord, int yCord)
        {

            int randPosition = randomNumber.Next(1, 70);        //random number for x position
            int hitCheck = randomNumber.Next(1, 70);


            int updateInterval = 450;


            if (specialLevel == false)
            {




                if (DateTime.Now.Subtract(gameTime) >
                   TimeSpan.FromMilliseconds(updateInterval))
                {


                    buildBarriers.displayHitBarrier(xCord, yCord);
                    hitBarrierPosition = hitCheck;
                    Console.SetCursorPosition(hitBarrierPosition, 20);



                    buildBarriers.displaySmallBarrier(xCord - 10, yCord);
                    smallBarrierPosition = randPosition;
                    Console.SetCursorPosition(smallBarrierPosition, 20);

                    buildBarriers.displaySmallBarrier(xCord - 10, yCord);
                    smallBarrierPosition = randPosition;
                    Console.SetCursorPosition(smallBarrierPosition, 20);

                    checkYCord = yCord;

                    buildBarriers.displayMediumBarrier(xCord, yCord);
                    mediumBarrierPosition = randPosition;
                    Console.SetCursorPosition(mediumBarrierPosition, 20);



                    buildBarriers.displayMediumBarrier(xCord, yCord);
                    mediumBarrierPosition = randPosition;
                    Console.SetCursorPosition(mediumBarrierPosition, 20);

                    buildBarriers.displayBigBarrier(xCord, yCord);
                    largeBarrierPosition = randPosition;
                    Console.SetCursorPosition(largeBarrierPosition, 20);

                    buildBarriers.displayBigBarrier(xCord, yCord);
                    largeBarrierPosition = randPosition;
                    Console.SetCursorPosition(largeBarrierPosition, 20);

                   

                    invalidated = true;
                    gameTime = DateTime.Now;


                    Console.SetCursorPosition(randPosition, 5);
                    score += 1;


                    if (score == 15) {

                        Console.WriteLine("Speed UP");
                        //newLevel.levelNumber = 3;
                        //System.Threading.Thread.Sleep(1000);
                        //Console.Clear();
                        //newLevel = new TitleScreen(3);
                        //callNewLevel.BuildMap();

                    }


                }





            }

            else if (specialLevel == true) {                    //this is only activated if the user hits the "s" key for special level


                Barriers changeBarrier = new Barriers();


                //Console.ReadKey();
                       

                Console.BackgroundColor = ConsoleColor.Blue;

                Console.ForegroundColor = ConsoleColor.White;

                if (DateTime.Now.Subtract(gameTime) >
                   TimeSpan.FromMilliseconds(updateInterval))
                {


                    buildBarriers.displayHitBarrier(xCord, yCord);
                    hitBarrierPosition = hitCheck;
                    Console.SetCursorPosition(hitBarrierPosition, 20);



                    buildBarriers.displaySmallBarrier(xCord - 10, yCord);
                    smallBarrierPosition = randPosition;
                    Console.SetCursorPosition(smallBarrierPosition, 20);

                    buildBarriers.displaySmallBarrier(xCord - 10, yCord);
                    smallBarrierPosition = randPosition;
                    Console.SetCursorPosition(smallBarrierPosition, 20);

                    checkYCord = yCord;

                    buildBarriers.displayMediumBarrier(xCord, yCord);
                    mediumBarrierPosition = randPosition;
                    Console.SetCursorPosition(mediumBarrierPosition, 20);



                    buildBarriers.displayMediumBarrier(xCord, yCord);
                    mediumBarrierPosition = randPosition;
                    Console.SetCursorPosition(mediumBarrierPosition, 20);

                    buildBarriers.displayBigBarrier(xCord, yCord);
                    largeBarrierPosition = randPosition;
                    Console.SetCursorPosition(largeBarrierPosition, 20);

                    buildBarriers.displayBigBarrier(xCord, yCord);
                    largeBarrierPosition = randPosition;
                    Console.SetCursorPosition(largeBarrierPosition, 20);



                    invalidated = true;
                    gameTime = DateTime.Now;


                    Console.SetCursorPosition(randPosition, 5);
                }




            }

        }//end of UpdateGame method



        private void RenderOutput()
        {

            if (invalidated)
            {

                Console.Clear();

            }

        }


        private void endGameFunction()
        {

            Console.Clear();
            Console.SetCursorPosition(30, 5);
            Console.WriteLine("You ran into the barrier!");
            Console.WriteLine("You lost!");
            Console.WriteLine("Would you like to play again? (y) (n) : ");
            response = Console.ReadLine();

            if (response == "y" || response == "Y")
            {
                Console.BackgroundColor = ConsoleColor.White;
                hitBarrier = false;
                //MoveMent();


            }
            else if (response == "n" || response == "N")
            {
                Console.BackgroundColor = ConsoleColor.White;
                hitBarrier = true;
                Console.Clear();

            }
            else {
                Console.BackgroundColor = ConsoleColor.White;
                hitBarrier = true;
                Console.Clear();
            }


        }







    }
}