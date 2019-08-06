using System.Collections.Generic;
using System.Threading.Tasks;

namespace Beers.Core.Services
{
    public interface IRestService
    {
        Task<IList<Models.Beer>> GetBeers();
    }
}