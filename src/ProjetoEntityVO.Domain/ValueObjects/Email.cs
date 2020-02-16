using ProjetoEntityVO.Shared.ValueObjects;
using System.Collections.Generic;

namespace ProjetoEntityVO.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string Endereco { get; private set; }

        public Email(string endereco)
        {
            Endereco = endereco;
        }

        private Email() { }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Endereco;
        }
    }
}
