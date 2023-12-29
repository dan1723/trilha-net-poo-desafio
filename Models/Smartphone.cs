namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        // Implementar as propriedades faltantes de acordo com o diagrama
        // Implementado!!

        public Smartphone(string Numero, string Modelo, string IMEI, int Memoria)
        {
            this.Numero = Numero;
            this.Modelo = Modelo;
            this.IMEI = IMEI;
            this.Memoria = Memoria;
            // Passar os parâmetros do construtor para as propriedades
            // Implementado!!
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}