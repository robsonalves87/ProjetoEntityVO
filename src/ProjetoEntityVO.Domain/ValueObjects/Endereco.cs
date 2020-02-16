using ProjetoEntityVO.Shared.ValueObjects;
using System.Collections.Generic;

namespace ProjetoEntityVO.Domain.ValueObjects
{
    public class Endereco : ValueObject
    {
        public Endereco(string logradouro, string numero, string complemento, string bairro, string cidade, string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            CEP = cep;
        }

        private Endereco() { }

        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string CEP { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Logradouro;
            yield return Numero;
            yield return Complemento;
            yield return Bairro;
            yield return Cidade;
            yield return CEP;
        }
    }
}
