using CSharpCafe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpCafe.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private CSharpCafeDbContext _context;

        private IPostRepository _post;
        
        public RepositoryWrapper(CSharpCafeDbContext context)
        {
            _context = context;
        }

        public IPostRepository Post
        {
            get
            {
                if (_post == null)
                {
                    _post = new PostRepository(_context);
                }
                return _post;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
