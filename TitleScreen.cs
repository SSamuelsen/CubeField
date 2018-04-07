using System;
namespace CubeField
{
    public class TitleScreen
    {




        public int levelNumber
        {
            get;
            set;
        }








        int barrierNumber1;       //used to place barrier in array
        int barrierNumber2;








        public string BuildBarrier(int LevelNumber)
        {

            levelNumber = LevelNumber;

            int numberOfBarriers;

            //creating that array that will output the map




            if (LevelNumber == 1)
            {               //setting number of barriers depending on level #
                numberOfBarriers = 30;
                string[,] barrierArray = new string[numberOfBarriers, 50];  // rows,  columns

                for (int x = 1; x < numberOfBarriers - 1; x++)      //looping through each row in thr map
                {
                    //random number generator 
                    //https://stackoverflow.com/questions/17961700/random-number-generator-between-0-1000-in-c-sharp
                    int RandomNumber()
                    {


                        Random randomNumber = new Random();
                        //barrierNumber1 = Convert.ToInt32(randomNumber);
                        barrierNumber1 = randomNumber.Next(0, 49);
                        return 0;
                        //getting random number between 1 and number of barriers 

                    }
                    int RandomNumber2()
                    {


                        Random randomNumber = new Random();
                        //barrierNumber2 = Convert.ToInt32(randomNumber);
                        barrierNumber2 = randomNumber.Next(0, 49);
                        return 0;
                        //getting random number between 1 and number of barriers 

                    }

                    RandomNumber();     //calling random number functions
                    RandomNumber2();

                    for (int y = 0; y < 50; y++)
                    {
                        barrierArray[x, y] = " ";
                    }



                    barrierArray[x, barrierNumber1] = "[]";          //x is being incremented by 1 for each row in array
                    barrierArray[x, barrierNumber2] = "[]";
                    //Console.Write(barrierArray[x, barrierNumber1]);

                    foreach (var item in barrierArray)  //prints through each item in the arry
                    {
                        Console.Write(item);
                        System.Threading.Thread.Sleep(0);        //pause for .1 second
                        //Console.WriteLine();
                    }




                    //Console.WriteLine(barrierArray[x, barrierNumber2]);


                }


                string welcome = ("Welcome to CubeField!");     //used to hold welcome text
                string pressEnter = ("Press Enter to Play");

               

                //https://stackoverflow.com/questions/21917203/how-do-i-center-text-in-a-console-application
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (welcome.Length / 2)) + "}", welcome));
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (pressEnter.Length / 2)) + "}", pressEnter));
                //apparently .WindowWidth does not work on mac, gave me warning
                //used to center the text horizontally in the console window

                //Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);

                Console.ReadLine();
            }
















            return null;            //change this once I have made my code

        }   // end of build barrier function




        public void Display()
        {

            BuildBarrier(1);

        }





        public TitleScreen (int LevelNumber) {

            levelNumber = LevelNumber;

        }






    }
}
