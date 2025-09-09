/*Praveer Smith
 * MIST352-001-Fall2025
 * Task2
 * This follows and translates the pseudocode allowing the user to to enter their name, favorite place, and lucky number; then it procedes to print out a special message 
 * describing the user and their information*/





namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask person to put their name in
            Console.Write("Enter hero name: ");
            string heroName = Console.ReadLine();
            //ask them to put their favorite place in
            Console.Write("Enter favorite place: ");
            string favoritePlace = Console.ReadLine();
            //enter their favorite number in
            Console.Write("Enter lucky number: ");
            string luckyNumberText = Console.ReadLine();
            //this removes any extra spaces from the persons inputs
            heroName = heroName.Trim();
            favoritePlace = favoritePlace.Trim();
            //make the lucky number into an integer
            bool parsedOkay = int.TryParse(luckyNumberText, out int luckyNumber);
            //made the rows of text as was having trouble understanding why it was not printing out a description
            string line1 = "Meet " + heroName.ToUpper() + "!";
            string line2 = "Today’s quest starts in " + favoritePlace + ".";
            string line3 = "Lucky number: " + luckyNumber;
            //made abbreviation for the hero name
            string nick = (heroName.Substring(0, 3).ToUpper());
            //this is the quest code
            string code = "#" + nick + "-" + luckyNumber;

            //this puts all information together and foud easier way to make a new line by using \n  
            string report = line1 + "\n" + line2 + "\n" + line3 + "\nQuestCode: " + code;

            //This prints out all the results
            Console.WriteLine();
            Console.WriteLine(report);
            Console.WriteLine("Parse success: " + parsedOkay);
            Console.WriteLine("Hero length: " + heroName.Length);
            Console.WriteLine("Place contains a space: " + (favoritePlace.Contains(" ")));
        }
    }
}
