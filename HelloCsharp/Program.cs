
Console.WriteLine("Benvenuto!");

string[] mesiAnno = { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre" };

Console.WriteLine("I mesi dell'anno sono: ");
for (int i = 0; i < mesiAnno.Length; i++) {
    Console.WriteLine(mesiAnno[i]);
}
 
Console.Write("Inbserisci il tuo mese preferito: ");
var mese = Console.ReadLine();


Console.WriteLine("Arrivederci");