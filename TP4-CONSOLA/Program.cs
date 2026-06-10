namespace PLA1_TP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEjecutando insertWorkedHours...");
            insertWorkedHours();

            Console.WriteLine("\nEjecutando insertBuyedPens...");
            insertBuyedPens();

            Console.WriteLine("\nEjecutando insertNumHigher...");
            insertNumHigher();
        }

        static void insertWorkedHours()
        {
            const int horasJornada = 48;

            Console.WriteLine("\nIngresar horas trabajadas:");
            float horasTrabajadas = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar valor de hora trabajada:");
            float valorHora = float.Parse(Console.ReadLine());
            float salario = horasTrabajadas * valorHora;

            Console.WriteLine("Salario del trabajador es: " + salario);
            Console.WriteLine("\nLa jornada laboral es de " + horasJornada + " horas");

            if (horasTrabajadas > horasJornada)
                Console.WriteLine("Tiene " + (horasTrabajadas - horasJornada) + " horas extras");
        }
        static void insertBuyedPens()
        {
            const double precioLapiz = 2.5;
            const int descuento = 7;

            Console.WriteLine("\nCantidad de lapices comprados:");
            int lapicesComprados = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio por lapiz: 2,5");

            double precioNeto = precioLapiz * lapicesComprados;
            Console.WriteLine("\nEl costo es: " + precioNeto);

            Console.WriteLine("\nDescuento = " + descuento + "%");
            double precioDescuento = (precioNeto * descuento / 100);
            double precioTotal = double.Abs(precioDescuento - precioNeto);
            Console.WriteLine("es ===> " + precioDescuento);

            Console.WriteLine("\nEl total a pagar es: " + precioTotal);
        }

        static void insertNumHigher()
        {
            double mayor = 0.0;

            Console.WriteLine("\nIngresar el primer numero:");
            float primerNumero = float.Parse(Console.ReadLine());

            if (primerNumero > mayor)
                mayor = primerNumero;

            Console.WriteLine("Ingresar el segundo numero:");
            float segundoNumero = float.Parse(Console.ReadLine());

            if (segundoNumero > mayor)
                mayor = segundoNumero;

            Console.WriteLine("Ingrese el tercer numero:");
            float tercerNumero = float.Parse(Console.ReadLine());

            if (tercerNumero > mayor)
                mayor = tercerNumero;

            Console.WriteLine("\nEl numero mayor es: " + mayor);
        }
    }
}
