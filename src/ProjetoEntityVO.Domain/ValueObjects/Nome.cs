using ProjetoEntityVO.Shared.ValueObjects;
using System.Collections.Generic;

namespace ProjetoEntityVO.Domain.ValueObjects
{
    public class Nome : ValueObject
    {
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; private set; }

        private Nome() { }

        public Nome(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            // Using a yield return statement to return each element one at a time
            yield return PrimeiroNome;
            yield return Sobrenome;
        }
    }
}
