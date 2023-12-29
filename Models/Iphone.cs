namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    // Implementado!!
    public class Iphone : Smartphone
    {
        public Iphone(string Numero, string Modelo, string IMEI, int Memoria) : base(Numero, Modelo, IMEI, Memoria)
        {
        }

        // Sobrescrever o método "InstalarAplicativo"
        // Implementado!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(nomeApp);
        }
    }
}