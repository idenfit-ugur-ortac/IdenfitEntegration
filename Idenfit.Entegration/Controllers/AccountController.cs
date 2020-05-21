using Idenfit.Entegration.Models;
using Idenfit.Entegration.Models.Account;
using Idenfit.Entegration.Models.Audit;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace Idenfit.Entegration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private IdenfitClient IdenfitClient = new IdenfitClient();

        [Route("InsertCustomer")]
        public ServerResult InsertCustomer()
        {

            Customer customer = new Customer()
            {
                address = "Pendik",
                city = "Istanbul",
                country = "Turkey",
                email = "test@test.com",
                executiveName = "TEST EMPLOYEE",
                executivePhone = "+905555555555",
                image = "",
                module = (int)(Modules.Module.Guard | Modules.Module.Task | Modules.Module.Audit),
                name = "TEST CUSTOMER",
                phone = "+905555555555",
                taxNo = 100200300,
                taxOffice = "ISTANBUL VD.",
                zipCode = "34000"
            };

            return IdenfitClient.Insert("v1/customer", customer);
        }

        [Route("UpdateCustomer")]
        public ServerResult UpdateCustomer()
        {
            string id = "ONLY UUID";

            Customer customer = new Customer()
            {
                address = "Pendik",
                city = "Istanbul",
                country = "Turkey",
                email = "test@test.com",
                executiveName = "TEST EMPLOYEE",
                executivePhone = "+905555555555",
                image = "",
                module = (int)(Modules.Module.Guard | Modules.Module.Task | Modules.Module.Audit),
                name = "TEST CUSTOMER UPDATED",
                phone = "+905555555555",
                taxNo = 100200300,
                taxOffice = "ISTANBUL VD.",
                zipCode = "34000"
            };

            return IdenfitClient.Update("v1/customer/" + id, customer);
        }

        [Route("DeleteCustomer")]
        public ServerResult DeleteCustomer()
        {
            string id = "ONLY UUID";

            return IdenfitClient.Delete("v1/customer/"+ id);
        }

        [Route("InsertBranch")]
        public ServerResult InsertBranch()
        {

            Branch customer = new Branch()
            {
                address = "Pendik",
                city = "Istanbul",
                country = "Turkey",
                email = "test@test.com",
                executiveName = "TEST EMPLOYEE",
                executivePhone = "+905555555555",
                image = "",
                module = (int)(Modules.Module.Guard | Modules.Module.Task | Modules.Module.Audit),
                name = "TEST BRANCH",
                phone = "+905555555555",
                taxNo = 100200300,
                taxOffice = "ISTANBUL VD.",
                zipCode = "34000",
                customer="ONLY UUID",
                entegrationOn=true,
                entegrationTag="",
                gmt=180,
                latitude=0,
                longitude=0,
                radius=100,
                userInformationText=""
            };

            return IdenfitClient.Insert("v1/branch", customer);
        }

        [Route("UpdateBranch")]
        public ServerResult UpdateBranch()
        {
            string id = "ONLY UUID";

            Branch customer = new Branch()
            {
                address = "Pendik",
                city = "Istanbul",
                country = "Turkey",
                email = "test@test.com",
                executiveName = "TEST EMPLOYEE",
                executivePhone = "+905555555555",
                image = "",
                module = (int)(Modules.Module.Guard | Modules.Module.Task | Modules.Module.Audit),
                name = "TEST BRANCH",
                phone = "+905555555555",
                taxNo = 100200300,
                taxOffice = "ISTANBUL VD.",
                zipCode = "34000",
                entegrationOn = true,
                entegrationTag = "",
                gmt = 180,
                latitude = 0,
                longitude = 0,
                radius = 100,
                userInformationText = ""
            };

            return IdenfitClient.Update("v1/branch/" + id, customer);
        }

        [Route("DeleteBranch")]
        public ServerResult DeleteBranch()
        {
            string id = "ONLY UUID";

            return IdenfitClient.Delete("v1/branch/" + id);
        }
    }
}
