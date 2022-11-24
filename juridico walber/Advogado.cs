using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juridico
{
    public class advogado
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int idade { get; set; } 
        public char sexo { get; set; }
        public Pais Pais { get; set; }

        public List<Advogado> gettodosAdv()

        {
            return null;
        } 

        public List<Advogado> getNomeCompleto(advogado adv)

        { 
             return this.Nome+" "+this.Sobrenome
        } 

        public List<Advogado> getAdvogadoPorID(int pcodigo)

        {
            return null;
        } 

        public List<Advogado> getAdovogadoporPais(int ppais)

        { 
            return null;
        }
    }
}
