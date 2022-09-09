#region Task 1

using System.Text;

//void ShowPostiveAndNegative()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        Console.WriteLine($"Positive : {i} {Environment.NewLine}  Negative: {i * -1}");
//    }
//}

//ShowPostiveAndNegative();

#endregion

#region Task 2
//Console.Write("----Enter TExt------");
//    StringBuilder builder = new StringBuilder();
//string input = Console.ReadLine();
//    for (int i = input.Length; i >= 1; i--)
//    {
//        builder.Append(input[i-1]);
//    }
//     Console.WriteLine(builder);
#endregion

#region Task 3


void Task3(int min, int max)
{
    if (max > min)
    {
        Console.WriteLine("Sade ededler");
        for (int i = min; i < max; i++)
        {
              if(i%2!=0)
                Console.WriteLine(i);
        }
    }
    else
        Console.WriteLine("Max must be greater than min");
}

Task3(10, 20);

#endregion

#region Task 4

int[] newArray = new int[0];
int i = 0;
while (true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("If you want to entered number please Y");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Command: ");
    string command = Console.ReadLine().ToUpper();
    if (command == "Y")
    {
        Console.Write(" enter number: ");
        int number;
        bool result = int.TryParse(Console.ReadLine(), out number);
        while (!result)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" enter correctly");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" enter number: ");
            result = int.TryParse(Console.ReadLine(), out number);
        }
        Array.Resize(ref newArray, newArray.Length + 1);
        newArray[i] = number;
        i++;
    }
    else if (newArray.Length == 0)
    {
        Console.WriteLine("A number had to be entered first");
    }
    else
    {

        Console.WriteLine(newArray.Max() - newArray.Min());
        break;
    }
}
#endregion