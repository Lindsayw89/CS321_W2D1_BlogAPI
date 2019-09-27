using System;
using System.Collections.Generic;
using System.Linq;
using CS321_W2D1_BlogAPI.Models;

namespace CS321_W2D1_BlogAPI.Services
{
    public class PostService : IPostService
    {
        // seed some initial Post data
        private List<Post> _posts = new List<Post>()
        {
            new Post
            {
                Id = 1,
                Title = "My first blog post",
                Body = "Blah blah blah"
            },
            new Post
            {
                Id = 2,
                Title = "My second blog post",
                Body = "Blah blah blah"
            },
            new Post
            {
                Id=3,
                Title ="Lindsay's added blog post",
                Body = "This is my important blog post"
            }
        };
        // keep track of next id number
        private int _nextId = 3;

        public Post Add(Post post)
        {
            // assign an id (and then increment _nextId for next time)
            post.Id = _nextId++;
            // store in the list of Posts
            _posts.Add(post);         
            // return the new Post with Id filled in
            return post;
        }

        public Post Get(int id)
        {
            // return the specified Post or null if not found
            // TODO: DONE
            return _posts.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Post> GetAll()
        {
            // TODO: DONE
            return _posts;
        }  

        public Post Update(Post updatedPost)
        {
            // get the Post object in the current list with this id 
            // TODO:DONE
            var currentPost = _posts.FirstOrDefault(p => p.Id == updatedPost.Id);

            // return null if the Post to update isn't found
            if (currentPost == null) return null;
            currentPost.Title = updatedPost.Title;
            currentPost.Body = updatedPost.Body;

            // copy the property values from the updated post into the current post object
            // TODO:DONE

            return currentPost;
        }

        public void Remove(Post post)
        {
            // TODO: DONE 
            var currentPost = _posts.FirstOrDefault(p => p.Id == post.Id);
            if (currentPost != null) _posts.Remove(currentPost);
            
        }
    }
}
