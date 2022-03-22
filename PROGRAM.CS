using System;

namespace TSTTST
{
    class Program
    {
        static void Main(string[] args)
        {
            int tokens = 300;
            HelloLuke();
            MainMenu(tokens);
        }
        //*******PLEASE RUN THE PROGRAM IN CMD WHILE IN FULLSCREEN FOR PROPER EXPERIENCE**********
        // Here's an easy to access list of what I consider to be my extras (TA Andrews idea, thanks Andrew!)
        // Art and Graphics for nearly all games/screens the user interacts with.
        //Colored graphics through console commands
        // Use of delayed text display to enhance user experience
        // Cool introduction to the program
        //The Blasters game has  animation
        //Each method is throughly documented with comments
        //Indepth test logs, testing specific aspects of methods or games
        // Code is well strucuted and organized
        // substantial use of parrallel arrays to assign card graphics to each possible card in a deck.
        // Practical use of a route within the program. Through the Main menu method. 


        static void HelloLuke()// This method has the introductory titlescreen and brief hello to the user (Luke)
        {
            System.Console.WriteLine("Luke I know you miss Yoda");
            System.Threading.Thread.Sleep(4000); // This command delays when subsequent writelines are displayed. This is used extensively throughout the code.
            System.Console.WriteLine("So I made you something!");
            System.Threading.Thread.Sleep(4000);
            string YodaArt = @" 
                                                                               ____
                                                                            _.' :  `._
                                                                        .-.'`.  ;   .'`.-.
                                                                __      / : ___\ ;  /___ ; \      __
                                                            ,'_ ''--.:__;'.-.';: :'.-.':__;.--'' _`,
                                                            :' `.t''--.. '<@.`;_  ',@>` ..--''j.' `;
                                                                `:-.._J '-.-'L__ `-- ' L_..-;'
                                                                    '-.__ ;  .-'  '-.  : __.-'
                                                                        L ' /.------.\ ' J
                                                                        '-.   '--'   .-'
                                                                        __.l'-:_JL_;-';.__
                                                                    .-j/'.;  ;''''  / .'\'-.
                                                                    .' /:`. '-.:     .-' .';  `.
                                                                .-'  / ;  '-. '-..-' .-'  :    '-.
                                                            .+'-.  : :      '-.__.-'      ;-._   \
                                                            ; \  `.; ;                    : : '+. ;
                                                            :  ;   ; ;                    : ;  : \:
                                                            : `.'-; ;  ;                  :  ;   ,/;
                                                            ;    -: ;  :                ;  : .-''  :
                                                            :\     \  : ;             : \.-'      :
                                                            ;`.    \  ; :            ;.'_..--  / ;
                                                            :  '-.  '-:  ;          :/.'      .'  :
                                                                \       .-`.\        /t-''  ':-+.   :
                                                                `.  .-'    `l    __/ /`. :  ; ; \  ;
                                                                    \   .-' .-'-.-'  .' .'j \  /   ;/
                                                                    \ / .-'   /.     .'.' ;_:'    ;
                                                                    :-''-.`./-.'     /    `.___.'
                                                                            \ `t  ._  /  
                                                                            '-.t-._:'
                                                                        ";
            string WelcomeToArt = @"

     _______.  ______     ____    __    ____  _______  __        ______   ______   .___  ___.  _______    .___________.  ______                     
    /       | /  __  \    \   \  /  \  /   / |   ____||  |      /      | /  __  \  |   \/   | |   ____|   |           | /  __  \                    
   |   (----`|  |  |  |    \   \/    \/   /  |  |__   |  |     |  ,----'|  |  |  | |  \  /  | |  |__      `---|  |----`|  |  |  |                   
    \   \    |  |  |  |     \            /   |   __|  |  |     |  |     |  |  |  | |  |\/|  | |   __|         |  |     |  |  |  |                   
.----)   |   |  `--'  |      \    /\    /    |  |____ |  `----.|  `----.|  `--'  | |  |  |  | |  |____        |  |     |  `--'  |  __     __     __ 
|_______/     \______/        \__/  \__/     |_______||_______| \______| \______/  |__|  |__| |_______|       |__|      \______/  (__)   (__)   (__)
                                                                                                                                                    
            ";
            string YodaTerminalArt = @"

____    ____  ______    _______       ___    __     _______.     _______      ___      .___  ___.  _______    .___________. _______ .______      .___  ___.  __  .__   __.      ___       __      
\   \  /   / /  __  \  |       \     /   \  (_ )   /       |    /  _____|    /   \     |   \/   | |   ____|   |           ||   ____||   _  \     |   \/   | |  | |  \ |  |     /   \     |  |     
 \   \/   / |  |  |  | |  .--.  |   /  ^  \  |/   |   (----`   |  |  __     /  ^  \    |  \  /  | |  |__      `---|  |----`|  |__   |  |_)  |    |  \  /  | |  | |   \|  |    /  ^  \    |  |     
  \_    _/  |  |  |  | |  |  |  |  /  /_\  \       \   \       |  | |_ |   /  /_\  \   |  |\/|  | |   __|         |  |     |   __|  |      /     |  |\/|  | |  | |  . `  |   /  /_\  \   |  |     
    |  |    |  `--'  | |  '--'  | /  _____  \  .----)   |      |  |__| |  /  _____  \  |  |  |  | |  |____        |  |     |  |____ |  |\  \----.|  |  |  | |  | |  |\   |  /  _____  \  |  `----.
    |__|     \______/  |_______/ /__/     \__\ |_______/        \______| /__/     \__\ |__|  |__| |_______|       |__|     |_______|| _| `._____||__|  |__| |__| |__| \__| /__/     \__\ |_______|
                                                                                                                                                                                                
            ";
            System.Console.Write(WelcomeToArt);
            System.Threading.Thread.Sleep(4000);
            Console.ForegroundColor = ConsoleColor.Green; // This colors yoda to be green. You will see this used a lot throughout the code.
            System.Console.WriteLine(YodaArt);
            Console.ResetColor(); // This resets the color of the next text to be displayed to be the generic white. You will see this used a lot throughout the code.
            System.Console.WriteLine(YodaTerminalArt);
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("Yoda art by:  Blazej Kozlowski & Faux_Pseudo");
            System.Console.WriteLine("Program Created by: Sam Mabry 2022");
            System.Threading.Thread.Sleep(2000);
            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
        static void MainMenu(int tokens) // This effectively is my route method, every method below is reachable from this method, and every method below has a path to be able to return to this method.
        {
            WinLossCheck(ref tokens);
            if (tokens == -1)
            {

            }
            string MainMenuArt = @"
   	       __																    	                                                           
.-.__      \ .-.  ___  __														                                                           
|_|  '--.-.-(   \/\;;\_\.-._______.-.													                                                  
(-)___     \ \ .-\ \;;\(   \       \ \		.___  ___.      ___       __  .__   __.   .___  ___.  _______ .__   __.  __    __              
 Y    '---._\_((Q)) \;;\\ .-\     __(_)		|   \/   |     /   \     |  | |  \ |  |   |   \/   | |   ____||  \ |  | |  |  |  |           
 I           __'-' / .--.((Q))---'    \,	|  \  /  |    /  ^  \    |  | |   \|  |   |  \  /  | |  |__   |   \|  | |  |  |  |          
 I     ___.-:    \|  |   \'-'_          \	|  |\/|  |   /  /_\  \   |  | |  . `  |   |  |\/|  | |   __|  |  . `  | |  |  |  |          
 A  .-'      \ .-.\   \   \ \ '--.__     '\	|  |  |  |  /  _____  \  |  | |  |\   |   |  |  |  | |  |____ |  |\   | |  `--'  |    	     
 |  |____.----((Q))\   \__|--\_      \     '    |__|  |__| /__/     \__\ |__| |__| \__|   |__|  |__| |_______||__| \__|  \______/             
    ( )        '-'  \_  :  \-' '--.___\          												                                             
     Y                \  \  \       \(_)         												                                             
     I                 \  \  \         \,         												                                             
     I                  \  \  \          \          												                                         
     A                   \  \  \          '\          												                                         
     |                    \  \__|           '     											                                                 
                           \_:.  \          													                                             
                             \ \  \         													                                             
                              \ \  \        												                                             	
                               \_\_|    												                                                   
            ";
            string DividerArt = @"                                                                                                                      
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|
                                                                                                                        
            ";
            System.Console.WriteLine(MainMenuArt);
            System.Console.WriteLine("Art by Shanaka Dias and Rowan Crawford.");
            System.Console.WriteLine(DividerArt);
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
        static void WinLossCheck(ref int tokens) // This checks if the user has won or lost the entire program. This method is called several time below, typically after each round of a game or upon returning to the main menu.
        {
            if (tokens > 0)
            {
                if (tokens >= 300)
                {
                    YOUWIN();
                    Environment.Exit(0);// This method force the program to quit. This is the only method that contains this.
                }
            }

            if (tokens <= 0)
            {
                YOULOSE();
                Environment.Exit(0);
            }
        }
        static void YOUWIN() // This is the artwork associated with the condition if the user has won the entire program.
        {
            string YouWinArt = @"  
____    ____  ______    __    __     ____    __    ____  __  .__   __.  __   __   __  
\   \  /   / /  __  \  |  |  |  |    \   \  /  \  /   / |  | |  \ |  | |  | |  | |  | 
 \   \/   / |  |  |  | |  |  |  |     \   \/    \/   /  |  | |   \|  | |  | |  | |  | 
  \_    _/  |  |  |  | |  |  |  |      \            /   |  | |  . `  | |  | |  | |  | 
    |  |    |  `--'  | |  `--'  |       \    /\    /    |  | |  |\   | |__| |__| |__| 
    |__|     \______/   \______/         \__/  \__/     |__| |__| \__| (__) (__) (__) 
                                                                                      ";

            string LukeArt = @"
           ___      |\________/)
          [_,_])    \ /       \|
         /|=T=|]     /   __  __\
         |\ ' //     |_  9   p ]\
         ||'-'/--.  / /\ =|  \|\ \
        /|| <\/> |\ | '._, @ @)<_)
       | |\   |  |   \.__/(_;_)
       |  .   H  |   |  :  '='|
       |  |  _H__/  _| :      |
        \  '.__  \ /  ;      ';
       __'-._(_}==.'  :       ;
      (___|    /-' |   :.     :
     [.-'  \   |   \   \ ;   :
    .-'     |  |    |  |   ':
   /        |==|     \  \  /  \_
  /         [  |      '._\_ -._ \
 /           \__)   __.- \ \   )\\
/       |        /.'      >>)
|        \       |\     |
|     .'  '-.    | \    /
|    /     /     / /   /
           |    /
                 ";

            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.Write(YouWinArt);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(LukeArt);
            Console.ResetColor();
            System.Console.WriteLine("Art by Shanaka Dias");
        }
        static void YOULOSE() //This is the artwork associated with the condition if the user has won the entire program.
        {
            string YouLoseArt = @"
____    ____  ______    __    __      __        ______        _______. _______  __  
\   \  /   / /  __  \  |  |  |  |    |  |      /  __  \      /       ||   ____||  | 
 \   \/   / |  |  |  | |  |  |  |    |  |     |  |  |  |    |   (----`|  |__   |  | 
  \_    _/  |  |  |  | |  |  |  |    |  |     |  |  |  |     \   \    |   __|  |  | 
    |  |    |  `--'  | |  `--'  |    |  `----.|  `--'  | .----)   |   |  |____ |__| 
    |__|     \______/   \______/     |_______| \______/  |_______/    |_______|(__) 
                                                                                 
                    ";
            string VaderArt = @"
                       .-.
                      |_:_|
                     /(_Y_)\
.                   ( \/M\/ )
 '.               _.'-/'-'\-'._
   ':           _/.--'[[[[]'--.\_
     ':        /_'  : |::'| :  '.\
       ':     //   ./ |oUU| \.'  :\
         ':  _:'..' \_|___|_/ :   :|
           ':.  .'  |_[___]_|  :.':\
            [::\ |  :  | |  :   ; : \
             '-'   \/'.| |.' \  .;.' |
             |\_    \  '-'   :       |
             |  \    \ .:    :   |   |
             |   \    | '.   :    \  |
             /       \   :. .;       |
            /     |   |  :__/     :  \\
           |  |   |    \:   | \   |   ||
          /    \  : :  |:   /  |__|   /|
          |     : : :_/_|  /'._\  '--|_\
          /___.-/_|-'   \  \
                         '-'

";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(YouLoseArt);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(VaderArt);
            Console.ResetColor();
            System.Console.WriteLine("Art by Shanaka Dias");
        }
        static void MainMenuSelection(int tokens) // This method immediatly runs after the MainMenu method. Like the Main Menu method it is also a route that allows for access to any method below. However those methods never return to this method, rather they run MainMenu method again.
        {
            string userInput = Console.ReadLine();
            if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4") // Checks if the userinput is one of four correct selections and runs their corresponding method.
            {
                if (userInput == "1")
                {
                    Console.Clear();
                    TheForceTitleScreen(ref tokens);
                }
                if (userInput == "2")
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
            }

            else // If the user does not enter a number associated with a menu option, it informs the user that their input was invalid and returns to the Main method to re-desplay the menu options and accept a selection.
            {
                System.Console.WriteLine("Enter a valid number.");
                System.Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                MainMenu(tokens);
            }

        }
        static void ScoreBoard(int tokens) //Displays the users token balance, this runs after the suser selects three on the main menu.
        {
            string ScoreBoard = @"                 
             ._,.
           '..-..pf.
          -L   ..#'
        .+_L  .']#
        ,'j' .+.j`                 -'.__..,.,p.
       _~ #..<..0.                 .J-.``..._f.
      .7..#_.. _f.                .....-..,`4'
      ;` ,#j.  T'      ..         ..J....,'.j`     _______.  ______   ______   .______       _______ .______     ______        ___      .______       _______  
     .` ..'^.,-0.,,,,yMMMMM,.    ,-.J...+`.j@    /       | /      | /  __  \  |   _  \     |   ____||   _  \   /  __  \      /   \     |   _  \     |       \ 
    .'.`...' .yMMMMM0M@^=`''g.. .'..J..'.'.jH   |   (----`|  ,----'|  |  |  | |  |_)  |    |  |__   |  |_)  | |  |  |  |    /  ^  \    |  |_)  |    |  .--.  |
    j' .'1`  q'^)@@#'^'.`'='BNg_...,]_)'...0-    \   \    |  |     |  |  |  | |      /     |   __|  |   _  <  |  |  |  |   /  /_\  \   |      /     |  |  |  |
   .T ...I. j'    .'..+,_.'3#MMM0MggCBf....F..----)   |   |  `----.|  `--'  | |  |\  \----.|  |____ |  |_)  | |  `--'  |  /  _____  \  |  |\  \----.|  '--'  |
   j/.+'.{..+       `^~'-^~~''''''''?''``'1` |_______/     \______| \______/  | _| `._____||_______||______/   \______/  /__/     \__\ | _| `._____||_______/
   .... .y.}                  `.._-:`_...jf
   g-.  .Lg'                 ..,..'-....,'.
  .'.   .Y^                  .....',].._f
  ......-f.                 .-,,.,.-:--&`
                            .`...'..`_J`
                            .~......'#'
                            '..,,.,_]`     
                            .L..`..``.     
";
            string DividerArt = @"                                                                                                                                                                                    
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|
";
            System.Console.WriteLine(ScoreBoard);
            System.Console.WriteLine("Art by Ray Bruner");
            System.Console.WriteLine(DividerArt);
            System.Console.WriteLine("DividerArt");
            System.Console.WriteLine("Your current Token balance is " + tokens + " Tokens");
            System.Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
            Console.Clear();
            MainMenu(tokens);

        }
        static void BlastersTitleScreen(ref int tokens) // This is the title screen for the blasters game, its menu allows the user to start a game, view the directions, or return to the mainmenu.
        {
            string BlasterArt = @" 
                                               __ 1      1 __        _.xxxxxx.
                             [xxxxxxxxxxxxxx|##|xxxxxxxx|##|xxxxxxXXXXXXXXX|
             ____            [XXXXXXXXXXXXXXXXXXXXX/.\||||||XXXXXXXXXXXXXXX|
            |::: `-------.-.__[=========---___/::::|::::::|::::||X O^XXXXXX|
            |::::::::::::|2|%%%%%%%%%%%%\::::::::::|::::::|::::||X /
            |::::,-------|_|~~~~~~~~~~~~~`---=====-------------':||  5
             ~~~~                       |===|:::::|::::::::|::====:\O
                                        |===|:::::|:.----.:|:||::||:|
                                        |=3=|::4::`'::::::`':||__||:|
                                        |===|:::::::/  ))\:::`----':/
                                        `===|::::::|  // //~`######b
                                            `--------=====/  ######B
                                                             `######b
                                                              #######b
                                                               #######B
                                                              `#######b
                                                               #######P
                                                               `#####B

            ";
            string DividerArt = @"                                                                                                           
                                                                                                                        
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|
                                                                                                                        
                                                                                                        
            ";
            string BlastersTitleArt = @"
                .______    __          ___           _______.___________. _______ .______          _______.
                |   _  \  |  |        /   \         /       |           ||   ____||   _  \        /       |
                |  |_)  | |  |       /  ^  \       |   (----`---|  |----`|  |__   |  |_)  |      |   (----`
                |   _  <  |  |      /  /_\  \       \   \       |  |     |   __|  |      /        \   \    
                |  |_)  | |  `----./  _____  \  .----)   |      |  |     |  |____ |  |\  \----.----)   |   
                |______/  |_______/__/     \__\ |_______/       |__|     |_______|| _| `._____|_______/    
                                                                                                        
            ";

            System.Console.WriteLine(BlasterArt);
            System.Console.WriteLine(BlastersTitleArt);
             System.Console.WriteLine("Blaster art by: LS");
            System.Console.WriteLine(DividerArt);
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("1) Play Game");
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("2) How to play");
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("3) Return to Main Menu");
            System.Threading.Thread.Sleep(1000);
            Console.Write("Please enter the number associated with you selection...");
            string userInput = Console.ReadLine();
            BlastersMenuSelection(ref tokens, userInput);
        }
        static void TheForceTitleScreen(ref int tokens) //// This is the title screen for the force game, its menu allows the user to start a game, view the directions, or return to the mainmenu.
        {
            bool  forceW = false;
            bool  forceL = false;
            bool verification = false;
            string TheForceArt = @"
                              .___________. __    __   _______     _______   ______   .______        ______  _______    _____
  ______                _____ |           ||  |  |  | |   ____|   |   ____| /  __  \  |   _  \      /      ||   ____|  |6    |
  |2    | _____        |5    |`---|  |----`|  |__|  | |  |__      |  |__   |  |  |  | |  |_)  |    |  ,----'|  |__     | v v | 
  |  v  ||3    | _____ | v v |    |  |     |   __   | |   __|     |   __|  |  |  |  | |      /     |  |     |   __|    | v v | _____
  |     || v v ||4    ||  v  |    |  |     |  |  |  | |  |____    |  |     |  `--'  | |  |\  \----.|  `----.|  |____   | v v ||7    |
  |  v  ||     || v v || v v |    |__|     |__|  |__| |_______|   |__|      \______/  | _| `._____| \______||_______|  |____9|| v v | 
  |____Z||  v  ||     ||____S|                                                                                                |v v v|
         |____E|| v v |                                                                                                       | v v |
                |____h|                                                                                                       |____L|
                            	                                                                                                         


            ";
            string DividerArt = @"                                                                                                                      
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|
                                                                                                                        
            ";
            System.Console.WriteLine(TheForceArt);
            System.Console.WriteLine("Card art by: ejm98");
            System.Console.WriteLine(DividerArt);
            System.Threading.Thread.Sleep(1000);
            
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("1) Play Game");
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("2) How to Play");
            System.Threading.Thread.Sleep(1000);
            System.Console.WriteLine("3) Return to Main Menu");
            System.Threading.Thread.Sleep(1000);
            Console.Write("Please enter the number associated with you selection...");
            string userInput = Console.ReadLine();
            TheForceMenuSelection(userInput, ref  forceW, ref  forceL, tokens, verification);
        }
        static void TheForceMenuSelection(string userInput, ref bool  forceW, ref bool  forceL, int tokens, bool verification) // Just like the main menu method, the sub-menus for the games have a menu selection method which are nearly identical to the MainMenuSelection(); method.
        {

            if (userInput == "1")
            {
                Console.Clear();
                int bet = 0;
                PlaceBetTheForce(ref tokens);
                PlayTheForce(ref  forceW, ref  forceL, ref tokens, bet, verification);
            }
            if (userInput == "2")
            {
                Console.Clear();
                TheForceHowToPlay();
                TheForceTitleScreen(ref tokens);
            }
            if (userInput == "3")
            {
                Console.Clear();
                MainMenu(tokens);
            }
            while (userInput != "3" && userInput != "2" && userInput != "1")
            {
                System.Console.WriteLine("Invalid Input");
                System.Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                TheForceTitleScreen(ref tokens);
            }
        }
        static void BlastersMenuSelection(ref int tokens, string userInput)  // Just like the main menu method, the sub-menus for the games have a menu selection method which are nearly identical to the MainMenuSelection(); method.
        {

            if (userInput == "1")
            {
                Console.Clear();
                int bet = 0;
                int BlasterPoints = 15;
                if (tokens < 20)
                {
                    System.Console.WriteLine("Not enough tokens");
                    System.Console.WriteLine("Press key t cont.");
                    Console.ReadKey();
                    Console.Clear();
                    BlastersTitleScreen(ref tokens);
                }
                else
                {
                    bet = PlacebetBlasters(ref tokens);
                    PlayBlasters(ref BlasterPoints, ref tokens, bet);
                }

            }
            if (userInput == "2")
            {
                Console.Clear();
                BlastersHowToPlay();
                BlastersTitleScreen(ref tokens);

            }
            if (userInput == "3")
            {
                Console.Clear();
                MainMenu(tokens);
            }
            while (userInput != "3" && userInput != "2" && userInput != "1")
            {
                System.Console.WriteLine("Invalid Input");
                System.Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                BlastersTitleScreen(ref tokens);
            }
        }
        static void BlastersHowToPlay() // This method explains how to play blasters indepth, this utilizes the Console.ReadKey(); command which allows the user to push any button to progress.
        {
            string HowToPlayArt = @"
 __    __    ______   ____    __    ____    .___________.  ______      .______    __          ___   ____    ____ 
|  |  |  |  /  __  \  \   \  /  \  /   /    |           | /  __  \     |   _  \  |  |        /   \  \   \  /   / 
|  |__|  | |  |  |  |  \   \/    \/   /     `---|  |----`|  |  |  |    |  |_)  | |  |       /  ^  \  \   \/   /  
|   __   | |  |  |  |   \            /          |  |     |  |  |  |    |   ___/  |  |      /  /_\  \  \_    _/   
|  |  |  | |  `--'  |    \    /\    /           |  |     |  `--'  |    |  |      |  `----./  _____  \   |  |     
|__|  |__|  \______/      \__/  \__/            |__|      \______/     | _|      |_______/__/     \__\  |__|     
    ";

            string DividerArt = @"                                                                                                                     
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|
    ";
            System.Console.WriteLine(HowToPlayArt);
            System.Console.WriteLine(DividerArt);
            System.Console.WriteLine("Welcome to Blasters!");
            System.Threading.Thread.Sleep(2000);
            System.Console.WriteLine("In this game, a droid will shoot at you with a  blaster. It is your job to either dodge or deflect the laster to not get hit.");
            System.Threading.Thread.Sleep(3000);
            System.Console.WriteLine("You will start off with 15 points, each time you get hit you lose 5 points.");
            System.Threading.Thread.Sleep(3000);
            System.Console.WriteLine("Upon a succesfull deflection, you earn 10 points.");
            System.Console.WriteLine("For a succesfull dodge, you earn 5.");
            System.Threading.Thread.Sleep(4000);
            System.Console.WriteLine("You will bet your tokens to play.");
            System.Console.WriteLine("A minimum bet of 20 tokens is required.");
            System.Threading.Thread.Sleep(3000);
            System.Console.WriteLine("You win the game ends when you hit 40 points, and double your bet.");
            System.Console.WriteLine("The game ends when you hit 0 points, losing all that you bet.");
            System.Threading.Thread.Sleep(3000);
            System.Console.WriteLine("Press any key to return to the title screen.");
            Console.ReadKey();
            Console.Clear();


        }
        static int PlayBlasters(ref int BlasterPoints, ref int tokens, int bet) // This method is a full round of Blaster, the mechanics are further explained within here.
        {
             string BlastersArt1 = @"
            |  .-.                                                                                                                     _      ,:' `..;
            ||/__'`.                                                                                                                  | |     `. ,;;'%
            |//()'-.:                                                                                                                 | |     +;;'%%%%%
            |-.||                                                                                                                     | |     /- %,)%%
            |o(o)                                                                                                                     | |     `   \ %%
            |||\\\  .==._      *************                                                                                          | |     =  )/ \
            |||(o)==::'                                                                                                               | |     `-'/ / \
            `|T                                                                                                                       | |     /\/.-.\
            ()                                                                                                                        | |    |  (    |
            |\\                                                                                                                       | |    |  |   ||
            ||\\                                                                                                                      | |    |  |   ||
            || ||                                                                                                                    [{o}].-----'   ||
            () ()                                                                                                                    (___\________,'|
            ||//                                                                                                                      `0'   |       |
            |//                                                                                                                             |       |
            .'=`=.                                                                                                                          |       |                            
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|
            ";
            
             string BlastersArt2 = @"
            |  .-.                                                                                                                     _      ,:' `..;
            ||/__'`.                                                                                                                  | |     `. ,;;'%
            |//()'-.:                                                                                                                 | |     +;;'%%%%%
            |-.||                                                                                                                     | |     /- %,)%%
            |o(o)                                                                                                                     | |     `   \ %%
            |||\\\  .==._                                              *************                                                  | |     =  )/ \
            |||(o)==::'                                                                                                               | |     `-'/ / \
            `|T                                                                                                                       | |     /\/.-.\
            ()                                                                                                                        | |    |  (    |
            |\\                                                                                                                       | |    |  |   ||
            ||\\                                                                                                                      | |    |  |   ||
            || ||                                                                                                                    [{o}].-----'   ||
            () ()                                                                                                                    (___\________,'|
            ||//                                                                                                                      `0'   |       |
            |//                                                                                                                             |       |
            .'=`=.                                                                                                                          |       |
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|   
            ";
           
            string BlastersArt3 = @"
            |  .-.                                                                                                                     _      ,:' `..;
            ||/__'`.                                                                                                                  | |     `. ,;;'%
            |//()'-.:                                                                                                                 | |     +;;'%%%%%
            |-.||                                                                                                                     | |     /- %,)%%
            |o(o)                                                                                                                     | |     `   \ %%
            |||\\\  .==._                                                                                            *************    | |     =  )/ \
            |||(o)==::'                                                                                                               | |     `-'/ / \
            `|T                                                                                                                       | |     /\/.-.\
            ()                                                                                                                        | |    |  (    |
            |\\                                                                                                                       | |    |  |   ||
            ||\\                                                                                                                      | |    |  |   ||
            || ||                                                                                                                    [{o}].-----'   ||
            () ()                                                                                                                    (___\________,'|
            ||//                                                                                                                      `0'   |       |
            |//                                                                                                                             |       |
            .'=`=.                                                                                                                          |       |
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______| 
            ";
            string WatchOutArt = @"
 __  .__   __.   ______   ______   .___  ___.  __  .__   __.   _______  __   __   __  
|  | |  \ |  |  /      | /  __  \  |   \/   | |  | |  \ |  |  /  _____||  | |  | |  | 
|  | |   \|  | |  ,----'|  |  |  | |  \  /  | |  | |   \|  | |  |  __  |  | |  | |  | 
|  | |  . `  | |  |     |  |  |  | |  |\/|  | |  | |  . `  | |  | |_ | |  | |  | |  | 
|  | |  |\   | |  `----.|  `--'  | |  |  |  | |  | |  |\   | |  |__| | |__| |__| |__| 
|__| |__| \__|  \______| \______/  |__|  |__| |__| |__| \__|  \______| (__) (__) (__) 
            ";
            string DodgeArt = @"
            _______   ______    _______   _______  _______ 
            |       \ /  __  \  |       \ /  _____||   ____|
            |  .--.  |  |  |  | |  .--.  |  |  __  |  |__   
            |  |  |  |  |  |  | |  |  |  |  | |_ | |   __|  
            |  '--'  |  `--'  | |  '--'  |  |__| | |  |____ 
            |_______/ \______/  |_______/ \______| |_______|
                                                            
            ";
            string DeflectArt = @"
            _______   _______  _______  __       _______   ______ .___________.
            |       \ |   ____||   ____||  |     |   ____| /      ||           |
            |  .--.  ||  |__   |  |__   |  |     |  |__   |  ,----'`---|  |----`
            |  |  |  ||   __|  |   __|  |  |     |   __|  |  |         |  |     
            |  '--'  ||  |____ |  |     |  `----.|  |____ |  `----.    |  |     
            |_______/ |_______||__|     |_______||_______| \______|    |__|     
                
            ";
            string FleeArt = @"
            _______  __       _______  _______ 
            |   ____||  |     |   ____||   ____|
            |  |__   |  |     |  |__   |  |__   
            |   __|  |  |     |   __|  |   __|  
            |  |     |  `----.|  |____ |  |____ 
            |__|     |_______||_______||_______|
                                                
            ";
                // All of the art above is used as artwork for the game. These string are displayed using the Console.Writeline(); method.
            if (BlasterPoints >= 40 || BlasterPoints <= 0) // Before every round of blasters the program checks if the user's blaster points meet the win or lose condition.
            {

                if (BlasterPoints >= 40) // This is the win condition scenario, it updates the user's tokens with their bet amount times 2, and tells the user they have won. The user then has the option to play again or return to mainmenu from here.
                {
                    UpdateTokensBlasters(BlasterPoints, bet, ref tokens);
                    WinLossCheck(ref tokens);
                    System.Console.WriteLine("You Won!");
                    System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!");
                    int userChoice = int.Parse(Console.ReadLine());
                    while ((userChoice != 2) && (userChoice != 1))
                    {
                        System.Console.WriteLine("Invalid Choice.");
                        System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!");
                        userChoice = int.Parse(Console.ReadLine());
                    }

                    if (userChoice == 1) // Option one lets the user play again. The game must make sure the user can make a minimum bet of twenty as per the games rules, if they don't it brings the user back to the games title screen.
                    {
                        if (tokens < 20)//The game must make sure the user can make a minimum bet of twenty as per the games rules, if they don't it brings the user back to the games title screen.
                    
                        {
                            System.Console.WriteLine("Not enough tokens");
                            System.Console.WriteLine("Press key to cont.");
                            Console.ReadKey();
                            Console.Clear();
                            BlastersTitleScreen(ref tokens); // return to title screen
                        }
                        else // If the user can make a proper bet, it runs the same commands under the if statement in MainMenuSelection had the user pressed 2.
                        {
                            bet = 0;
                            BlasterPoints = 20;
                            bet = PlacebetBlasters(ref tokens);
                            PlayBlasters(ref BlasterPoints, ref tokens, bet);
                        }
                    }
                    if (userChoice == 2) // If the user presses two it takes them back to the programs mainmenu(;)
                    {
                        MainMenu(tokens);
                    }

                }
                if (BlasterPoints <= 0) // Now a sequence similar to the if (Blasterpoint >= 300) runs but for the instance the user loses.
                {
                    UpdateTokensBlasters(BlasterPoints, bet, ref tokens);
                    System.Console.WriteLine("You Lost!");
                    WinLossCheck(ref tokens);
                    System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!");
                    int userChoice = int.Parse(Console.ReadLine());
                    while ((userChoice != 2) && (userChoice != 1))
                    {
                        System.Console.WriteLine("Invalid Choice.");
                        System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!");
                        userChoice = int.Parse(Console.ReadLine());
                    }

                    if (userChoice == 1)
                    {
                        if (tokens < 20)
                        {
                            System.Console.WriteLine("Not enough tokens");
                            System.Console.WriteLine("Press key to cont.");
                            Console.ReadKey();
                            Console.Clear();
                            BlastersTitleScreen(ref tokens);
                        }
                        else
                        {
                            bet = 0;
                            BlasterPoints = 20;
                            bet = PlacebetBlasters(ref tokens);
                            PlayBlasters(ref BlasterPoints, ref tokens, bet);
                        }
                    }
                    if (userChoice == 2)
                    {
                        MainMenu(tokens);
                    }

                }

            }
            for (int g =0; g <3; ) // This is my favorite part of the program. Before running the portion of this method that allows for the user to directly interact with the game...
            {                       // It shows the user an animated sequence of a battle droid shooting a laser at luke, with below it flashing "INCOMING!"
                                    // The for loop allows for the animation cycle to run three times, before the user can make inputs.
Console.Clear();
System.Console.WriteLine(BlastersArt1);
Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine(WatchOutArt);
Console.ResetColor();
System.Threading.Thread.Sleep(250);
Console.Clear();
System.Console.WriteLine(BlastersArt2);
Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine(WatchOutArt);
Console.ResetColor();
System.Threading.Thread.Sleep(250);
Console.Clear();
System.Console.WriteLine(BlastersArt3);
Console.ForegroundColor = ConsoleColor.Red;
System.Console.WriteLine(WatchOutArt);
Console.ResetColor();
System.Threading.Thread.Sleep(250);
g++;                                    //Updates the cycle count
            }
            System.Console.WriteLine("INCOMING LASER!"); // This is what the user sees after the animation plays.
            System.Console.WriteLine("Do you...");
            System.Console.WriteLine("1) Dodge (50% Success Rate)");
            System.Console.WriteLine("2) Deflect (30% Success Rate)");
            System.Console.WriteLine("3) Flee (Ends the game early, but you relinquish your gambled tokens.)");
            System.Console.Write("Enter the number associated with your selection:");
            string userInput = Console.ReadLine();
            while (BlasterPoints <= 40 && BlasterPoints >= 0) // Before checking if a move was successful or not, the program checks that (given the results of the previous round) if the won or lost the game.
            {


                if (userInput == "1") // Option for dodge chance.
                {
                    Console.Clear();
                    System.Console.WriteLine("You chose...");
                    System.Threading.Thread.Sleep(2000);
                    System.Console.WriteLine(DodgeArt);
                    System.Threading.Thread.Sleep(2000);
                    System.Console.WriteLine("And it...");
                    System.Threading.Thread.Sleep(2000); 
                    DodgeCheck(ref BlasterPoints); // This method utilizes random integars to determine success or fail. We'll get to this later.
                    PlayBlasters(ref BlasterPoints, ref tokens, bet);

                }

                if (userInput == "2") // Option for Deflect chance
                {
                    Console.Clear();
                    System.Console.WriteLine("You chose...");
                    System.Threading.Thread.Sleep(2000);
                    System.Console.WriteLine(DeflectArt);
                    System.Threading.Thread.Sleep(2000);
                    System.Console.WriteLine("And it...");
                    System.Threading.Thread.Sleep(2000);
                    DeflectCheck(ref BlasterPoints); // Similar to deflectcheck
                    PlayBlasters(ref BlasterPoints, ref tokens, bet);

                }

                if (userInput == "3") // Option to flee, this option has is slightly different from the above two.
                {
                    Console.Clear();
                    System.Console.WriteLine("You chose...");
                    System.Threading.Thread.Sleep(2000);
                    System.Console.WriteLine(FleeArt);
                    System.Threading.Thread.Sleep(2000);
                    System.Console.WriteLine("And it...");
                    System.Threading.Thread.Sleep(2000);
                    Flee(ref BlasterPoints); //unique method check 
                    PlayBlasters(ref BlasterPoints, ref tokens, bet);

                }

                if (userInput != "1" || userInput != "2" || userInput != "3") // If the user inputs a number or string not associated with the given movement options.
                {                                                              // the console informs the user of invalid input, and allows them to play again with no penalty to score.
                    System.Console.WriteLine("Invalid Input.");
                    System.Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    PlayBlasters(ref BlasterPoints, ref tokens, bet);

                }

            }
            if (BlasterPoints >= 40) //This is outside the above while statment, if these if statements run after a round, 
                                    //it updates the tokens and would indicate that the first checks will succeed at the start of next round.
            {
                tokens = tokens + bet + bet;

            }

            if (BlasterPoints <= 0)
            {
                tokens = tokens - bet;
            }
            return tokens; // Updates the tokens global value.
        }
        static int PlacebetBlasters(ref int tokens)// This method allows for the user to place a bet for the game blasters, it is slightly different the force bet (described below)
        {
            string PlaceYaBets = @"
    __.-._   .______    __          ___       ______  _______    ____    ____  ______    __    __  .______         .______    _______ .___________. __  
    '-._'7'  |   _  \  |  |        /   \     /      ||   ____|   \   \  /   / /  __  \  |  |  |  | |   _  \        |   _  \  |   ____||           ||  | 
     /'.-c   |  |_)  | |  |       /  ^  \   |  ,----'|  |__       \   \/   / |  |  |  | |  |  |  | |  |_)  |       |  |_)  | |  |__   `---|  |----`|  | 
     |  /T   |   ___/  |  |      /  /_\  \  |  |     |   __|       \_    _/  |  |  |  | |  |  |  | |      /        |   _  <  |   __|      |  |     |  | 
    _)_/LI   |  |      |  `----./  _____  \ |  `----.|  |____        |  |    |  `--'  | |  `--'  | |  |\  \----.   |  |_)  | |  |____     |  |     |__| 
             | _|      |_______/__/     \__\ \______||_______|       |__|     \______/   \______/  | _| `._____|   |______/  |_______|    |__|     (__) 
";
            string DividerArt = @"
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|
";
            System.Console.WriteLine(PlaceYaBets);
            System.Console.WriteLine(DividerArt);
            System.Console.WriteLine("Your Token bet must be greater than or equal to 20."); //This game requires the user to be able to make a bet over the threshold of 20.
            System.Console.WriteLine("Your currently have " + tokens + " Tokens");
            Console.Write("Please Enter the number associated with your bet:");
            int bet = int.Parse(Console.ReadLine());
            int Verify = 0;
            Verify = tokens - bet; // this equation will be used to check to see if the user is betting more tokens than they actually have, see below.
            while (bet < 20 || bet > tokens) // This while loop's  conditions are the two situations in which the user has made an incorrect bet.
            {
                if (bet < 20) // if the bet is below 20, it wont go through par the games rules.
                {
                    System.Console.WriteLine("Invalid bet.");
                    System.Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    System.Console.WriteLine("Your Token bet must be greater than or equal to 20.");
                    System.Console.WriteLine("Your currently have " + tokens + " Tokens");
                    Console.Write("Please Enter the number associated with your bet:");
                    bet = int.Parse(Console.ReadLine());
                }
                else // Since the previous check fails (which is one of the while loops conditions), this automatically assumes that the other statement was true. 
                    // the else statement acts exactly as "if(bet>tokens)" were written.
                {
                    System.Console.WriteLine("This bet value puts you at, or below, 0.");
                    System.Console.WriteLine("Press any key to place a new bet...");
                    Console.ReadKey();
                    Console.Clear();
                    System.Console.WriteLine("Your Token bet must be greater than or equal to 20.");
                    System.Console.WriteLine("Your currently have " + tokens + " Tokens");
                    Console.Write("Please Enter the number associated with your bet:");
                    bet = int.Parse(Console.ReadLine());
                }
            }
            System.Console.WriteLine("You bet " + bet + " Tokens."); 
            System.Console.WriteLine("This leaves your current balance at " + (tokens - bet) + " Tokens.");
            tokens = tokens - bet;
            System.Console.WriteLine("Press any key to play...");
            Console.ReadKey();
            Console.Clear();
            return bet; // updates the global value of the variable bet.

        }
        static int DodgeCheck(ref int BlasterPoints) // here is the method that test wether the dodge action is successful or not
        {
            string Worked = @"
____    __    ____  ______   .______       __  ___  _______  _______   __  
\   \  /  \  /   / /  __  \  |   _  \     |  |/  / |   ____||       \ |  | 
 \   \/    \/   / |  |  |  | |  |_)  |    |  '  /  |  |__   |  .--.  ||  | 
  \            /  |  |  |  | |      /     |    <   |   __|  |  |  |  ||  | 
   \    /\    /   |  `--'  | |  |\  \----.|  .  \  |  |____ |  '--'  ||__| 
    \__/  \__/     \______/  | _| `._____||__|\__\ |_______||_______/ (__)                                                                   
        ";
            string Failed = @"
 _______    ___       __   __       _______  _______   __  
|   ____|  /   \     |  | |  |     |   ____||       \ |  | 
|  |__    /  ^  \    |  | |  |     |  |__   |  .--.  ||  | 
|   __|  /  /_\  \   |  | |  |     |   __|  |  |  |  ||  | 
|  |    /  _____  \  |  | |  `----.|  |____ |  '--'  ||__| 
|__|   /__/     \__\ |__| |_______||_______||_______/ (__) 
    ";
            Random rnd = new Random(); // generating a new random variable
            int check = rnd.Next(1, 3); // setting the range for the random to be generated within, and setting it equal to an integar
            if (check == 1)             // Since its a 50% success rate, the random variable will only generate a one or two, here one is set to be the correct scenario
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine(Worked);
                Console.ResetColor();
                BlasterPoints = BlasterPoints + 5;
                System.Console.WriteLine("You've earned 5 Points!");
                System.Console.WriteLine($"You currently have {BlasterPoints} points!");
                System.Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();


            }

            if (check == 2) // 2 is set to be failure, it could also just have an else statement.
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(Failed);
                Console.ResetColor();
                BlasterPoints = BlasterPoints - 5;
                System.Console.WriteLine("You've lost 5 points!");
                System.Console.WriteLine($"You currently have {BlasterPoints} points!");
                System.Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();


            }
            return BlasterPoints; // updates the points variable for the game


        }
        static int DeflectCheck(ref int BlasterPoints) // Test wether the deflect was successfil or not
        {
            string Worked = @"
____    __    ____  ______   .______       __  ___  _______  _______   __  
\   \  /  \  /   / /  __  \  |   _  \     |  |/  / |   ____||       \ |  | 
 \   \/    \/   / |  |  |  | |  |_)  |    |  '  /  |  |__   |  .--.  ||  | 
  \            /  |  |  |  | |      /     |    <   |   __|  |  |  |  ||  | 
   \    /\    /   |  `--'  | |  |\  \----.|  .  \  |  |____ |  '--'  ||__| 
    \__/  \__/     \______/  | _| `._____||__|\__\ |_______||_______/ (__)                                                                   
        ";
            string Failed = @"
 _______    ___       __   __       _______  _______   __  
|   ____|  /   \     |  | |  |     |   ____||       \ |  | 
|  |__    /  ^  \    |  | |  |     |  |__   |  .--.  ||  | 
|   __|  /  /_\  \   |  | |  |     |   __|  |  |  |  ||  | 
|  |    /  _____  \  |  | |  `----.|  |____ |  '--'  ||__| 
|__|   /__/     \__\ |__| |_______||_______||_______/ (__) 
    ";
            Random rnd = new Random();
            int check = rnd.Next(1, 11); // since this random has a 30% success rate, generating a random number between 1 and 10, 3 of those numbers will be correct for a succesful dodge thus is 30%
            if ((check == 1) || (check == 2) || (check == 3)) // the three chosen success numbers
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine(Worked);
                Console.ResetColor();
                BlasterPoints = BlasterPoints + 10;
                System.Console.WriteLine("You've earned 10 Points!");
                System.Console.WriteLine($"You currently have {BlasterPoints} points!");
                System.Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                return BlasterPoints;
            }

            else // any other generated numbers are incorrect, no need for a long if statment
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(Failed);
                Console.ResetColor();
                BlasterPoints = BlasterPoints - 5;
                System.Console.WriteLine("You've lost 5 points!");
                System.Console.WriteLine($"You currently have {BlasterPoints} points!");
                System.Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                return BlasterPoints;
            }
        }
        static int Flee(ref int BlasterPoints) // Since the user should be able to leave the game at any time, the Flee option is basically an exit function with a 100% success rate
        {
            string Worked = @" 
____    __    ____  ______   .______       __  ___  _______  _______   __  
\   \  /  \  /   / /  __  \  |   _  \     |  |/  / |   ____||       \ |  | 
 \   \/    \/   / |  |  |  | |  |_)  |    |  '  /  |  |__   |  .--.  ||  | 
  \            /  |  |  |  | |      /     |    <   |   __|  |  |  |  ||  | 
   \    /\    /   |  `--'  | |  |\  \----.|  .  \  |  |____ |  '--'  ||__| 
    \__/  \__/     \______/  | _| `._____||__|\__\ |_______||_______/ (__)                                                                   
        ";                                  // Since the flee has 100% success, no need to generate a variable.

            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(Worked); 
            Console.ResetColor();
            System.Console.WriteLine("You lost all of your points!");
            BlasterPoints = BlasterPoints - BlasterPoints;
            return BlasterPoints;
        }
        static void UpdateTokensBlasters(int BlasterPoints, int bet, ref int tokens) // This is used to reward or penalize the user for winning or losing a round and adjust their tokens
        {
            if (BlasterPoints >= 40)
            {
                tokens = tokens + bet + bet;

            }

            if (BlasterPoints <= 0)
            {
                tokens = tokens - bet;
            }
        }
        static int NextCard(string[] deck, int i) // This array assigns a vaule to every number thats created in a method below. This is for the force game.
        {
            if (deck[i].Contains("Ace")) //the .contains checks the string of the card in 'i' spot of the array.
            {

                return 1; //Since Ace is valued at 1, we return the value one for a round in the force
            }
            if (deck[i].Contains("2"))
            {

                return 2;
            }
            if (deck[i].Contains("3"))
            {

                return 3;
            }
            if (deck[i].Contains("4"))
            {

                return 4;
            }
            if (deck[i].Contains("5"))
            {

                return 5;
            }
            if (deck[i].Contains("6"))
            {

                return 6;
            }
            if (deck[i].Contains("7"))
            {

                return 7;
            }
            if (deck[i].Contains("8"))
            {

                return 8;
            }
            if (deck[i].Contains("9"))
            {

                return 9;
            }
            if (deck[i].Contains("10"))
            {

                return 10;
            }
            if (deck[i].Contains("Jack"))
            {

                return 11; // Jack is worth 11
            }
            if (deck[i].Contains("Queen"))
            {

                return 12; // Queen is worth 12
            }
            if (deck[i].Contains("King"))
            {

                return 13; // King is worth 13
            }
            else
            {
                return 0; // If somehow the card passes through the if statements without trigger one, the program will just return zero.
                            // This was primarily used for debugging purpouses, it doens't trigger unless purposefully triggered.
            }
        }
        static void TheForceHowToPlay() // Just the how to play instructions for the force
        {
            string HowToPlayArt = @"
 __    __    ______   ____    __    ____    .___________.  ______      .______    __          ___   ____    ____ 
|  |  |  |  /  __  \  \   \  /  \  /   /    |           | /  __  \     |   _  \  |  |        /   \  \   \  /   / 
|  |__|  | |  |  |  |  \   \/    \/   /     `---|  |----`|  |  |  |    |  |_)  | |  |       /  ^  \  \   \/   /  
|   __   | |  |  |  |   \            /          |  |     |  |  |  |    |   ___/  |  |      /  /_\  \  \_    _/   
|  |  |  | |  `--'  |    \    /\    /           |  |     |  `--'  |    |  |      |  `----./  _____  \   |  |     
|__|  |__|  \______/      \__/  \__/            |__|      \______/     | _|      |_______/__/     \__\  |__|     
    ";

            string DividerArt = @"                                                                                                                     
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|
    ";
            System.Console.WriteLine(HowToPlayArt);
            System.Console.WriteLine(DividerArt);
            System.Console.WriteLine("Welcome to The Force!");
            System.Threading.Thread.Sleep(2000);
            System.Console.WriteLine("In this game you will be shown ten cards, with only one being revealed to you in the beginning.");
            System.Threading.Thread.Sleep(2500);
            System.Console.WriteLine("You will then guess if the next card to be shown is: greater than or less than the previous cards.");
            System.Console.WriteLine("Given the nature of the game, you will be unable to choose 'equal to'.");
            System.Threading.Thread.Sleep(4000);
            System.Console.WriteLine("You must bet your tokens to play.");
            System.Console.WriteLine("Any ammount of tokens is allowed for a valid bet."); // The difference between placing a bet in the force and blaster, is that the force doesn't have a minimum requirement.
            System.Threading.Thread.Sleep(3000);
            System.Console.WriteLine("You lose your bet if you incorrectly guess a card before reaching five correct guess in a row.");
            System.Console.WriteLine("You break even if you get between 5 and 7 guesses correct in a row. ");
            System.Console.WriteLine("You double your bet if you get between 7 and 10 guesses correct in a row.");
            System.Console.WriteLine("You triple your bet if you correctly guess all ten cards in the sequence.");
            System.Threading.Thread.Sleep(5000);
            System.Console.WriteLine("Press any key to return to the title screen.");
            Console.ReadKey();
            Console.Clear();
        }
        static void CardGraphic(string[] deck, int i) // here is the aforementioned method which associates every possible card ina 52 deck, to a graphic that matches in suit and value
        {
            if (deck[i] == "Ace of Hearts")
            {
                string card = @" 
 ____   
|A   | 
|(\/)|  
| \/ | 
|   A|    
`----`  ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "2 of Hearts")
            {
                string card = @"
 ____   
|2   | 
|(\/)|  
| \/ | 
|   2|    
`----`
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "3 of Hearts")
            {
                string card = @"
 ____   
|3   | 
|(\/)|  
| \/ | 
|   3|    
`----`
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "4 of Hearts")
            {
                string card = @"
 ____   
|4   | 
|(\/)|  
| \/ | 
|   4|    
`----`
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "5 of Hearts")
            {
                string card = @"
 ____   
|5   | 
|(\/)|  
| \/ | 
|   5|    
`----` 
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "6 of Hearts")
            {
                string card = @"
 ____   
|6   | 
|(\/)|  
| \/ | 
|   6|    
`----` 
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "7 of Hearts")
            {
                string card = @"
 ____   
|7   | 
|(\/)|  
| \/ | 
|   7|    
`----`    
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "8 of Hearts")
            {
                string card = @"
 ____   
|8   | 
|(\/)|  
| \/ | 
|   8|    
`----`  
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "9 of Hearts")
            {
                string card = @"
 ____   
|9   | 
|(\/)|  
| \/ | 
|   9|    
`----`
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "10 of Hearts")
            {
                string card = @"
 ____   
|10  | 
|(\/)|  
| \/ | 
|  10|    
`----` 
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "Jack of Hearts")
            {
                string card = @"
 ____   
|J   | 
|(\/)|  
| \/ | 
|   J|    
`----` 
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "Queen of Hearts")
            {
                string card = @"
 ____   
|Q   | 
|(\/)|  
| \/ | 
|   Q|    
`----` 
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "King of Hearts")
            {
                string card = @"
 ____   
|K   | 
|(\/)|  
| \/ | 
|   K|    
`----` 
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "Ace of Diamonds")
            {
                string card = @"
 ____
|A   |
| /\ |
| \/ |
|   A|
`----'
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "2 of Diamonds")
            {
                string card = @"
 ____
|2   |
| /\ |
| \/ |
|   2|
`----'
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "3 of Diamonds")
            {
                string card = @"
 ____
|3   |
| /\ |
| \/ |
|   3|
`----'
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "4 of Diamonds")
            {
                string card = @"
 ____
|4   |
| /\ |
| \/ |
|   4|
`----'
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "5 of Diamonds")
            {
                string card = @"
 ____
|5   |
| /\ |
| \/ |
|   5|
`----'
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "6 of Diamonds")
            {
                string card = @"
 ____
|6   |
| /\ |
| \/ |
|   6|
`----'
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "7 of Diamonds")
            {
                string card = @"
 ____
|7   |
| /\ |
| \/ |
|   7|
`----'
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "8 of Diamonds")
            {
                string card = @"
 ____
|8   |
| /\ |
| \/ |
|   8|
`----'
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "9 of Diamonds")
            {
                string card = @"
 ____
|9   |
| /\ |
| \/ |
|   9|
`----'
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "10 of Diamonds")
            {
                string card = @"
 ____
|10  |
| /\ |
| \/ |
|  10|
`----'
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "Jack of Diamonds")
            {
                string card = @"
 ____
|J   |
| /\ |
| \/ |
|   J|
`----'
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "Queen of Diamonds")
            {
                string card = @"
 ____
|Q   |
| /\ |
| \/ |
|   Q|
`----'
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "King of Diamonds")
            {
                string card = @"
 ____
|K   |
| /\ |
| \/ |
|   K|
`----'
        ";
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(card);
                Console.ResetColor();
            }
            if (deck[i] == "Ace of Spades")
            {
                string card = @"
 ____ 
|A   |
| /\ |
|(__)|
| /\A|
`----'
        ";

                System.Console.WriteLine(card);

            }
            if (deck[i] == "2 of Spades")
            {
                string card = @"
 ____ 
|2   |
| /\ |
|(__)|
| /\2|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "3 of Spades")
            {
                string card = @"
 ____ 
|3   |
| /\ |
|(__)|
| /\3|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "4 of Spades")
            {
                string card = @"
 ____ 
|4   |
| /\ |
|(__)|
| /\4|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "5 of Spades")
            {
                string card = @"
 ____ 
|5   |
| /\ |
|(__)|
| /\5|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "6 of Spades")
            {
                string card = @"
 ____ 
|6   |
| /\ |
|(__)|
| /\6|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "7 of Spades")
            {
                string card = @"
 ____ 
|7   |
| /\ |
|(__)|
| /\7|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "8 of Spades")
            {
                string card = @"
 ____ 
|8   |
| /\ |
|(__)|
| /\8|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "9 of Spades")
            {
                string card = @"
 ____ 
|9   |
| /\ |
|(__)|
| /\9|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "10 of Spades")
            {
                string card = @"
 ____ 
|10  |
| /\ |
|(__)|
| /10|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "Jack of Spades")
            {
                string card = @"
 ____ 
|J   |
| /\ |
|(__)|
| /\J|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "Queen of Spades")
            {
                string card = @"
 ____ 
|Q   |
| /\ |
|(__)|
| /\Q|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "King of Spades")
            {
                string card = @"
 ____ 
|K   |
| /\ |
|(__)|
| /\K|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "Ace of Clubs")
            {
                string card = @"
 ____
|A   |
| &  |
|&|& |
| | A|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "2 of Clubs")
            {
                string card = @"
 ____
|2   |
| &  |
|&|& |
| | 2|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "3 of Clubs")
            {
                string card = @"
 ____
|3   |
| &  |
|&|& |
| | 3|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "4 of Clubs")
            {
                string card = @"
 ____
|4   |
| &  |
|&|& |
| | 4|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "5 of Clubs")
            {
                string card = @"
 ____
|5   |
| &  |
|&|& |
| | 5|
`----'
        ";
                System.Console.WriteLine(card);

            }
            if (deck[i] == "6 of Clubs")
            {
                string card = @"
 ____
|6   |
| &  |
|&|& |
| | 6|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "7 of Clubs")
            {
                string card = @"
 ____
|7   |
| &  |
|&|& |
| | 7|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "8 of Clubs")
            {
                string card = @"
 ____
|8   |
| &  |
|&|& |
| | 8|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "9 of Clubs")
            {
                string card = @"
 ____
|9   |
| &  |
|&|& |
| | 9|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "10 of Clubs")
            {
                string card = @"
 ____
|10  |
| &  |
|&|& |
| |10|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "Jack of Clubs")
            {
                string card = @"
 ____
|J   |
| &  |
|&|& |
| | J|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "Queen of Clubs")
            {
                string card = @"
 ____
|Q   |
| &  |
|&|& |
| | Q|
`----'
        ";
                System.Console.WriteLine(card);
            }
            if (deck[i] == "King of Clubs")
            {
                string card = @"
 ____
|K   |
| &  |
|&|& |
| | K|
`----'
        ";
                System.Console.WriteLine(card);
            }

        }
        static int PlaceBetTheForce(ref int tokens) //Placing a bet for the force
        {
            string PlaceYaBets = @"
    __.-._   .______    __          ___       ______  _______    ____    ____  ______    __    __  .______         .______    _______ .___________. __  
    '-._'7'  |   _  \  |  |        /   \     /      ||   ____|   \   \  /   / /  __  \  |  |  |  | |   _  \        |   _  \  |   ____||           ||  | 
     /'.-c   |  |_)  | |  |       /  ^  \   |  ,----'|  |__       \   \/   / |  |  |  | |  |  |  | |  |_)  |       |  |_)  | |  |__   `---|  |----`|  | 
     |  /T   |   ___/  |  |      /  /_\  \  |  |     |   __|       \_    _/  |  |  |  | |  |  |  | |      /        |   _  <  |   __|      |  |     |  | 
    _)_/LI   |  |      |  `----./  _____  \ |  `----.|  |____        |  |    |  `--'  | |  `--'  | |  |\  \----.   |  |_)  | |  |____     |  |     |__| 
             | _|      |_______/__/     \__\ \______||_______|       |__|     \______/   \______/  | _| `._____|   |______/  |_______|    |__|     (__) 
";
            string DividerArt = @"
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|
";
            System.Console.WriteLine(PlaceYaBets);
            System.Console.WriteLine(DividerArt);
            System.Console.WriteLine("Your Token bet must be greater than 0.");
            System.Console.WriteLine("Your currently have " + tokens + " Tokens");
            Console.Write("Please Enter the number associated with your bet:");
            int bet = int.Parse(Console.ReadLine());
            int Verify = 0;
            Verify = tokens - bet;
            while (bet < 0 || tokens - bet < 0) // Very similar to the blasters statement, but here we just have to make sure that user doesnt put in a negative bet, or bets tokens they don't have.
            {
                if (bet < 0)
                {
                    System.Console.WriteLine("Invalid bet.");
                    System.Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    System.Console.WriteLine("Your Token bet must be greater than 0.");
                    System.Console.WriteLine("Your currently have " + tokens + " Tokens");
                    Console.Write("Please Enter the number associated with your bet:");
                    bet = int.Parse(Console.ReadLine());
                }
                else
                {
                    System.Console.WriteLine("This bet value puts you below, 0.");
                    System.Console.WriteLine("Press any key to place a new bet...");
                    Console.ReadKey();
                    Console.Clear();
                    System.Console.WriteLine("Your Token bet must be greater than or equal to 20.");
                    System.Console.WriteLine("Your currently have " + tokens + " Tokens");
                    Console.Write("Please Enter the number associated with your bet:");
                    bet = int.Parse(Console.ReadLine());
                }
            }
            System.Console.WriteLine("You bet " + bet + " Tokens.");
            System.Console.WriteLine("This leaves your current balance at " + (tokens - bet) + " Tokens.");
            tokens = tokens - bet;
            System.Console.WriteLine("Press any key to play...");
            Console.ReadKey();
            Console.Clear();
            return bet;

        }
        static void PlayTheForce(ref bool  forceW, ref bool  forceL, ref int tokens, int bet, bool verification) // Here is the main method for running a force round,
        {
            const int FULL = 52; // an integar constant which is equal to the amount of cards in a proper deck for this game
            string[] deck = new string[FULL]; // a deck created named deck is set to expect to have 52 slots filled with data
            int[] Ref = new int[12]; // an integar used that indicates only to randomize the twelve first cards of the deck to save time
            FullCardDeck(deck, Ref); // This method has to do with an entire 52 deck of cards, this will be describe below. 
            ShuffleDeck(deck, FULL); //This method then shuffles the deck created by FullCardDeck
            int guessAmt = 0; // This integar is used later in this method to track the amt of correct guesses
            int missedAmt = 0; // This integar used to correct the amt of misses
            int i = 0; // an integar that is used to progress to the next card that has been randomized before hand in the sequence

            while (!Continue(missedAmt, guessAmt, verification)) // A check similar to the check found at the beginning of blasters, it checks the guessamt and missedamt values to see if the user has won or lost
            {
                System.Console.WriteLine("The current card is ");
                CardGraphic(deck, i); // This array stores a card graphic corresponding to every card in the deck. It is randomized in parralle to FullCardDeck
                System.Console.WriteLine(deck[i]); // Writes out that card graphic
                System.Console.WriteLine("Is the next card: \n 1) Higher \n 2) Lower:");
                System.Console.WriteLine("You are currently at: " + guessAmt + " guesses");
                System.Console.Write("Please enter the number associated with your guess:");
                CheckChoice(deck, ref guessAmt, ref missedAmt, i, ref verification); // Checks to see if user guess of higher or lower was correct, covered later
                if (verification == true) // this variable will be explained later
                {
                    i++;
                    guessAmt++;


                }
                if (verification == false)
                {
                    

                    if (guessAmt < 5) // If the user makes an incorrect guess before getting to 5 correct guesses, they lose all of their bet
                    {
                        
                        tokens = tokens - bet;
                        WinLossCheck(ref tokens); 
                        System.Console.WriteLine("You LOST, press any key to cont.");
                        System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!");
                        int userChoice = int.Parse(Console.ReadLine());
                        while ((userChoice != 2) && (userChoice != 1)) // If the user doesnt press 1 or 2 corresponding to the cw above, they will be told it is an invalid input
                        {
                            System.Console.WriteLine("Invalid Choice.");
                            System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!");
                            userChoice = int.Parse(Console.ReadLine());
                        }

                        if (userChoice == 1) // Restarts the force, just like if the user had chosen it off of the Main Menu
                        {
                            bet = 0;
                            PlaceBetTheForce(ref tokens);
                            PlayTheForce(ref  forceW, ref  forceL, ref tokens, bet, verification);

                        }
                        if (userChoice == 2) // returns to main menu
                        {
                            MainMenu(tokens);

                        }

                    }

                    if (guessAmt == 10) // 10 correct guess means the user has guessed all cards correctly and has tripled their bet.
                    {
                        tokens = tokens + bet * 3;
                        WinLossCheck(ref tokens);
                        System.Console.WriteLine("You TRIPPLED your bet, press any key to continue");
                        System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!");
                        int userChoice = int.Parse(Console.ReadLine());
                        while ((userChoice != 2) && (userChoice != 1)) // check for invalid
                        {
                            System.Console.WriteLine("Invalid Choice.");
                            System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!");
                            userChoice = int.Parse(Console.ReadLine());
                        }

                        if (userChoice == 1) //Replay
                        {
                            bet = 0;
                            PlaceBetTheForce(ref tokens);
                            PlayTheForce(ref  forceW, ref  forceL, ref tokens, bet, verification);

                        }
                        if (userChoice == 2) //MainMenu
                        {
                            MainMenu(tokens);

                        }

                    }
                         if (guessAmt == 7 || guessAmt == 8 || guessAmt == 9) // if  guesses is greater than 6 and less than 10, they double their bet
                    {
                        
                        tokens = tokens + bet * 2;
                        WinLossCheck(ref tokens);
                        System.Console.WriteLine("You DOUBLED your bet, press any key to cont.");
                        System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!");
                        int userChoice = int.Parse(Console.ReadLine());
                        while ((userChoice != 2) && (userChoice != 1))
                        {
                            System.Console.WriteLine("Invalid Choice.");
                            System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!");
                            userChoice = int.Parse(Console.ReadLine());
                        }

                        if (userChoice == 1)
                        {
                            bet = 0;
                            PlaceBetTheForce(ref tokens);
                            PlayTheForce(ref  forceW, ref  forceL, ref tokens, bet, verification);

                        }
                        if (userChoice == 2)
                        {
                            MainMenu(tokens);

                        }
                    }
                    if (5 == guessAmt || guessAmt == 6) // if correct guesses is greater than four and less than seven, the user gets their bet back bot no reward.
                    {
                        
                        tokens = tokens + bet;
                        WinLossCheck(ref tokens);
                        System.Console.WriteLine("You broke even, press any key to cont. ");
                        System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!");
                        int userChoice = int.Parse(Console.ReadLine());
                        while ((userChoice != 2) && (userChoice != 1))
                        {
                            System.Console.WriteLine("Invalid Choice.");
                            System.Console.WriteLine("Press 1 to play again, or 2 to return to the main menu!");
                            userChoice = int.Parse(Console.ReadLine());
                        }

                        if (userChoice == 1)
                        {
                            bet = 0;
                            PlaceBetTheForce(ref tokens);
                            PlayTheForce(ref  forceW, ref  forceL, ref tokens, bet, verification);

                        }
                        if (userChoice == 2)
                        {
                            MainMenu(tokens);

                        }


                    }
                   

                }


            }
        }
        static bool CheckChoice(string[] deck, ref int guessAmt, ref int missedAmt, int i, ref bool verification) // This method decides if the users decision of higher or lower, was correct or incorrect given the next card
        {
            int currentCard = CurrentCard(deck, i); // the current card value is "i" which increase as the game moves through the 10 cards
            int nextCard = NextCard(deck, i + 1); // i + 1 allows for reading the value of the card the follows after the current card the user sees. 
            int translate = int.Parse(Console.ReadLine()); // translate variable takes the 1 (higher) or 2(lower) input from the user and translates it directly to an int

            if (translate == 1) // running a check for higher to see if it was the current condition.
            {
                if (nextCard > currentCard) // the condition that the nextcard is in fact higher than current card
                {

                    System.Console.WriteLine("Next card:" + deck[i + 1]);
                    System.Console.WriteLine("Good Job. Press any key to cont.");
                    Console.ReadKey();
                    Console.Clear();
                    verification = true;
                    return verification;
                }
                else // if the above statement doesnt run, then the guess is wrong and updates the proper variables to end the game. 
                {
                    System.Console.WriteLine("Next card:" + deck[i + 1]);
                    System.Console.WriteLine("Wrong! Press any key to cont. ");
                    Console.ReadKey();
                    Console.Clear();
                    missedAmt++; 
                    verification = false;
                    return verification;

                }


            }
            if (translate == 2 )
            {
                if (nextCard < currentCard)
                {


                    System.Console.WriteLine("Next card:" + deck[i + 1]);
                    System.Console.WriteLine("Good Job. Press any key to cont.");
                    Console.ReadKey();
                    Console.Clear();
                    verification = true;
                    return verification;
                }
                else
                {
                    System.Console.WriteLine("Next card:" + deck[i + 1]);
                    System.Console.WriteLine("Wrong! Press any key to cont. ");
                    Console.ReadKey();
                    Console.Clear();
                    missedAmt++;
                    verification = false;
                    return verification;

                }
            }
            else
            {
                System.Console.WriteLine("Invalid Input. Press any key to cont. ");
                Console.ReadKey();
                Console.Clear();
                verification = false;
                return verification;

            }


        }
        static int CurrentCard(string[] deck, int i) // Just like the NextCard method but for the card currently displayed to the user
        {
            if (deck[i].Contains("Ace"))
            {

                return 1;
            }
            if (deck[i].Contains("2"))
            {

                return 2;
            }
            if (deck[i].Contains("3"))
            {
                return 3;
            }
            if (deck[i].Contains("4"))
            {

                return 4;
            }
            if (deck[i].Contains("5"))
            {

                return 5;
            }
            if (deck[i].Contains("6"))
            {

                return 6;
            }
            if (deck[i].Contains("7"))
            {

                return 7;
            }
            if (deck[i].Contains("8"))
            {

                return 8;
            }
            if (deck[i].Contains("9"))
            {

                return 9;
            }
            if (deck[i].Contains("10"))
            {

                return 10;
            }
            if (deck[i].Contains("Jack"))
            {

                return 11;
            }
            if (deck[i].Contains("Queen"))
            {

                return 12;
            }
            if (deck[i].Contains("King"))
            {

                return 13;
            }
            return 999;

        }
        static void FullCardDeck(string[] deck, int[] Ref) // This creates each card in a 52 deck and is inserted into the deck array for refernce above.
        {
            string[] value = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" }; 
            string[] suit = { "Clubs","Spades", "Hearts",  "Diamonds" };
            int count = 0; // Keeps track of how many cards have been made, once it hits 52 it will have created all the cards 
            for (int i = 0; i < suit.Length; i++) //This for loop creates an integer that starts at 0, suit.Length reads how many items are in the array which is four. Thus given the conditions, i will have stopped once it hits four.
            {
                for (int j = 0; j < value.Length; j++) //This does the same thing except for the cards value which is 13
                {
                    deck[count] = value[j] + " of " + suit[i]; // This create the name for the card, the output will be used to identify the proper graphic to display to the user.
                    count++; // increases the count variable 
                }
            }



        }
        static void ShuffleDeck(string[] deck, int FULL) // with the full dec generated along with the proper card graphic, this method randomizes the entire deck of 52
        {
            for (int i = 0; i < deck.Length; i++) // here the .length has noticed that our deck has 52 spots filled and will thus be valued at 52
            {
                Random rnd = new Random(); // This code randomizes each card into a new array that is randomized and is set back equal to the graphics so that it can remain parrallel
                int j = rnd.Next(FULL);
                string temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }

        }
        static bool Continue(int missedAmt, int guessAmt, bool verification) // A simple check to see if the user has made an incorrect guess after checkchoice
        {
            if (missedAmt != 0 && guessAmt != 10)
            {
                verification = true;
                return verification; // verification is used to see if the program can continue running (true)

            }
            else
            {
                verification = false; // or end
                return verification;
            }
        }




    }
}



























