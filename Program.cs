using System;

namespace SENAI_ifood
{
    class Program
    {
        static void Main(string[] args)
        {
              Cliente eduardo = new Cliente("Eduardo Almeida");
            eduardo.Endereco = "Av. Brasil, 123";
            Restaurante bkKing = new Restaurante("McDonalds", "Av Paulista, 123");

            Pedido pedido1 = new Pedido();
            pedido1.Cliente = eduardo;
            pedido1.Restaurante = bkKing;

            Console.WriteLine( pedido1.EntregarPedido() );
        }
    }
}
