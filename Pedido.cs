namespace SENAI_ifood
{
    public class Pedido
    {
        public string Itens {get; set;}
        public string Cliente {get; set;}
        public string Restaurante {get; set;}
        public string PagarMeto {get; set;}
        public string pagar {get; set;}
        public bool PedidoPago(string pagar)
        {

            if(pagar == "Pagamento aceito"){
                return true;
            }
             return false;
        }
        public string EntregarPedido(){

            return "O pedido está a caminho";
        }
        public string PedidoEntrega(string entrega){
            
            if(entrega == "Sim"){
                return "Obrigado pela compra";
            }else if (entrega == "Não"){
                return "Entre em contato com o restaurante";
            } return "Entrega não Realizada";

        }
    }
}