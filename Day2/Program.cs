
string path = Path.Combine(Directory.GetCurrentDirectory(), "strategyGuide.txt");

StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

int opponentScore = 0;
int playerScore = 0;
string oppChoice = "";
string playerChoice = "";
string playerResult = "";
int win = 6;
int tie = 3;
int lost = 0;


while (!textIn.EndOfStream)
{
    string read = textIn.ReadLine();
    string[] currentChoices = read.Split();
    oppChoice = currentChoices[0];
    playerChoice = currentChoices[1];
    // OPPONENT
    // A: Rock   B: Paper  C: Scissors

    //PLAYER
    // X = need to lose   Y: need to draw  Z: need to win

    //POINTS
    // Rock = 1  Paper = 2  Scissors = 3  Win = 6  tie = 3 lost

    if (playerChoice == "X") playerResult = "lost";
    if (playerChoice == "Y") playerResult = "tie";
    if (playerChoice == "Z") playerResult = "win";

    switch (oppChoice)
    {
        case "A":
            if (playerResult == "tie")
            {
                playerScore += tie + 1;
            } else if (playerResult == "win")
            {
                playerScore += win + 2;
            } else if(playerResult == "lost") {
                playerScore += lost + 3;
            }
            break;

        case "B":
            if (playerResult == "lost")
            {
                playerScore += lost + 1;
            }
            else if (playerResult == "tie")
            {
                playerScore += tie + 2;
            }
            else if (playerResult == "win")
            {
                playerScore += win + 3;
            }
            break;
        case "C":
            if (playerResult == "win")
            {
                playerScore += win + 1;
            }
            else if (playerResult == "lost")
            {
                playerScore += lost + 2;
            }
            else if (playerResult == "tie")
            {
                playerScore += tie + 3;
            }
            break;
        default:
            break;
    }

}

Console.WriteLine("Player total score: {0}", playerScore);
Console.WriteLine("Opponent total score: {0}", opponentScore);
