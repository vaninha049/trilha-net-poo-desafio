using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartfone Nokia");
Smartfone nokia = new Nokia(numero: "123456", Modelo: "Modelo 1", Imei: "1111111111", Memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartfone Iphone");
Smartfone iphone = new Nokia(numero: "4138", Modelo: "Modelo 2", Imei: "22222222222", Memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegran");
