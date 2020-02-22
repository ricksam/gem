using System.Collections.Generic;

namespace GEM.Models{
    public class Dash{
        public Dash(){
            Totais = new Totalizadores();
        }
        public Totalizadores Totais { get; set; }
        public int Cod_Comum { get; set; }
        public List<object> Categorias { get; set; }
        public List<object> Vozes { get; set; }
        public List<object> VozesCordas { get; set; }
        public List<object> VozesMadeiras { get; set; }
        public List<object> VozesMetais { get; set; }
        public List<object> Instrumentos { get; set; }
        
    }
}