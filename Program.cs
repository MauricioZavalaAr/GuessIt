// start
// Your name: Mauricio Zavala
// Date Revised: This is the last day you saved: 17 august, 2022
// Exercise or Lab name: MiniChallenge 8
// Brief Description of what you did. 
// Create a Flowchart.
// Use the Random function to select a number.
// Print if guess is higher or lower than the number guessed.
// Keep track of the number of guesses it took for you to get the right number.
// Made it where user can choose an easy, medium or hard mode before they begin.
// Easy = 1 to 10
// Medium = 1 to 50
// Hard = 1 to 100
// Extra Credit: Allow user to enter in the number range to guess.



// Person who Peer Reviewed your assignment: Angelica Ayala
//Date: 10/25/22
//Game works well. Allows me to select a level and play the game the game again.



bool playAgain = true;
bool validResponse = true;
string UAnswer;
while(playAgain == true) 
{


int numEnter;
bool checkNumber;
int numCounter = 0;
string difEnter;
bool checkUp;
bool checkLow;
int numLower;
int numUpper;

// from what they put in, we need to add 1.

do
{
Console.Write("Welcome to guess the number. Enter ('easy'[1-10], 'medium'[1-50], 'hard'[1-100], or set your own difficulty with 'set') to start: ");
difEnter = Console.ReadLine().ToLower();

if(difEnter != "easy" && difEnter != "medium" && difEnter != "hard" && difEnter != "set")
{
    Console.WriteLine("Please enter valid data.");
}

}while(difEnter != "easy" && difEnter != "medium" && difEnter != "hard" && difEnter != "set");

var random = new Random();
if(difEnter=="easy")
{
    int indexEasy = random.Next(1,11);
    Console.WriteLine("You have entered the game in 'easy' mode (1-10)!");
    do
    {
        do
        {
            Console.Write("Enter your guesed number: ");
            checkNumber = int.TryParse(Console.ReadLine(), out numEnter);
            if(checkNumber==false)
            {
                Console.WriteLine("Please enter valid data.");
            }

        }while(checkNumber==false);
        numCounter++;
        if(numEnter>indexEasy)
        {
            Console.WriteLine($"You are higher than the random number. Your total tries are: {numCounter}.");
        }
        else if(numEnter<indexEasy)
        {
            Console.WriteLine($"You are lower than the random number. Your total tries are: {numCounter}");
        }



    }while(numEnter < indexEasy || numEnter > indexEasy);
    
    Console.WriteLine($"Correct, {numEnter} is the correct number! You made it in 'easy' in {numCounter} tries! Congratulations!");

}

else if(difEnter == "medium")
{
    int indexMedium = random.Next(1,51);
    Console.WriteLine("You have entered the game in 'medium' mode (1-50)!");
    do
    {
        do
        {
            Console.Write("Enter your guesed number: ");
            checkNumber = int.TryParse(Console.ReadLine(), out numEnter);
            if(checkNumber==false)
            {
                Console.WriteLine("Please enter valid data.");
            }

        }while(checkNumber==false);
        numCounter++;
        if(numEnter>indexMedium)
        {
            Console.WriteLine($"You are higher than the random number. Your total tries are: {numCounter}.");
        }
        else if(numEnter<indexMedium)
        {
            Console.WriteLine($"You are lower than the random number. Your total tries are: {numCounter}");
        }



    }while(numEnter < indexMedium || numEnter > indexMedium);
    
    Console.WriteLine($"Correct, {numEnter} is the correct number! You made it in 'medium' in {numCounter} tries! Congratulations!");

}

else if(difEnter == "hard")
{
    int indexHard = random.Next(1,101);
    // needs to be until 101, because its not incluive.
    // minimum is inclusive, maximum is not inclusive.
    Console.WriteLine("You have entered the game in 'hard' mode (1-100)!");
    do
    {
        do
        {
            Console.Write("Enter your guesed number: ");
            checkNumber = int.TryParse(Console.ReadLine(), out numEnter);
            if(checkNumber==false)
            {
                Console.WriteLine("Please enter valid data.");
            }

        }while(checkNumber==false);
        numCounter++;
        if(numEnter>indexHard)
        {
            Console.WriteLine($"You are higher than the random number. Your total tries are: {numCounter}.");
        }
        else if(numEnter<indexHard)
        {
            Console.WriteLine($"You are lower than the random number. Your total tries are: {numCounter}");
        }



    }while(numEnter < indexHard || numEnter > indexHard);
    
    Console.WriteLine($"Correct, {numEnter} is the correct number! You made it in 'hard' in {numCounter} tries! Congratulations!");

}
else if(difEnter == "set")
{
    do{
    Console.WriteLine("Enter the lower number to set it!");
    checkLow = int.TryParse(Console.ReadLine(), out numLower);
    if(checkLow==false)
    {
        Console.WriteLine("Please enter valid data.");
    }
    }while(checkLow==false);
    
    do{
    Console.WriteLine("Enter the upper number to set it!");
    checkUp = int.TryParse(Console.ReadLine(), out numUpper);
    if(checkUp==false || numUpper<=numLower)
    {
        Console.WriteLine("Please enter valid data. Remember it has to be a higher than the lower number.");
    }
    }while(checkUp==false || numUpper<=numLower);

    numUpper = numUpper+1;

    int indexSet = random.Next(numLower,numUpper);
    Console.WriteLine($"You have entered the game in 'set' mode ({numLower}-{numUpper-1})!");
    do
    {
        do
        {
            Console.Write("Enter your guesed number: ");
            checkNumber = int.TryParse(Console.ReadLine(), out numEnter);
            if(checkNumber==false)
            {
                Console.WriteLine("Please enter valid data.");
            }

        }while(checkNumber==false);
        numCounter++;
        if(numEnter>indexSet)
        {
            Console.WriteLine($"You are higher than the random number. Your total tries are: {numCounter}.");
        }
        else if(numEnter<indexSet)
        {
            Console.WriteLine($"You are lower than the random number. Your total tries are: {numCounter}");
        }



    }while(numEnter < indexSet || numEnter > indexSet);
    
    Console.WriteLine($"Correct, {numEnter} is the correct number! You made it in 'set mode' in {numCounter} tries! Congratulations!");

}



validResponse = true;
while(validResponse == true) 
     {
        Console.Write("Do you want to play again? (Y/N): "); 
        UAnswer = Console.ReadLine().ToUpper();
        if (UAnswer == "Y")
        {
            playAgain = true;
            validResponse = false; 
        }
        else if (UAnswer == "N") 
        {
            playAgain = false; 
            validResponse = false; 
        }
        else 
        {
        validResponse = true; 
        playAgain = false; 
        Console.WriteLine(UAnswer + " is not a valid response. Enter a response again");
        }
    }
Console.WriteLine("Thank you for playing!"); 
}


