// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vítej v kalkulačce");
string pokracovat = "ano";
while (pokracovat == "ano")
{
    Console.WriteLine("Zadej první číslo");
    float a = float.Parse(Console.ReadLine());
    Console.WriteLine("Zadej druhé číslo");
    float b = float.Parse(Console.ReadLine());

    Console.WriteLine("Zvolte si operaci:");
    Console.WriteLine("1 - sčítání");
    Console.WriteLine("2 - odčítání");
    Console.WriteLine("3 - násobení");
    Console.WriteLine("4 - dělení");
    int volba = int.Parse(Console.ReadLine());
    float vysledek = 0;
    switch (volba)
    {
        case 1:
            vysledek = a + b;
            break;
        case 2:
            vysledek = a - b;
            break;
        case 3:
            vysledek = a * b;
            break;
        case 4:
            vysledek = a / b;
            break;
    }
    if ((volba > 0) && (volba < 5))
        Console.WriteLine("Výsledek: {0}", vysledek);
    else
        Console.WriteLine("Neplaná možnost");
    Console.WriteLine("Přeješ si pokračovat dál? [ano/ne]");

    pokracovat = Console.ReadLine();
}
    Console.WriteLine("Děkuji za použití této kalkulačky. Stisknutím klavesy ukončíte program");
    Console.ReadKey();

