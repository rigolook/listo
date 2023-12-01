namespace ExamenR_RLG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista list = new Lista();
            carro carro = new carro();
            for (int i = 0;i < 2; i++)
            {
                Console.WriteLine("Escribe la Marca:");
                carro.Marca = Console.ReadLine();
                Console.WriteLine("Escribe el Modelo:");
                carro.Modelo = Console.ReadLine();

                Console.WriteLine("Escribe el año de lanzamiento(solo el año):");
                carro.Año = Convert.ToInt32(Console.ReadLine());

                list.AgregarCarroFlota(carro);
            }


            list.mostrarFlota();

            Console.WriteLine("Escribe la marca a buscar:");
            string marcas = Console.ReadLine();
            list.busquedaMarca(marcas);

            
        }
    }
}