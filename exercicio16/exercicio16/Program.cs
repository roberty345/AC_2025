using System;


public class exercicio16
 {

    public static void Main(string[] args)
    {
        parimpar(7);
    }


    public static bool parimpar(int valor1)
    {
        bool resultado = valor1 % 2 == 0;      
        if (resultado) {
            quadradoNumPar(valor1);

        }
        else
        {
                Console.WriteLine("O  numero não é´par e por isso nãõ é´calculado o valor ao quadrado");
        }     
        return resultado; // True/False
    }
    // Metodo vazio para saber o quadrado 
    public static void quadradoNumPar(int valor2)
    {
        int resutado = valor2 * valor2;
        Console.WriteLine("O quadrado do valor " + valor2 + "é´" + resutado);
        



    }

 }