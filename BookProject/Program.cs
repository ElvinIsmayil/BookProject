using BookProject.Helpers;
using BookProject.Models;
namespace BookProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            ConsoleKeyInfo keyinfo;

            do
            {
                Console.Clear();
                Helper.Menu();

                keyinfo = Console.ReadKey(intercept: true);

                switch (keyinfo.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        try
                        {
                            
                        }
                        catch (Exception ex)
                        {
                            Helper.ChangeTextColor(ConsoleColor.Red, ex.Message);
                        }
                        Pause();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        try
                        {
                            Helper.ChangeTextColor(ConsoleColor.Green, "Enter the ID of the Product: ");
                            if (!int.TryParse(Console.ReadLine(), out int id))
                            {
                                Helper.ChangeTextColor(ConsoleColor.Red, "Invalid input. Please enter a valid number.");
                                Pause();
                                break;
                            }
                            
                            Helper.ChangeTextColor(ConsoleColor.Yellow, wantedProduct);
                        }
                        catch (InvalidIdException ex)
                        {
                            Helper.ChangeTextColor(ConsoleColor.Red, ex.Message);
                        }
                        catch (KeyNotFoundException ex)
                        {
                            Helper.ChangeTextColor(ConsoleColor.Red, ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Helper.ChangeTextColor(ConsoleColor.Red, $"Unexpected error: {ex.Message}");
                        }
                        Pause();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        try
                        {
                            Helper.ChangeTextColor(ConsoleColor.Green, "Enter the Name of the Product: ");
                            string? name = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(name))
                            {
                                Helper.ChangeTextColor(ConsoleColor.Red, "Product name cannot be empty.");
                                Pause();
                                break;
                            }
                            Helper.ChangeTextColor(ConsoleColor.Green, "Enter the Cost price of the Product: ");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal costPrice))
                            {
                                Helper.ChangeTextColor(ConsoleColor.Red, "Invalid input. Please enter a valid decimal number.");
                                Pause();
                                break;
                            }
                            Helper.ChangeTextColor(ConsoleColor.Green, "Enter the Sale price of the Product: ");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal salePrice))
                            {
                                Helper.ChangeTextColor(ConsoleColor.Red, "Invalid input. Please enter a valid decimal number.");
                                Pause();
                                break;
                            }

                            Product product = new Product(name, costPrice, salePrice);
                            productService.Create(product);
                            Helper.ChangeTextColor(ConsoleColor.Green, $"{product.Name} has been successfully created!");
                        }
                        catch (InvalidNameException ex)
                        {
                            Helper.ChangeTextColor(ConsoleColor.Red, ex.Message);
                        }
                        catch (InvalidPriceException ex)
                        {
                            Helper.ChangeTextColor(ConsoleColor.Red, ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Helper.ChangeTextColor(ConsoleColor.Red, $"Unexpected error: {ex.Message}");
                        }
                        Pause();
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        try
                        {
                            Helper.ChangeTextColor(ConsoleColor.Green, "Enter the ID of the Product you want to delete: ");
                            if (!int.TryParse(Console.ReadLine(), out int idDelete))
                            {
                                Helper.ChangeTextColor(ConsoleColor.Red, "Invalid input. Please enter a valid number.");
                                Pause();
                                break;
                            }
                            productService.Delete(idDelete);
                            Helper.ChangeTextColor(ConsoleColor.Green, $"Product with ID: {idDelete} has been successfully deleted!");
                        }
                        catch (InvalidIdException ex)
                        {
                            Helper.ChangeTextColor(ConsoleColor.Red, ex.Message);
                        }
                        catch (KeyNotFoundException ex)
                        {
                            Helper.ChangeTextColor(ConsoleColor.Red, ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Helper.ChangeTextColor(ConsoleColor.Red, $"Unexpected error: {ex.Message}");
                        }
                        Pause();
                        break;

                    case ConsoleKey.Escape:
                        Console.Clear();
                        break;

                    default:
                        Helper.ChangeTextColor(ConsoleColor.Red, "Invalid operation. Please select a valid option.");
                        Pause();
                        break;
                }
            } while (keyinfo.Key != ConsoleKey.Escape);
        }

        static void Pause()
        {
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }

    }
    }
}
