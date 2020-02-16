using ProjetoEntityVO.Shared.ValueObjects;
using System.Collections.Generic;

namespace ProjetoEntityVO.Domain.ValueObjects
{
    public class Documento : ValueObject
    {

        public string RG { get; private set; }
        public string CPF { get; private set; }

        public Documento(string rg, string cpf)
        {
            RG = rg;
            CPF = cpf;
        }

        private Documento() { }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return RG;
            yield return CPF;
        }
    }
}
