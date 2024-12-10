using PracticaEventos;

internal class Program
{
    private static void Main(string[] args)
    {
        Auto auto = new Auto(200);
        auto.CombustibleNegativo += EntroEnReserva;
        auto.Andar(300);
    }

    public static void EntroEnReserva()
    {
        Console.WriteLine("El auto entro en reserva");
    }

}