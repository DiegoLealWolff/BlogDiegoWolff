using BlogDiegoWolff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDiegoWolff.Services
{
    public interface IBlogService
    {
        List<BlogPost> GetLatestPosts();

        string GetPostText(string link);

        List<BlogPost> GetOlderPosts(int oldestPostId);
    }
}
