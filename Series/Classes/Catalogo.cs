using System.Collections.Generic;

namespace Series
{
    public class Catalogo : AcoesCatalogo<Serie>
    {
        List<Serie> lista = new List<Serie>();
        public  void Adicionar(Serie serie)
        {
             lista.Add(serie);
        }

        public void Alterar(Serie serie)
        {
            int i;
            for(i=0;i<lista.Count ;i++){
                if(serie.RetornaId()==lista[i].RetornaId()){
                    lista[i].SetId(serie.RetornaId());
                    lista[i].SetNome(serie.RetornaNome());
                    lista[i].SetGenero(serie.RetornaGenero());

                }
            }
        }

        public void Excluir(int id)
        {
            int i;
            for(i=0;i<lista.Count ;i++){
                if(id==lista[i].RetornaId()){
                    lista[i].SetExcluir();
                }
            }
        }

        public List<Serie> VerLista()
        {
            return lista;
        }
    }
}