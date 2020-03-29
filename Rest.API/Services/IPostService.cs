using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rest.API.Domain;

namespace Rest.API.Services
{
    public interface IPostService
    {
        Task<bool> CreatePostAsync(Post post);
        Task<bool> DeletePost(Guid postId);
        Task<Post> GetPostById(Guid postId);
        Task<List<Post>> GetPosts();
        Task<bool> UpdatePost(Post postToUpdate);
    }
}