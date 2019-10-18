using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CELForum.Data;
using CELForum.Data.Models;
using CELForum.Models;
using Microsoft.AspNetCore.Mvc;

namespace CELForum.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;
        public ForumController(IForum forumService, IPost postService)
        {
            _forumService = forumService;
            _postService = postService;
        }

        public IActionResult Index()
        {
            IEnumerable<ForumListingModel> forums = _forumService.GetAll().Select(forum => new ForumListingModel {
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description
            });
            var model = new ForumIndexModel
            {
                ForumList = forums
            };
            return View(model);
        }

        public ActionResult Topic(int id)
        {
            Forum forum = _forumService.GetById(id);
            IEnumerable<Post> posts = forum.Posts;

            var postListings = posts.Select(x => new PostListingModel
            {
                Id = x.Id,
                AuthorId = x.User.Id,
                AuthorRating = x.User.Rating,
                AuthorName = x.User.UserName,
                Title = x.Title,
                DatePosted = x.Created.ToString(),
                RepliesCount = x.Replies.Count(),
                Forum = BuildForumListing(x)
            });

            var model = new ForumTopicModel
            {
                Posts = postListings,
                Forum = BuildForumListing(forum)
            };
            return View(model);
        }

        private ForumListingModel BuildForumListing(Post post)
        {
            var forum = post.Forum;
            return BuildForumListing(forum);
        }

        private ForumListingModel BuildForumListing(Forum forum)
        {
            return new ForumListingModel
            {
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description,
                ImageUrl = forum.ImageUrl
            };
        }
    }
}