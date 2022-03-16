using System;

namespace Metodos1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            
            int opcion;
            decimal r;
            decimal num1Ar, numAr2; //Argumento para enviar una copia  de su valor a los metodos

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                //Pedimos una opción
                Console.Write("Escoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));


            //Hacer la operación según la opción escogida
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    r = Restar();// Asignamos a "r"  el valor devuelto por "return"

                    //Mostraremos el resultado, con la información que contiene "r"
                    Console.WriteLine("El resultado de la resta es: {0}", r);

                    break;
                case 3:
                    num1Ar = IngresarNumero("Ingresa el primer nùmero: ");
                    numAr2 = IngresarNumero("Ingresa el segundo nùmero: ");

                    Multiplicar(num1Ar, numAr2);
                    break;
                case 4:
                    num1Ar = IngresarNumero("Ingresa el primer nùmero: ");
                    numAr2 = IngresarNumero("Ingresa el segundo nùmero: ");

                    r = Dividir(num1Ar, numAr2);
                    Console.WriteLine("El resultado de la División es: {0}", r);
                    break;
            }

            //Mostramos el resultado
            //Console.WriteLine("El resultado es: {0}", resultado);
        }

        //MÉTODO SIN PARAMETRO NI TIPO
        static void Suma()
        {
            decimal num1, num2, resultado = 0M;


            //Pedimos los dos números
            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("El resultado es: {0}", resultado);
        }

        //MÉTODO QUE DEVUELVE UN TIPO
        static decimal Restar()
        {
            decimal num1, num2, resultado = 0M;


            //Pedimos los dos números
            Console.Write("Dame el primer número: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Dame el segundo número: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 - num2;

            return resultado;
        }

        //MÉTODO CON PARAMETROS
        static void Multiplicar( decimal numPar1, decimal numPar2)
        {
            decimal resultado;

            resultado = numPar1 * numPar2;

            Console.WriteLine("Resultado {0}", resultado);
        }

        //MÉTODO CON PARAMETRO QUE DEVUELVE UN TIPO
        static decimal Dividir(decimal numPar1, decimal numPar2)
        {
            decimal resultado;

            if (numPar2 != 0)
            {
                resultado = numPar1 / numPar2;
            }
            else
            {
                Console.WriteLine("Divisor no es valido");
                resultado = 0;
            }

            return resultado;
        }

        //MÉTODO PARA RECIBIR LOS NUMEROS
        static decimal IngresarNumero(string peticion)
        {
            //Variable local al método
            decimal numero;

            //pedimos el valor segùn corresponda
            Console.WriteLine(peticion);
            //Convertimos y asignamos
            numero = Convert.ToDecimal(Console.ReadLine());

            //Devolvemos el valor de tipo decimal
            return numero;

        }

    }
}
