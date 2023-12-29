using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia("14 998774510", "XMPR 2.0", "123456", 128);
Nokia.Ligar();
Nokia.InstalarAplicativo("Facebook");
Console.WriteLine("Aplicativo instalado com sucesso!!");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Iphone("11 991554789", "XRET-G", "88888814", 210);
Nokia.Ligar();
Nokia.InstalarAplicativo("Linkedln");
Console.WriteLine("Aplicativo instalado com sucesso!!");
