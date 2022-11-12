using DesafioPOO.Models;

// Implementado
Console.WriteLine("-------------------- Smartphone Nokia --------------------");
Smartphone nokia = new Nokia(numero: "01511985688740", modelo: "Modelo C30", imei: "001970-01-010000-0", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Twitter");

Console.WriteLine("\n-------------------- Smartphone Iphone --------------------");
Smartphone iphone = new Iphone(numero: "01521998703011", modelo: "Modelo 13 Pro Max", imei: "005826-04-013000-0", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Uber");

