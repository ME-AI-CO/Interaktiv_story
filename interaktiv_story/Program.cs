using System;,

string choice = "";

Console.WriteLine("Du står mitten av en skog!");
Console.WriteLine("På din högra sida finns en Barkträd");
Console.WriteLine("Till vänster finns en stig");
Console.WriteLine("Vart går du? höger eller vänster?");
choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "höger")
{
    Console.WriteLine("Du går mot en stig som leder dig ingen stans");
}
else if (choice == "vänster")
{
    Console.WriteLine("Du kommer fram till en bilgata Vill du bli på körd eller vänta till någon stannar för dig");

  choice = Console.ReadLine();
  choice = choice.ToLower();

  if (choice == "vänta")
  {
    Console.WriteLine("Bra jobbat! Ens om du vänta så fick du tillslut så stanna någon");
    Console.WriteLine("Du kommer till den närmaste staden säkert.");
  }
  else if (choice == "Spring framför bilen för att den ska stanna")
  {
    Console.WriteLine("bättre lycka nästa gång! Du har dött pågrund av att du sprang ut utan några varning och blir påkörd");
    Console.WriteLine("Du är död.");
  }
  else
  {
    Console.WriteLine("WOW! Du var dålig");
  }
}
else
{
  Console.WriteLine("WOW! Du var dålig");
}

Console.WriteLine("Tryck ENTER för att avsluta.");
Console.ReadLine();