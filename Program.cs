using System;

namespace Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            visa.limite = 3000f;

            Console.WriteLine("Deseja aumentar seu limite? Quanto de acréscimo?");
            float acrescimo = float.Parse(Console.ReadLine());
            
            visa.AumentarLimite(acrescimo);
            Console.WriteLine("Novo limite: R$ "+visa.limite);

            Console.WriteLine("Digite a data do pagamento:");
            visa.data = DateTime.Parse( Console.ReadLine() );
            
            Console.WriteLine("Data: " + visa.data);
        
        
        }

    }
}
