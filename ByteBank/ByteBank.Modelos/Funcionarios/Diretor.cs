using bytebankAdm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    { 
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override double GetPremioSemestral()
        {
            return Salario + base.GetPremioSemestral();
        }

        public override double AumentarSalario()
        {
            return Salario *= 1.15;
        }

        public Diretor(string Cpf) : base(Cpf, 5000) 
        {

        }
    }
}
