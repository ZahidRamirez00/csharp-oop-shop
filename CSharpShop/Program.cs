
using CSharpShop;

Articoli prodotto;
string myString = "";
int codice;
string nome;
string descrizione = "";
int prezzo;
int iva;
bool controllo;

Random codiceRandom = new Random();
codice = codiceRandom.Next(1, 99999999);

Console.Write("Inserisci il nome del prodotto: ");
nome= Console.ReadLine();

Console.Write("Inserisci una descrizione del prodotto: ");
descrizione= Console.ReadLine();

Console.Write("Inserisci il prezzo del prodotto: ");
do
{
    myString = Console.ReadLine();
    if (int.TryParse(myString, out prezzo) )
    {
        controllo = true;
    }
    else
    {
        Console.WriteLine("\nHai inserito un valore errato!!!");
        controllo = false;
        Console.Write("\nInserisci UN NUMERO per define il prezzo del prodotto: ");
    }
} while (!controllo);

Console.Write("Inserisci la percentuale dell'IVA: ");
do
{
    myString = Console.ReadLine();
    if (int.TryParse(myString, out iva))
        if (iva > 0 && iva <= 100)
        {
        controllo = true;
        }
        else 
        {
            Console.WriteLine("\nHai inserito un valore errato!!!");
            controllo = false;
            Console.Write("\nInserisci UN NUMERO 0 a 100 per definire la percentuale dell'IVA: ");
        }
} while (!controllo);

prodotto = new Articoli(codice, nome, descrizione, prezzo, iva);

Console.WriteLine(prodotto.GetCodice());