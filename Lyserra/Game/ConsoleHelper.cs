using Lyserra.PlayerAndAttributes;
using System;
using System.Threading;



namespace Lyserra.Game
{
    public class ConsoleHelper
    {
        public void showCampaign()
        {
            Console.Clear();
            string line = new string('=', 40);
            string title = "Campaign: The Rise of the Orderbreakers";
            Console.WriteLine(line);
            Console.WriteLine(title.PadLeft((40 + title.Length) / 2));
            Console.WriteLine(line);
            Console.WriteLine();

            string[] story = {
            "Lyserra is a world guided by the Natural Order, a force that determines which pets are born with special eyes.",
            "Only a few are blessed, creating the classifications of Ordained, Eye-Bound, and Unaffined.",
            "The Ordained hold natural power that keeps the world balanced.",
            "The Eye-Bound awaken their abilities through a deep emotional bond with their master.",
            "The Unaffined live normal lives as loyal companions or trusted professionals.",
            "Your journey begins with your pet at the PRt Hall Center, where your true path will be revealed.",
            "",
            "The rise of the Orderbreakers disrupts the Natural Order through the creation of artificial eyes.",
            "These artificial eyes grant unstable power that corrupts pets and spreads mutation across the land.",
            "Villages fall, Ordained pets vanish, and corruption slowly reaches the Hall’s borders.",
            "As a new trainee, you and your pet take on missions to investigate attacks and protect the innocent.",
            "Along the way, you face corrupted beasts and uncover the truth behind the synthetic eye cores.",
            "Every step brings you closer to discovering the destiny of your pet.",
            "",
            "The final stage of the campaign brings you face-to-face with the leader of the Orderbreakers",
            "and the creation of the Artificial King Eye.",
            "Your pet’s strength becomes your greatest weapon, whether it is Ordained, Eye-Bound, or Unaffined.",
            "Unaffined pets support the battle as professionals, protecting civilians and stabilizing the field.",
            "Ordained pets fight beside you to restore the balance that was broken.",
            "Eye-Bound pets serve as the key to breaking the corruption at its core.",
            "In the end, you rise as the Guardian of the Natural Order, restoring harmony to Lyserra."
        };

            foreach (string lineText in story)
            {
                slowWriteLine(lineText);
                Thread.Sleep(350); 
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to return to the Main Menu...".PadLeft((40 + 39) / 2));
            Console.ReadLine();
        }

        public string getInput(string prompt)
        {
            string input;
            do
            {
                string line = new string('=', 40);
                Console.WriteLine(line);
                Console.Write("=== " + prompt);

                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                {
                    Console.Clear();
                    showMessage("Input cannot be empty. Please try again.");
                    Thread.Sleep(700);
                }
            } while (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input));
            return input;
        }

        public string getName(string prompt)
        {
            string name;

                name = getInput(prompt);
                return name;


           
        }

        public void showMessage(string message, int delay = 2000)
        {
            string line = new string('=', 40);
            Console.WriteLine(line);
            Console.WriteLine(message.PadLeft((40 + message.Length) / 2));
            Console.WriteLine(line);
            Thread.Sleep(delay);
            Console.Clear();
        }

        public char getMenuChoice(string title, string[] options, short startIndex = 0)
        {
            string input;
            do
            {
                Console.Clear();
                string line = new string('=', 40);
                Console.WriteLine(line);
                Console.WriteLine(title.PadLeft((40 + title.Length) / 2));
                Console.WriteLine(line);

                for (int i = 0; i < options.Length; i++)
                    Console.WriteLine($"[{i + startIndex}] {options[i]}");

                Console.WriteLine(line);
                
                Console.WriteLine(line);
                Console.Write("=== " + "Select Option: ");

                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                {
                    Console.Clear();
                    showMessage("Input cannot be empty. Please try again.");
                    Thread.Sleep(700);
                }
            } while (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input));
            return input[0];
        }

        public void slowWriteLine(string text, int charDelayMs = 12)
        {
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine();
                return;
            }

            string padded = text.PadLeft((40 + text.Length) / 2);

            foreach (char c in padded)
            {
                Console.Write(c);
                Thread.Sleep(charDelayMs);
            }
            Console.WriteLine();
        }
        public string safePick(string[] arr, char choiceChar)
        {
            if (arr == null || arr.Length == 0) return string.Empty;

            int index;
            while (true)
            {
                if (Char.IsDigit(choiceChar))
                {
                    index = choiceChar - '0';
                    if (index >= 0 && index < arr.Length)
                    {
                        return arr[index];
                    }
                }

                // Invalid choice, show error and ask again
                showMessage($"Invalid choice. Please select a number between 0 and {arr.Length - 1}.");

                // Ulitin ang menu at kunin ulit ang input
                choiceChar = getMenuChoice("Select Option", arr);
            }
        }


        public string pickType(string title, string[] option)
        {
            char choice = getMenuChoice(title, option);
            return safePick(option, choice);
        }
    }
}
