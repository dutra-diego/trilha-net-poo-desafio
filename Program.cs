using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "4989323892", imei: "111111111", modelo: "Nokia 7", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");


Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "43242342432", imei: "2222222222222", modelo: "iPhone 7", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");