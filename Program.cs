using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "99999-9999", modelo: "G11 Plus", imei: "354523973377537", memoria: 64);
Console.WriteLine("Smartphone Nokia:");
Console.WriteLine(nokia);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("-------------------------------------------");

Smartphone iphone = new Iphone(numero: "98888-8888", modelo: "Iphone 17 Pro Max", imei: "357435933595115", memoria: 256);
Console.WriteLine("Smartphone Iphone:");
Console.WriteLine(iphone);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Uber");
