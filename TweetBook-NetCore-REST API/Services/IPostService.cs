﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TweetBook.Domain;

namespace TweetBook_NetCore_REST_API.Services
{
    public interface IPostService
    {
        List<Post> GetPosts();
        Post GetPostById(Guid postId);
        bool UpdatePost(Post postToUpdate);
        bool DeletePost(Guid postId);
    }
}
