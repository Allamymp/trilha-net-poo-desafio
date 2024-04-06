namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
{
    // Construtor da classe Iphone
    public Iphone(string numero, string modelo, string IMEI, int memoria) : base(numero, modelo, IMEI, memoria) {}

    // Sobrescrita do método InstalarAplicativo
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando {nomeApp} no Iphone");
    }
}
}