using System.Collections.Generic;

namespace GEM.Repository{
    public class Estado{
        public string Sigla{ get; set; }
        public string Nome{ get; set; }

        public static List<Estado> List(){
            return new List<Estado>(){
                new Estado(){ Sigla="AC", Nome="Acre"},
                new Estado(){ Sigla="AL", Nome="Alagoas"},
                new Estado(){ Sigla="AP", Nome="Amapá"},
                new Estado(){ Sigla="AM", Nome="Amazonas"},
                new Estado(){ Sigla="BA", Nome="Bahia"},
                new Estado(){ Sigla="CE", Nome="Ceará"},
                new Estado(){ Sigla="DF", Nome="Distrito Federal"},
                new Estado(){ Sigla="ES", Nome="Espírito Santo"},
                new Estado(){ Sigla="GO", Nome="Goiás"},
                new Estado(){ Sigla="MA", Nome="Maranhão"},
                new Estado(){ Sigla="MT", Nome="Mato Grosso"},
                new Estado(){ Sigla="MS", Nome="Mato Grosso do Sul"},
                new Estado(){ Sigla="MG", Nome="Minas Gerais"},
                new Estado(){ Sigla="PA", Nome="Pará"},
                new Estado(){ Sigla="PB", Nome="Paraíba"},
                new Estado(){ Sigla="PR", Nome="Paraná"},
                new Estado(){ Sigla="PE", Nome="Pernambuco"},
                new Estado(){ Sigla="PI", Nome="Piauí"},
                new Estado(){ Sigla="RJ", Nome="Rio de Janeiro"},
                new Estado(){ Sigla="RN", Nome="Rio Grande do Norte"},
                new Estado(){ Sigla="RS", Nome="Rio Grande do Sul"},
                new Estado(){ Sigla="RO", Nome="Rondônia"},
                new Estado(){ Sigla="RR", Nome="Roraima"},
                new Estado(){ Sigla="SC", Nome="Santa Catarina"},
                new Estado(){ Sigla="SP", Nome="São Paulo"},
                new Estado(){ Sigla="SE", Nome="Sergipe"},
                new Estado(){ Sigla="TO", Nome="Tocantins"},
            };
        }
    }
}