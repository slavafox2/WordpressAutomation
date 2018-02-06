using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordpressAutomation;

namespace UnitTestProject1.PostsTests
{
    public class AllPostsTests : WordpressTests
    {

        [TestMethod]
        public void Added_Posts_Show_Up()
        {

            //Go to posts, get post count, store
            ListPostsPage.GoTo(PostType.Posts);


            //Add a new post
            NewPostPage.GoTo();
            NewPostPage.CreatePost("Added posts show up, title")
                .WithBody("Added posts show up, body")
                .Publish();

            //Go to posts, get new post count
            ListPostsPage.GoTo(PostType.Posts);
            Assert.AreEqual(ListPostsPage.PreviousPostCount + 1, ListPostsPage.CurrentPostCount, "Count not matched");

            //Check for added post
            Assert.ItTrue(ListPostsPage.DoesPostExistWithTitle("Added posts show up, title"));

            //Trash post (clean up)
            ListPostsPage.TrashPost("Added posts show up, title");
            Assert.AreEqual(ListPostsPage.PreviousPostCount, ListPostsPage.CurrentPostCount, "Couldn't trash post");


        }
    }
}
