using System;
namespace CubeField
{


    public class Levels
    {

        public TitleScreen level;

        TitleScreen getLevel = new TitleScreen(2);
        User detectMovement = new User();
        Barriers showBarriers = new Barriers();
       




        public void BuildMap()
        {                        //builds the widewalls for the game


            if (getLevel.levelNumber == 2) {

                detectMovement.MoveMent();      //calls the movement method to display the userCharacter

                //System.Threading.Thread.Sleep(100);

                //showBarriers.displaySmallBarrier();

                //System.Threading.Thread.Sleep(100);



            }

            if (getLevel.levelNumber == 3) {

                //detectMovement.MoveMent();

            }











        }//ending of build map function




    }
}
