using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Domains;
using Backend.ViewModels;

namespace Backend.Repository
{
    public interface IFiltro
    {
         Task<List<OfertaViewModel>> Filtro(FiltroViewModel Dados);

    }
}