﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WordpressAutomation
{
    public class NewPostPage
    {
        

        public static void GoTo()
        {
            var menuPosts = Driver.Instance.FindElement(By.Id("menu-posts"));
            menuPosts.Click();

            var addNew = Driver.Instance.FindElement(By.LinkText("Add New"));
            addNew.Click();
        }

        public static CreatePostCommand CreatePost(string title)
        {
            return new CreatePostCommand(title);
        }

        public static void GoToNewPost()
        {
            var message = Driver.Instance.FindElement(By.Id("message"));
            var newPostlink = message.FindElements(By.TagName("a"))[0];
            newPostlink.Click();
        }

        public static bool IsInEditMode()
        {
            var array =  Driver.Instance.FindElements(By.TagName("h1"));
            foreach (var el in array)
            {
                if (el.Text == "Edit Page") { return true; }
                              
            }
            return false;
        }

        public static string Title
        {
            get
            {
                var title = Driver.Instance.FindElement(By.Id("title"));
                if (title != null)
                    return title.GetAttribute("value");
                return string.Empty;
            }
        }

    }

    public class CreatePostCommand
    {
        private readonly string title;
        private string body;

        public void Publish()
        {
            Driver.Instance.FindElement(By.Id("title")).SendKeys(title);
            Driver.Instance.SwitchTo().Frame("content_ifr");
            Driver.Instance.SwitchTo().ActiveElement().SendKeys(body);
            Driver.Instance.SwitchTo().DefaultContent();

            Thread.Sleep(1000);

            Driver.Instance.FindElement(By.Id("publish")).Click();
        }

        public CreatePostCommand WithBody(string body)
        {
            this.body = body;
            return this;
        }

        public CreatePostCommand(string title)
        {
            this.title = title;
        }
    }
}
