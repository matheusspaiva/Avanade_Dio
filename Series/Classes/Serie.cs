namespace Series
{
    public class Serie : ClasseBase
    {
        private string Nome {get; set; }
        private string Genero {get; set; }
        private int Ano {get; set; }
        private bool Excluido {get; set; }

        public Serie(int Id, string Nome, string Genero, int Ano){
            this.Id = Id;
            this.Nome = Nome;
            this.Genero = Genero;
            this.Ano = Ano;
            this.Excluido= false;

        }
        public int RetornaId(){
            return this.Id;
        }
        public string RetornaNome(){
            return this.Nome;
        }
        
        public string RetornaGenero(){
            return this.Genero;
        }

        public bool RetornaExcluido(){
            return this.Excluido;
        }

        public void SetId(int id){
            this.Id=id;
        }
        public void SetNome(string nome){
            this.Nome = nome;
        }
        
        public void SetGenero(string genero){
            this.Genero = genero;
        }

        public void SetExcluir(){
            this.Excluido =true;
        }        
        
    }
}