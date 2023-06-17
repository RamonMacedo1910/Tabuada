

int numero;
int resultado;

Console.WriteLine("-=-Tabuada-=-");

Console.WriteLine("Por favor, digite um número:");
numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Tabuada do {numero}");
int numeroMultiplicador = 0;


    while( numeroMultiplicador <= 10)
        {
            resultado = numero * numeroMultiplicador;
            Console.WriteLine($"{numeroMultiplicador} x {numero} = {resultado}");
            numeroMultiplicador +=1;        
        }



