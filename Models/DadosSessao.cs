namespace GEM.Models {
    public class DadosSessao {
        public string Nome{ get; set; }
        public string Comum{ get; set; }
        public int Cod_Usuario { get; set; }
        public int Cod_Comum { get; set; }
        public bool Admin { get; set; }
        public bool Dev { get; set; }
        public bool Instrutor { get; set; }
        public bool Oficializado { get; set; }
        public bool RJM { get; set; }
        public bool Aluno { get; set; }
        public int AvisoLido { get; set; }

        public string Token { get; set; }
    }
}