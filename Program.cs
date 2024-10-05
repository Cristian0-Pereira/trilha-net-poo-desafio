using System.ComponentModel;
using DesafioPOO.Models;

// NOKIA
Console.WriteLine("Smartphone Nokia:");
Nokia meuNokia = new("123456", "Modelo 1", "123456",  235);
meuNokia.Ligar();
meuNokia.InstalarAplicativo("\"Whatsapp\"");

// IPHONE
Console.WriteLine("Smartphone iPhone:");
Iphone meuIphone = new("543211", "Modelo 2", "9992929", 556);
meuIphone.ReceberLigacao();
meuIphone.InstalarAplicativo("\"Telegram\"");