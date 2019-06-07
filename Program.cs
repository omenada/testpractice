using System;

namespace Console_Arrary
{
    class Program
    {
        static void Main()
        {
            //question 1 - greatest value
            //greatestValue();

            //question 2 - calculate Score
            // calculateScore();

            //question 3 - counter String
            //counterString();

            //question 4 - printCharacters
            printCharacters();

            //question 5 - printNumberSpaces
            //printNumberSpaces();
                       
        }


        static void greatestValue()
        {

            int num1;
            int num2;
            int num3;

            Console.WriteLine("Please enter your First Value");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your Second Value");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your Third Value");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest. ");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest . ");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest  ");
            else
                Console.Write("The 3rd Number is the greatest  ");
        }



        static void calculateScore()
        {
            int quizScore = 0;
            int midtermScore = 0;
            int FinalScore = 0;


            Console.WriteLine("Please enter your quizScore");
            quizScore = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your midtermScore");
            midtermScore = int.Parse(Console.ReadLine());

            FinalScore = (quizScore * midtermScore / 2);

            if (FinalScore == 90)
            {
                Console.WriteLine("Your grade is A, Your Score is =" + FinalScore);

            }
            if ((FinalScore >= 70) && (FinalScore < 90))
            {
                Console.WriteLine("Your grade is B , Your Score is =" + FinalScore);

            }

            if ((FinalScore >= 50) && (FinalScore < 70))
            {

                Console.WriteLine("Your grade is C , Your Score is =" + FinalScore);
            }


            if (FinalScore < 50)
            {

                Console.WriteLine("Your grade is F,  Your Score is =" + FinalScore);
            }


        }

        static void counterString()
        {
            int num1;

            int count = 0;


            Console.WriteLine("Please enter your Value");
            num1 = int.Parse(Console.ReadLine());

            while (num1 != 0)
            {

                num1 = num1 / 10;
                count++;

            }

            Console.WriteLine("The number of digits is :" + count);
        }

        static void printCharacters()
        {
            


              

            //for (int i = 0; i <= 10; i++)

            //{
            //    System.Console.WriteLine("{0} = {1}", i, (char)i);

            //}




        }

        static void printNumberSpaces()
        {



        } 

        


    }

    

}
