using System;
using System.Linq;

using NUnit.Framework;
using Til.Mobile.Api.Executer;
using Til.Mobile.Api.Facade;

namespace Til.Mobile.Api.Test
{
    [TestFixture()]
    public class ApiServiceTest
    {
        [Test()]
        public async void GetPosts()
        {
            var apiSettings = new FakeApiSettings();
            var facade = new ApiFacade(new ApiExecuter(apiSettings), apiSettings);
            var result = await facade.GetPosts(0,10);
            Assert.AreEqual(result.Posts.Count,10);
        }
        [Test()]
        public async void Auth()
        {
            var apiSettings = new FakeApiSettings();
            var facade = new ApiFacade(new ApiExecuter(apiSettings), apiSettings);
            var result = await facade.Auth("+79166728879", "929672");
            Assert.IsNotNull(result);
        }
        [Test()]
        public async void Register()
        {
            var apiSettings = new FakeApiSettings();
            var facade = new ApiFacade(new ApiExecuter(apiSettings), apiSettings);
            try
            {
                var result = await facade.Register("+79166728879");
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "User exist");
            }
        }
        [Test()]
        public async void Recover()
        {
            var apiSettings = new FakeApiSettings();
            var facade = new ApiFacade(new ApiExecuter(apiSettings), apiSettings);
            var result = await facade.Recover("+79166728879");
            Assert.IsNotNull(result);

        }


    }
}
