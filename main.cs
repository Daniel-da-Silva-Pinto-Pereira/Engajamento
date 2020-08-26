using System;
//1. Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação 
//deseja realizar entre esses números. Caso o usuário digitar o caractere “*” será realizada uma multiplicação, 
//caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
//será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.
 
 class MainClass{ 
  public static void Ler2Arq()
  {
  

  double n1, n2 ;
  int resultado = 0;
  

     Console.Write("Digite o primeiro numero: ");
      n1 = double.Parse(Console.ReadLine());

       Console.Write("Digite o segundo numero:");

      n2 = double.Parse(Console.ReadLine()); 

         Console.WriteLine("Para somar digite 1");

      Console.WriteLine("Para subtrair digite 2");

      Console.WriteLine("Para dividir digite 3");

      Console.WriteLine("Para multiplicar digite 4");

      resultado = int.Parse(Console.ReadLine());
      
      switch (resultado) 
      {
        case 1:
            Console.WriteLine("  Soma  = {0}", n1+n2);
            break;
        case 2:
            Console.WriteLine(" Subtração = {0}", n1-n2);
            break;
        case 3:
            Console.WriteLine(" Divisão   = {0}", n1/n2);
            break;
        case 4:
            Console.WriteLine("Multiplicação = {0}", n1 * n2);
            break;
        default:
            Console.WriteLine("Digite um valor válido");
            break;
        }

    
  }
  public static void Main()
  {
    Ler2Arq();
  }
  }
  
  


  
