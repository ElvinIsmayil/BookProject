namespace BookProject.Helpers
{
    public class Helper
    {
        public static void ChangeTextColor(ConsoleColor consoleColor, string word)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(word);
            Console.ResetColor();
        }


        public static void Menu()
        {
            Helper.ChangeTextColor(ConsoleColor.Green,
                           "-----------Main Menu-----------\n" +
                           "\nChoose Operation:\n" +
                           "1 - Show All Products\n" +
                           "2 - Get Product by ID\n" +
                           "3 - Create Product\n" +
                           "4 - Delete Product by ID\n");
        }

    }
}



