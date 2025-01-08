string strValorsCampanya;
int numCampanyes;
int numAnellamentsCampanya;
int numTotalAnellamentsCampanya;
Campanyes campanyes;
Console.WriteLine("Entra el nombre de campanyes:");
string input = Console.ReadLine();
if (!string.IsNullOrEmpty(input))
{


    campanyes = new Campanyes();
    numCampanyes = campanyes.NumCampanyes(int.Parse(input));
    while (numCampanyes != 0)
    {
        if (numCampanyes < 0)
        {
            Console.WriteLine("El nombre de campanyes és incorrecte");

        }
        else
        {
            numTotalAnellamentsCampanya = 0;
            for (int i = 0; i < numCampanyes; i++)
            {
                Console.WriteLine("Entra el nombre d'anellaments:");
                do
                    strValorsCampanya = Console.ReadLine();
                while (string.IsNullOrEmpty(strValorsCampanya));
                numAnellamentsCampanya = campanyes.NumAnellamentsCampanya(strValorsCampanya);
                while (numAnellamentsCampanya < 0)
                {
                    if (numAnellamentsCampanya == -1)
                    {
                        Console.WriteLine("L'entrada de l'anellament és incorrecte");
                    }
                    else if (numAnellamentsCampanya == -2)
                    {
                        Console.WriteLine("El número de l'anellament és incorrecte");
                    }
                    else if (numAnellamentsCampanya == -3)
                    {
                        Console.WriteLine("El número de ja anellats és incorrecte");
                    }
                    Console.WriteLine("Entra el nombre d'anellaments:");
                    do
                        strValorsCampanya = Console.ReadLine();
                    while (string.IsNullOrEmpty(strValorsCampanya));
                    numAnellamentsCampanya = campanyes.NumAnellamentsCampanya(strValorsCampanya);
                }

                numTotalAnellamentsCampanya += numAnellamentsCampanya;

            }
            Console.WriteLine($"El nombre d'anellaments ha sigut: {numTotalAnellamentsCampanya}");
        }
        Console.WriteLine("Entra el nombre de campanyes:");
        do
            input = Console.ReadLine();
        while (string.IsNullOrEmpty(input));
        numCampanyes = campanyes.NumCampanyes(int.Parse(input));

    }
    Console.WriteLine("Adeu!");
}
else
{
    Console.WriteLine("Input cannot be null or empty.");
}
