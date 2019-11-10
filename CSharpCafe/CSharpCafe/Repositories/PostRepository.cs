using CSharpCafe.Data;
using CSharpCafe.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpCafe.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(CSharpCafeDbContext context)
        : base(context)
        {
        }

        public void CreatePost(Post post)
        {
            Create(post);
        }

        public void DeletePost(Post post)
        {
            Delete(post);
        }

        public async Task<IEnumerable<Post>> GetAllPostsAsync()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<Post> GetPostByIdAsync(Guid postId)
        {
            return await FindByCondition(post => post.Id.Equals(postId)).FirstOrDefaultAsync();
        }

        public void UpdatePost(Post post)
        {
            Update(post);
        }
    }
}
