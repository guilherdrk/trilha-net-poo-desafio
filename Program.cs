using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine($"Smartphone: Nokia");
Smartphone Nokia01 = new Nokia(numero: "212324", modelo: "Modelo 1", imei: "1111111", memoria: 64);
Nokia01.Ligar();
Nokia01.InstalarAplicativo("Instagram");

Console.WriteLine($" \n");

Console.WriteLine($"Smartphone: Iphone");
Smartphone iphone01 = new Iphone(numero: "313234", modelo: "Modelo 2", imei: "2222222", memoria: 128);
iphone01.ReceberLigacao();
iphone01.InstalarAplicativo("Facebook");