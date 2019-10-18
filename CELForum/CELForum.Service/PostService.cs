using CELForum.Data;
using CELForum.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELForum.Service
{
    public class PostService : IPost
    {
        private readonly ApplicationDbContext _context;
        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
        }

        public Task AddReply(PostReply reply)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPostContent(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            IEnumerable<Post> post = _context.Posts
                .Include(x => x.User)
                .Include(x => x.Replies)
                    .ThenInclude(y => y.User)
                .Include(x => x.Forum).ToList();
            return post;
        }

        public Post GetById(int id)
        {
            Post post = _context.Posts.Where(x => x.Id == id)
                .Include(x => x.User)
                .Include(x => x.Replies)
                    .ThenInclude(y => y.User)
                .Include(x => x.Forum)
                .FirstOrDefault();
            return post;
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetLatestPosts(int numberOfPost)
        {
            var posts = GetAll().OrderByDescending(x => x.Created).Take(numberOfPost);
            return posts;
        }

        public IEnumerable<Post> GetPostsByForum(int id)
        {
            var posts = _context.Forums.Where(x => x.Id == id).FirstOrDefault().Posts;
            return posts;
        }
    }
}
