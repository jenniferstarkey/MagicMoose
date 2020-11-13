using System;

namespace MagicMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Magic Moose!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            MooseSays("Ask me anything!");
            Question();


        }
        static void Question()
        {
            string question = Console.ReadLine();
            if (question != "")
            {
                RandomGen();
            }
        }

        //random gen
        static void RandomGen()
        {
            Random r = new Random();
            int genRand = r.Next(1, 20);
            MooseAnswer(genRand);

        }
        //answers for number gen
        static void MooseAnswer(int number)
        {

            if (number == 1)
            {
                Console.WriteLine("As I see it, yes.");
            }
            if (number == 2)
            {
                Console.WriteLine("Ask again later.");
            }
            if (number == 3)
            {
                Console.WriteLine("Better not tell you now.");
            }
            if (number == 4)
            {
                Console.WriteLine("Cannot predict now.");
            }
            if (number == 5)
            {
                Console.WriteLine("Concentrate and ask again");
            }
            if (number == 6)
            {
                Console.WriteLine("Don’t count on it");
            }
            if (number == 7)
            {
                Console.WriteLine("It is certain.");
            }
            if (number == 8)
            {
                Console.WriteLine("It is decidedly so");
            }
            if (number == 9)
            {
                Console.WriteLine("Most likely");
            }
            if (number == 10)
            {
                Console.WriteLine("My reply is no.");
            }
            if (number == 11)
            {
                Console.WriteLine("My sources say no.");
            }
            if (number == 12)
            {
                Console.WriteLine("Outlook not so good.");
            }
            if (number == 13)
            {
                Console.WriteLine("Outlook good.");
            }
            if (number == 14)
            {
                Console.WriteLine("Reply hazy, try again.");
            }
            if (number == 15)
            {
                Console.WriteLine("Signs point to yes.");
            }
            if (number == 16)
            {
                Console.WriteLine("Very doubtful.");
            }
            if (number == 17)
            {
                Console.WriteLine("Without a doubt.");
            }
            if (number == 18)
            {
                Console.WriteLine("Yes.");
            }
            if (number == 19)
            {
                Console.WriteLine("Yes – definitely.");
            }
            if (number == 20)
            {
                Console.WriteLine("You may rely on it.");
            }
            // /user question


        }

        static void MooseSays(string message)
        {
            Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |   {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");


        }
    }
}
