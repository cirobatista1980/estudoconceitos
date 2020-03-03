using System;

namespace EntityBase
{
    public class Cliente : Base<Cliente>, ICliente
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string NomeCompleto { get => $"{Nome} {Sobrenome}"; }
        public Cliente(DateTime dataInclusao, DateTime dataAlteracao,string _nome, string _sobrenome) : base(dataInclusao, dataAlteracao)
        {
            Nome = _nome;
            Sobrenome = _sobrenome;
        }
    }
}
