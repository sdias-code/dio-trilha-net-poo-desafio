using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("9999-5555", "NK-G60", "352906112950151", 512);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("JW Library");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("8888-4444", "Iphone 11", "352906117758955", 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("JW Language");