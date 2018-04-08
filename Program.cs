using System;

namespace CubeField
{
    class MainClass
    {
        public static void Main(string[] args)
        {

          


            //creating all necessary objects
            TitleScreen displayTitle = new TitleScreen(1);
            User loadUser = new User();
            Levels buildLevel = new Levels();
            Barriers showBarrier = new Barriers();

            //Console.SetCursorPosition(20, 5);

            //showBarrier.displayBigBarrier(20, 5);


            //calling all methods to run the game
            displayTitle.Display();      
            Console.Clear();
            loadUser.MoveMent();
            buildLevel.BuildMap();      //runs the first level

            if (loadUser.hitBarrier == false){
                buildLevel.BuildMap();
            }






        }
    }
}
