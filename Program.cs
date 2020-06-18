using System;

namespace SENAI_ifood
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurante maceluc = new Restaurante();
            Cliente vini = new Cliente();
            Pedido pedido1 = new Pedido();
            Pedido pedido2 = new Pedido();
    

            Console.WriteLine("Obrigao por acessar ao ifood \n Este é o Restaurante de Mac & Luc");
            maceluc.NomeFantasia = "Mac & Luc";
            maceluc.Endereco = "Rua Teodoro dos Reis nº 78";
            maceluc.MostrarDados();

            Console.WriteLine("Seus Pedidos: ");

            pedido1.Itens = "Pão Recheado c/ Frango";
            Console.WriteLine(pedido1.Itens);
            pedido2.Itens = "Pão Rechado c/ Frango e mussarela";
            Console.WriteLine(pedido2.Itens);

            pedido1.pagar = "Pagamento Aceito";
            pedido2.pagar = "Pagamento Aceito";

            pedido1.PedidoPago(pedido1.pagar);
            pedido2.PedidoPago(pedido2.pagar);

            pedido1.EntregarPedido();



            

            
           
            
            


        }
    }
}
