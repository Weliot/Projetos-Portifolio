using System.Threading.Tasks;
using TravelApp.Models.TokenAuth;
using TravelApp.Web.Controllers;
using Shouldly;
using Xunit;

namespace TravelApp.Web.Tests.Controllers
{
    public class HomeController_Tests: TravelAppWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}