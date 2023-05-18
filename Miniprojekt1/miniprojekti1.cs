using System;

class Arraymin
{
    public int[] array;

    public int min()
    {
        int minimum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                minimum = array[i];
            }
        }
        return minimum;
    }

    static void Main(string[] args)
    {
        Arraymin vargu = new Arraymin();
        int gjatesia;

        bool validInput = false;
        do
        {
            Console.Write("Jepni gjatesine e vargut: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out gjatesia))
            {
                validInput = true;
                vargu.array = new int[gjatesia];
                for (int i = 0; i < gjatesia; i++)
                {
                    Console.Write($"Jepni madhesine e elementit {i + 1} ne varg: ");
                    string hyrjeElement = Console.ReadLine();
                    int element;
                    if (int.TryParse(hyrjeElement, out element))
                    {
                        vargu.array[i] = element;
                    }
                    else
                    {
                        Console.WriteLine(
                            "Ju lutemi jepni nje vlere numerike. Ju lutemi provoni perseri"
                        );
                        i--;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ju lutemi jepni nje vlere numerike. Ju lutemi provoni perseri");
            }
        } while (!validInput);

        int minimum = vargu.min();
        Console.WriteLine($"Vlera minimale ne varg eshte: {minimum}");
    }
}
