using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone - **FEITO**
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1212341", modelo: "modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Wpp");

Console.WriteLine("");

Console.WriteLine("Smartphone IPhone: ");
Smartphone iphone = new Iphone(numero: "67896767", modelo: "modelo 2", imei: "2222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");