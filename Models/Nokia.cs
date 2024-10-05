namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia, que chama a classe base do Smartphone
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) 
        {}

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...\n");
        }
    }
}