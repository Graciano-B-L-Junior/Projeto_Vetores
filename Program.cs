using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao programa Vector");
            Vetores v1 = new Vetores(5, 4, 3);

            v1.somaVetores(new Vetores(5, 4, 3));
            Console.WriteLine(v1.x + " " + v1.y + " " + v1.z);

            v1.subtraiVetores(new Vetores(5, 4, 3));
            Console.WriteLine(v1.x + " " + v1.y + " " + v1.z);

            v1.multPorEscalar(3);
            Console.WriteLine(v1.x + " " + v1.y + " " + v1.z);

            v1.Altera(new Vetores(5, 4, 3));
            Console.WriteLine(v1.produtoEscalar(new Vetores(3,-4,5)));


            Console.WriteLine(v1.comprimentoVetor());

            Console.WriteLine(v1.vetorUnitario());
            v1.Altera(new Vetores(5, 4, 3));
            Vetores produtoVetorial = v1.produtoVetorial(new Vetores(8, 4, 3));
            Console.WriteLine(produtoVetorial.x + " " + produtoVetorial.y + " " + produtoVetorial.z);

            Console.WriteLine("Angulo entre vetores "+v1.anguloEntreVetores(new Vetores(6,8,4)));
            v1.Altera(new Vetores(1, 1, 1));
            Vetores teste = v1.vetorProjecao(new Vetores(6, 5, 4));
            Console.WriteLine(teste.x + " " + teste.y + " " + teste.z);
        }
    }
}
