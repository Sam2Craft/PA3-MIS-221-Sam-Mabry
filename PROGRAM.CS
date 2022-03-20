using System;

namespace PA3
{

    class Program
    {
        
        static void Main(string[] args)
        {
        int tokens = 50;
        MainMenu(tokens);
        }


static void MainMenu(int tokens)
{
WinLossCheck(tokens);
System.Console.WriteLine(" 1) Play The Force");
System.Threading.Thread.Sleep(1000);
System.Console.WriteLine(" 2) Play Blasters");
System.Threading.Thread.Sleep(1000);
System.Console.WriteLine(" 3) Check Balance");
System.Threading.Thread.Sleep(1000);
System.Console.WriteLine(" 4) Exit");
System.Threading.Thread.Sleep(1000);
System.Console.Write("Please enter the number associated with your selection:");
MainMenuSelection(tokens);
}
static void WinLossCheck(int tokens)
{
     if (tokens > 0)
                {
                    if (tokens >= 300)
                    {
                        YOUWIN();
                    }
                }

                if (tokens <= 0)
                {
                    YOULOSE();
                }
}
static void YOUWIN()
{
    System.Console.WriteLine("YOU WIN!");
}
static void YOULOSE()
{
    System.Console.WriteLine("YOU LOSE!");
}
static void MainMenuSelection(int tokens)
{
string userInput = Console.ReadLine();
if (userInput == "1")
{
Console.Clear();
TheForceTitleScreen(ref tokens);
}
if(userInput == "2")
{
    Console.Clear();
    BlastersTitleScreen(ref tokens);
}

if (userInput == "3")
{
    Console.Clear();
    ScoreBoard(tokens);
}
if (userInput == "4")
{
    System.Console.WriteLine("Bye!");
}
else
{
    System.Console.WriteLine("Enter a valid number.");
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
    MainMenu(tokens);
}

}
static void ScoreBoard (int tokens)
{
System.Console.WriteLine("Your current Token balance is" + tokens + " Tokens");
System.Console.WriteLine("Press any key to return to menu...");
Console.ReadKey();
Console.Clear();
MainMenu(tokens);

}
static void BlastersTitleScreen( ref int tokens )
{
            System.Console.WriteLine("1) Play Game");
            System.Threading.Thread.Sleep(2000);
            System.Console.WriteLine("2) How to play");
            System.Threading.Thread.Sleep(2000);
            System.Console.WriteLine("3) Return to Main Menu");
            System.Threading.Thread.Sleep(2000);
            Console.Write("Please enter the number associated with you selection...");   
            BlastersMenuSelection(ref tokens );
}
static void TheForceTitleScreen (ref int tokens)
{
 System.Threading.Thread.Sleep(2000);
            System.Console.WriteLine("1) Play Game");
            System.Threading.Thread.Sleep(2000);
            System.Console.WriteLine("2) How to Play");
            System.Threading.Thread.Sleep(2000);
            System.Console.WriteLine("3) Return to Main Menu");
            System.Threading.Thread.Sleep(2000);
            Console.Write("Please enter the number associated with you selection...");
            TheForceMenuSelection(tokens);
}
static void BlastersMenuSelection( ref int tokens)
{
string userInput = Console.ReadLine();
if (userInput == "1")
{
    Console.Clear();
    int BlasterPoints = 15;
    int bet = 0;
    PlayBlasters(ref BlasterPoints, ref tokens, bet);

}
if (userInput == "2")
{
    Console.Clear();
    BlastersHowToPlay();
}
if (userInput == "3")
{
    Console.Clear();
    MainMenu(tokens);
}


}
static void TheForceMenuSelection(int tokens)
{
string userInput = Console.ReadLine();
if (userInput == "1")
{
    Console.Clear ();
    int bet = 0;
    PlayTheForce(ref forcewon, ref forcelost, ref tokens, bet);
}
if (userInput == "2")
{
    TheForceHowToPlay();
}
if (userInput == "3")
{
    MainMenu(tokens);
}
}
static void BlastersHowToPlay()
{
    System.Console.WriteLine("Welcome to Blasters!");
    System.Threading.Thread.Sleep(2000);
    System.Console.WriteLine("In this game, a droid will shoot at you with a  blaster. It is your job to either dodge or deflect the laster to not get hit.");
    System.Threading.Thread.Sleep(2000);
    System.Console.WriteLine("You will start off with 15 points, each time you get hit you lose 5 points.");
    System.Threading.Thread.Sleep(2000);
    System.Console.WriteLine("Upon a succesfull deflection, you earn 10 points.");
    System.Console.WriteLine("For a succesfull dodge, you earn 5.");
    System.Threading.Thread.Sleep(2000);
    System.Console.WriteLine("You will bet your tokens to play.");
    System.Console.WriteLine("A minimum bet of 20 tokens is required.");
    System.Threading.Thread.Sleep(2000);
    System.Console.WriteLine("You win the game ends when you hit 40 points, and double your bet.");
    System.Console.WriteLine("The game ends when you hit 0 points, losing all that you bet.");
    System.Threading.Thread.Sleep(2000);
    System.Console.WriteLine("Press any key to return to the title screen.");
    Console.ReadKey();
    Console.Clear();
    BlastersTitleScreen();
}
static void TheForceHowToPlay()
{
    System.Console.WriteLine("Welcome to The Force!");
    System.Threading.Thread.Sleep(2000);
    System.Console.WriteLine("In this game you will be shown ten cards, with only one being revealed to you in the beginning.");
    System.Threading.Thread.Sleep(2000);
    System.Console.WriteLine("You will then guess if the next card to be shown is: greater than, less than, or equal to, the previous cards.");
    System.Threading.Thread.Sleep(2000);
    System.Console.WriteLine("You must bet your tokens to play.");
    System.Console.WriteLine("Any ammount of tokens is allowed for a valid bet.");
    System.Threading.Thread.Sleep(2000);
    System.Console.WriteLine("You lose your bet if you incorrectly guess a card before reaching five correct guess in a row.");
    System.Console.WriteLine("You break even if you get between 5 and 7 guesses correct in a row. ");
    System.Console.WriteLine("You double your bet if you get between 7 and 10 guesses correct in a row.");
    System.Console.WriteLine("You triple your bet if you correctly guess all ten cards in the sequence.");
    System.Threading.Thread.Sleep(2000);
    System.Console.WriteLine("Press any key to return to the title screen.");
    Console.ReadKey();
    Console.Clear();
    TheForceTitleScreen();    
}
static int PlayBlasters(ref int BlasterPoints, ref int tokens, int bet)
{
PlacebetBlasters(tokens);
while (BlasterPoints <= 40 || BlasterPoints >= 0)
{
System.Console.WriteLine("INCOMING LASER!");
System.Console.WriteLine("Do you...");
System.Console.WriteLine("1) Dodge (50% Success Rate)");
System.Console.WriteLine("2) Deflect (30% Success Rate)");
System.Console.WriteLine("3) Flee (Ends the game early, but you relinquish your gambled tokens.)");
string userInput = Console.ReadLine();

            if (userInput == "1")
            {
            Console.Clear();
            System.Console.WriteLine("You chose...");
            System.Threading.Thread.Sleep(2000);
            //System.Console.WriteLine(DodgeArt);
            System.Threading.Thread.Sleep(2000);
            System.Console.WriteLine("And it...");
            DodgeCheck(ref BlasterPoints);
            PlayBlasters( ref BlasterPoints);
            }

            if (userInput == "2")
            {
            Console.Clear();
            System.Console.WriteLine("You chose...");
            System.Threading.Thread.Sleep(2000);
            //System.Console.WriteLine(DeflectArt);
            System.Threading.Thread.Sleep(2000);
            System.Console.WriteLine("And it...");
            DeflectCheck(ref BlasterPoints);
            PlayBlasters (ref BlasterPoints);
            }

            if (userInput == "3")
            {
            Console.Clear();
            System.Console.WriteLine("You chose...");
            System.Threading.Thread.Sleep(2000);
            //System.Console.WriteLine(FleeArt);
            System.Threading.Thread.Sleep(2000);
            System.Console.WriteLine("And it...");
            Flee(ref tokens, ref updateTokens, ref BlasterPoints);
            }

            else
            {
            System.Console.WriteLine("Invalid Input.");
            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            PlayBlasters( ref BlasterPoints);
            }

}
UpdateTokensBlasters(BlasterPoints, bet);
if (BlasterPoints >= 40)
        {
            System.Console.WriteLine("You Won!");
            System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!"); 
            int userChoice = Console.ReadLine();
            while ((userChoice != "2") || (userChoice != "1"))
            {
                System.Console.WriteLine("Invalid Choice.");
                System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!"); 
                userChoice = Console.ReadLine();
            }
            
            if (userChoice =="1")
            {
                PlayBlasters(ref BlasterPoints);
            }
            if (userChoice =="2")
            {
                MainMenu(tokens);
            }
            
        }
if (BlasterPoints <= 0)
        {
            System.Console.WriteLine("You Lost!");
            System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!"); 
            int userChoice = Console.ReadLine();
            while ((userChoice != "2") || (userChoice != "1"))
            {
                System.Console.WriteLine("Invalid Choice.");
                System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!"); 
                userChoice = Console.ReadLine();
            }
            
            if (userChoice =="1")
            {
                PlayBlasters(ref BlasterPoints);
            }
            if (userChoice =="2")
            {
                MainMenu(tokens);
            }
        }
}
static int DodgeCheck(ref int BlasterPoints)
{
Random rnd = new Random();
int check = rnd.Next(1,3);
if (check == 1)
    {
    //System.Console.WriteLine(Worked); 
    BlasterPoints = BlasterPoints + 5;
    System.Console.WriteLine("You've earned 5 Points!");
    System.Console.WriteLine($"You currently have {BlasterPoints} points!");
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
    
    }

    if (check == 2)
    {
        //System.Console.WriteLine(Failed);
        BlasterPoints = BlasterPoints - 5;
        System.Console.WriteLine("You've lost 5 points!");
        System.Console.WriteLine($"You currently have {BlasterPoints} points!");
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
        
    }
    return BlasterPoints;

}
static int DeflectCheck(ref int BlasterPoints)
{
    Random rnd = new Random();
    int check = rnd.Next(1,11);
    if ((check == 1) || (check == 2) || (check == 3))
    {
    //System.Console.WriteLine(Worked); 
    BlasterPoints = BlasterPoints + 10;
    System.Console.WriteLine("You've earned 10 Points!");
    System.Console.WriteLine($"You currently have {BlasterPoints} points!");
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
    return BlasterPoints;
    }

    else 
    {
        //System.Console.WriteLine(Failed);
        BlasterPoints = BlasterPoints - 5;
        System.Console.WriteLine("You've lost 5 points!");
        System.Console.WriteLine($"You currently have {BlasterPoints} points!");
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
        Console.Clear();
        return BlasterPoints;
    }
}
static int Flee (ref int BlasterPoints)
{
System.Console.WriteLine("You lost all of your points!");
BlasterPoints = BlasterPoints - BlasterPoints;
return BlasterPoints;
}
static int PlacebetBlasters(int tokens)
{
System.Console.WriteLine("Your Token bet must be greater than or equal to 20.");
Console.Write("Please Enter the number associated with your bet:");
bet = int.Parse(Console.ReadLine());
    if ( bet >= 20)
    {
        int Verify = tokens - bet;
        if (Verify <= 0)
        {
            System.Console.WriteLine("This bet value puts you at, or below, 0.");
            System.Console.WriteLine("Press any key to place a new bet...");
            Console.ReadKey();
            Console.Clear();
            PlacebetBlasters(ref tokens);
        }
        else
        {
            System.Console.WriteLine("You bet " + bet + " Tokens.");
            System.Console.WriteLine("This leaves your current balance at " + Verify + " Tokens.");
            System.Console.WriteLine("Press any key to play...");
            Console.ReadKey();
            return bet;
            
        }
    }

    else 
    {
        System.Console.WriteLine("Inavlid bet.");
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey;
        Console.Clear();


    }
    
}
static int UpdateTokensBlasters(int BlasterPoints, int bet, ref int tokens)
{
    if (BlasterPoints >= 40)
        {
            tokens = tokens + bet*2;
            return tokens;
        }

        if (BlasterPoints <= 0)
        {
            tokens = tokens - bet;
        }
        return tokens;
}
static void PlayTheForce (ref int forcewon, ref int forcelost, ref int tokens, int bet)
        {
            const int Total_Cards = 52;
            string [] deck = new string [ Total_Cards];
            int [] deckRef = new int [12];
            TheDeck (deck, deckRef);
            Shuffle (deck, Total_Cards);
            int guesses = 0;
            int missed = 0;
            int i = 0 ;
            while (!KeepGoing (missed, guesses))
            {
                System.Console.WriteLine("The current card is " + deck[i] + "is the next card higher or lower");
                System.Console.WriteLine(guesses);
                string input = Console.ReadLine();
                string guess =  input.ToUpper();
                if (CheckChoice(deck, guess, ref guesses, ref missed, i))
                {
                    i++;
                    guesses++;

                }
            }
                if (guesses == 10)
                {
                    System.Console.WriteLine("You trippled your bet, press any key to continue");
                    tokens = tokens + bet * 3;
                    Console.ReadKey();
                    if (tokens != 0)
                    {
                        ReplayForce (ref forcewon, ref forcelost, ref tokens);
                    }
                }
                if (missed !=0)
                {
                    if (guesses < 5)
                    {
                        System.Console.WriteLine("You lose, press any key to cont.");
                        tokens = tokens - bet;
                        Console.ReadKey();
                        Console.Clear();
                        if (tokens !=0)
                        {
                            ReplayForce (ref forcewon, ref forcelost, ref tokens);
                        }
                    }

                    if (guesses == 5 || guesses == 6)
                    {
                        System.Console.WriteLine("Broke even, press any key to cont. ");
                        tokens = tokens;
                        Console.ReadKey();
                        Console.Clear();
                        if (tokens !=0)
                        {
                            ReplayForce (ref forcewon, ref forcelost, ref tokens);
                        }

                    }
                    if (guesses == 7 || guesses == 8 || guesses == 9)
                    {
                        System.Console.WriteLine("doubled, press any key to cont.");
                        tokens = tokens + bet * 2;
                        Console.ReadKey();
                        Console.Clear();
                         if (tokens !=0 || tokens > 0)
                        {
                            ReplayForce (ref forcewon, ref forcelost, ref tokens);
                        }

                    }


                }





            }
static bool CheckChoice(string [] deck, string guess, ref int guesses, ref int missed, int i)
{
    int current = CurrentCard (deck, i);
    int next = NextCard(deck, i);

    if (guess == "HIGHER")
    {
        if (next > current)
        {


            System.Console.WriteLine("Next card:" + deck[i +1]);
            System.Console.WriteLine("Good Job. Press any key to cont.");
            Console.ReadKey();
            Console.Clear();
            return true;
        }
        else 
        {
            System.Console.WriteLine("Next card:" + deck[i +1]);
            System.Console.WriteLine("Wrong! Press any key to cont. ");
            Console.ReadKey();
            Console.Clear();
            missed++;
            return false;

        }


    }
    if (guess == "LOWER")
    {
        if (next < current)
        {


            System.Console.WriteLine("Next card:" + deck[i +1]);
            System.Console.WriteLine("Good Job. Press any key to cont.");
            Console.ReadKey();
            Console.Clear();
            return true;
        }
        else 
        {
            System.Console.WriteLine("Next card:" + deck[i +1]);
            System.Console.WriteLine("Wrong! Press any key to cont. ");
            Console.ReadKey();
            Console.Clear();
            missed++;
            return false;

        }
    }
    else
    {
        System.Console.WriteLine("Invalid Input. Press any key to cont. ");
       Console.ReadKey();
       Console.Clear();
       return false;
    }
    

}
static int CurrentCard (string [] deck, int i)
{
    if (deck[i].Contains("ace"))
    {
        System.Console.WriteLine("current 1");
        return 1;
    }
    if (deck[i].Contains("two"))
    {
        System.Console.WriteLine("current 2");
        return 2;
    }
    if (deck[i].Contains("three"))
    {
        System.Console.WriteLine("current 3");
        return 3;
    }
    if (deck[i].Contains("four"))
    {
        System.Console.WriteLine("current 4");
        return 4;
    }
    if (deck[i].Contains("five"))
    {
        System.Console.WriteLine("current 5");
        return 5;
    }
    if (deck[i].Contains("six"))
    {
        System.Console.WriteLine("current 6");
        return 6;
    }
    if (deck[i].Contains("seven"))
    {
        System.Console.WriteLine("current 7");
        return 7;
    }
    if (deck[i].Contains("eight"))
    {
        System.Console.WriteLine("current 8");
        return 8;
    }
    if (deck[i].Contains("nine"))
    {
        System.Console.WriteLine("current 9");
        return 9;
    }
    if (deck[i].Contains("ten"))
    {
        System.Console.WriteLine("current 10");
        return 10;
    }
    if (deck[i].Contains("jack"))
    {
        System.Console.WriteLine("current 11");
        return 11;
    }
    if (deck[i].Contains("queen"))
    {
        System.Console.WriteLine("current 12");
        return 12;
    }
    if (deck[i].Contains("king"))
    {
        System.Console.WriteLine("current 13");
        return 13;
    }

}
static void TheDeck (string [] deck, int deckRef)
{
    string [] numbers = { "Ace","2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
    string [] face = {"Spades" , "Hearts", "Clubs", "Diamonds"};
    int count = 0;
    for (int i = 0; i<face.Length; i++)
    {
        for (int j = 0; j < numbers.Length; j++)
        {
            deck[count] = numbers[j] + "of" + suits[i];
            count++;
        }
    }



}
static  void Shuffle (string [ ] deck, int Total_Cards)
{
for (int i; i < deck.Length; i++)
{
Random rnd = new Random();
int Randomize = rnd.Next(Total_Cards);
string temp = deck[i];
deck [i] = deck [j];
deck j = temp;
}
for (int i = 0; i<10; i++)
{
    System.Console.WriteLine(deck[i]);
}
}
static bool KeepGoing(int missed, int guesses)
{
    if (missed != 0 && guesses != 10)
    {
        return true;
    }
    return false;
}





































}
}




