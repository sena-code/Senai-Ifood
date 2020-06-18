namespace SENAI_ifood
{
    public class Cliente 
    {
        public string Nome {get; set;}
        public string EnderecoAtual {get; set;}

        public Cliente(){
        }
        public Cliente(string nome){
            nome = Nome;
        }
        public Cliente(string nome, string enderecoatual){
            nome = Nome;
            enderecoatual = EnderecoAtual;
        }
        public string MostrarDados(){

           
            return $"O {Nome} está Localizado em {EnderecoAtual}";
        }
        

        
    }
}