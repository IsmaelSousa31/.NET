

        public class Cachorro
        {
        public string Nome { get; set; }
        public int Idade { get; set; }


        public Cachorro(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;

        }
            
            
        public void Emitirsom()
        {
            Console.WriteLine($"O cachorro {this.Nome} com a idade {this.Idade } fez Au au!");
        }



        }

