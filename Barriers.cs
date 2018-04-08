using System;
namespace CubeField
{
    public class Barriers
    {

        public string[,] smallBarrier = new string[2, 2] { { "", "" }, { "", "" } };
        public string[,] mediumBarrier = new string[3, 3] { { "", "", "" }, { "", "", "" }, { "", "", "" } };
        public string[,] bigBarrier = new string[5, 5] { { "*", "*", "*", "*", "*" }, { "*", "*", "*", "*", "*" }, { "*", "*", "*", "*", "*" }, { "*", "*", "*", "*", "*" }, { "*", "*", "*", "*", "*" } };
        public string[] hitBarrier = new string[5] {  "{", "|", "|", "|", "}" };        //barrier that will be used to check if hit 


        public string[,] specialBarrier = new string[2,2] { { "^", "^" }, { "^", "^" } };





        public void displaySmallBarrier(int x, int y)
        {







            int rowLength = smallBarrier.GetLength(0);
            int colLength = smallBarrier.GetLength(1);


            for (int i = 0; i < rowLength; i++)
            {

                for (int j = 0; j < colLength; j++)
                {

                    //Console.SetCursorPosition(x, y);
                    Console.Write(bigBarrier[i, j] + " ");


                }
                Console.WriteLine();
                //Console.Write(Environment.NewLine + Environment.NewLine);

            }

            //System.Threading.Thread.Sleep(1000); //wait for 1 second





        } //end of thr displayBarrier method


        public void displayMediumBarrier(int x, int y)
        {







            int rowLength = mediumBarrier.GetLength(0);
            int colLength = mediumBarrier.GetLength(1);


            for (int i = 0; i < rowLength; i++)
            {

                for (int j = 0; j < colLength; j++)
                {

                    //Console.SetCursorPosition(x, y);
                    Console.Write(bigBarrier[i, j] + " ");


                }
                Console.WriteLine();
                //Console.Write(Environment.NewLine + Environment.NewLine);

            }

            //System.Threading.Thread.Sleep(1000); //wait for 1 second





        } //end of the displayBarrier method



        public void displayBigBarrier(int x, int y)
        {







            int rowLength = bigBarrier.GetLength(0);
            int colLength = bigBarrier.GetLength(1);


            for (int i = 0; i < rowLength; i++)
            {

                for (int j = 0; j < colLength; j++)
                {

                    //Console.SetCursorPosition(x, y);
                    Console.Write(bigBarrier[i, j] + " ");


                }

                Console.WriteLine();
                //Console.Write(Environment.NewLine + Environment.NewLine);

            }

            //System.Threading.Thread.Sleep(1000); //wait for 1 second





        } //end of thr displayBarrier method

        public void displayHitBarrier(int x, int y)
        {


            foreach(var barrier in hitBarrier){
                Console.Write(barrier);
            }

            //System.Threading.Thread.Sleep(1000); //wait for 1 second





        } //end of thr displayBarrier method





    }
}