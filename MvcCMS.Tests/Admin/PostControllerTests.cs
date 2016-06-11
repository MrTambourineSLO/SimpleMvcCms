using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcCMS.Areas.Admin.Controllers;
using MvcCMS.Data;
using MvcCMS.Models;
using Telerik.JustMock;

namespace MvcCMS.Tests.Admin
{
    [TestClass]
    public class PostControllerTests
    {
        [TestMethod]
        public void Edit_GetRequestSendsPostToVIew()
        {
            //A "mock" id we need to test
            var id = "test-post";
            //Repository is an interface, since we can't make an instance we mock it 
            // w/ help of Telerik JustMockLite
            var repo = Mock.Create<IPostRepository>();
            var controller = new PostController(repo);

            /*Mock a method
             Whenever we call our repo's Get method & we pass an Id
             * we want it to return a new Post that has Id = id;
             */
            Mock.Arrange(() => repo.Get(id)).
                Returns(new Post {Id = id});
            
            
            
            
            //Casting to viewresult which is an implementation of Abstract class ActionResult
            //we use AR in Cs because we're not sure we'll return a view (we could also perform say a redirect.
            var result = (ViewResult) controller.Edit(id);

            var model = (Post) result.Model;


            Assert.AreEqual(id,model.Id);
        }
    }
}
