using CSharpCafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpCafe.Repositories
{
    public interface IPostRepository : IRepositoryBase<Post>
    {
        Task<IEnumerable<Post>> GetAllPostsAsync();

        Task<Post> GetPostByIdAsync(Guid postId);

        void CreatePost(Post post);

        void UpdatePost(Post post);

        void DeletePost(Post post);
    }
}
