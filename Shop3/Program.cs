using csharp_shop_2;

Console.OutputEncoding = System.Text.Encoding. Unicode;

try
{
    Water ferrarelle = new Water("Acqua", "Frizzante", 2f, "Alimentari", "Sant'Anna", 2.5f, 2f, 7f, "Vinadio");
    Console.WriteLine(ferrarelle);
    ferrarelle.Drink(1.5f);
    ferrarelle.Fill(4f);


} 
catch (Exception ex) //EX E' UNA VARIABILE CHE VIENE PRESA QUANDO ABBIAMO COSTRUITO L'ECCEZIONE 
{
    Console.WriteLine("ERRORE: " + ex.Message); 
}











