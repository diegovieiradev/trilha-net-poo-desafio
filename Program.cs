using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "55559999", modelo: "3310", imei: "123456789", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "99995555", modelo: "7", imei: "987654321", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("Instagran");
