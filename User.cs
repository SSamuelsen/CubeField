using System;
namespace CubeField

{
    public class User
    {

        private bool invalidated = true;
        private DateTime gameTime = DateTime.Now;
        private static Random randomNumber = new Random();



       
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


        int x = 40, y = 5 ;       //positions of the user

        int smallBarrierPosition = 0;
        int mediumBarrierPosition = 0;
        int largeBarrierPosition = 0;


        public void MoveMent()
        {
            hitBarrier = false;

            int bXCord = 20;
            int bYCord = 0;
            //int moveDown = 0;


            while (hitBarrier == false) { 


            ConsoleKeyInfo keyInfo;
            if (Console.KeyAvailable)
            {

                keyInfo = Console.ReadKey();
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

                    default:
                        break;

                        //add case for the secret level

                }

                    WriteMovement(toWrite, x, y);       //display the updated movement
                    //buildBarriers.displaySmallBarrier();

            }//end of if statement

                UpdateGame(bXCord,bYCord);               //might have to change this
                Console.SetCursorPosition(x, Console.CursorTop);
                //bYCord++;



                //code to check collision   FIX THIS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                if((x == smallBarrierPosition)||(x == mediumBarrierPosition)||(x == largeBarrierPosition+5)) { //need to fix this

                    hitBarrier = true;          //sets property to true, which stops the loop
                    endGameFunction();      //calls the end game function

                    //if (hitBarrier == false) {

                        //MoveMent();
                    //}
                    //if (hitBarrier == true) {
                        //Console.Clear();
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









        private void UpdateGame(int xCord, int yCord) {

            int randPosition = randomNumber.Next(1, 70);        //random number for x position

            int updateInterval = 200;




            if(DateTime.Now.Subtract(gameTime) > 
               TimeSpan.FromMilliseconds(updateInterval)){

                buildBarriers.displaySmallBarrier(xCord-10,yCord);
                smallBarrierPosition = randPosition;
                Console.SetCursorPosition(smallBarrierPosition, 20);



                buildBarriers.displayMediumBarrier(xCord,yCord);
                mediumBarrierPosition = randPosition;
                Console.SetCursorPosition(mediumBarrierPosition, 20);


                buildBarriers.displayBigBarrier(xCord+10, yCord);
                largeBarrierPosition = randPosition;
                Console.SetCursorPosition(largeBarrierPosition, 20);



                invalidated = true;
                gameTime = DateTime.Now;


                Console.SetCursorPosition(randPosition, 5);
            }

        }//end of UpdateGame method



        private void RenderOutput() {

            if (invalidated) {

                Console.Clear();

            }

        }


        private void endGameFunction() {

            Console.Clear();
            Console.SetCursorPosition(30, 5);
            Console.WriteLine("You lost!");
            Console.WriteLine("Would you like to play again? (y) (n) : ");
            response = Console.ReadLine();

            if (response == "y" || response == "Y"){
                
                hitBarrier = false;
                //MoveMent();


            }
            if (response == "n" || response == "N")
            {
                hitBarrier = true;
                Console.Clear();

            }



        }







    }
}
