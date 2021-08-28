using System.Collections.Generic;
namespace Series
{
    public interface AcoesCatalogo<T>
    {
        public void Adicionar(T serie);
        public List<T> VerLista();
        public void Alterar(T serie);
        public void Excluir(int id);
    }
}