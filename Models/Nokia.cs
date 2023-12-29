namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    // Implementado!!
    public class Nokia : Smartphone
    {
        public Nokia(string Numero, string Modelo, string IMEI, int Memoria) : base(Numero, Modelo, IMEI, Memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(nomeApp);
        }
        // Sobrescrever o método "InstalarAplicativo"
        // Implementado!!
    }
}