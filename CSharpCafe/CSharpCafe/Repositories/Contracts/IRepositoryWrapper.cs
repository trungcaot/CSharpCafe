using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpCafe.Repositories
{
    public interface IRepositoryWrapper
    {
        IPostRepository Post { get; }

        Task SaveAsync();
    }
}
