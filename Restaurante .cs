namespace SENAI_ifood
{
    public class Restaurante 
    {
        public string NomeFantasia {get; set; }
        public string Endereco {get; set;}
        
        public Restaurante()
        {
        }


        public Restaurante(string nomefantasia){

            nomefantasia = NomeFantasia;
        }

        public Restaurante(string nomefantasia, string endereco){
            nomefantasia = NomeFantasia;
            endereco = Endereco;
        }

        
        public string MostrarDados(){

            return $"Nome do restaurante = {NomeFantasia} \n está localizado em {Endereco}";
        }
       
    }
}