using QuickBuy.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntidy> : IBaseRepositorio<TEntidy> where TEntidy : class
    {
        public BaseRepositorio()
        {
             
        }
        public void Adicionar(TEntidy entidy)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TEntidy entidy)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TEntidy ObterPorID(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntidy> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntidy entidy)
        {
            throw new NotImplementedException();
        }
    }
}
