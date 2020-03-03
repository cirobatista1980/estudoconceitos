using System;

namespace EntityBase
{
    public abstract class Base<T> where T : class
    {
        public DateTime DataInclusao { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        protected Base(DateTime _dataInclusao, DateTime _dataAlteracao)
        {
            DataInclusao = _dataInclusao;
            DataAlteracao = _dataAlteracao;
        }

    }
}
