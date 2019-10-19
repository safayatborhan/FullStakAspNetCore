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
    public class SearchController : Controller
    {
        private readonly IPost _postService;

        public SearchController(IPost postService)
        {
            _postService = postService;
        }

        public IActionResult Results(string searchQuery)
        {
            var post = _postService.GetFilteredPosts(searchQuery);
            var areNoResults = (!string.IsNullOrEmpty(searchQuery) && !post.Any());
            var postListings = post.Select(x => new PostListingModel
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
            var model = new SearchResultModel
            {
                Posts = postListings,
                SearchQuery = searchQuery,
                EmptySearchResults = areNoResults
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

        [HttpPost]
        public IActionResult Search(string searchQuery)
        {
            return RedirectToAction("Results", new { searchQuery });
        }
    }
}