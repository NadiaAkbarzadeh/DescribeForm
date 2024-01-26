using DescribeForm.Models;
using DescribeForm.Models.Command;
using DescribeForm.Services.Implementation;
using DescribeForm.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DescribeForm.Controllers
{
    public class DescribeController : Controller
    {
        private readonly ICommandDescribeService commandDescribeService;
        private readonly IDescribesService describesService;

        public DescribeController(ICommandDescribeService commandDescribeService, IDescribesService describesService)
        {
            this.commandDescribeService = commandDescribeService;
            this.describesService = describesService;
        }
        public IActionResult Index()
        {
            var describes = describesService.GetAllDescribes();
            return View(describes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("_Create");
        }
        [HttpPost]
        public async Task<IActionResult> Create(RegisterDescribeCommand command)
        {
            var id = commandDescribeService.RegisterDescribe(command);
            var describes = describesService.GetAllDescribes();
            return PartialView("_TableBody", describes);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var describe = describesService.GetDescribe(id);

            var command = new EditDescribeCommand()
            {
                Id = describe.Id,
                Name = describe.Name,
            };

            return PartialView("_Edit", command);
        }

        [HttpPost]
        public IActionResult Edit(EditDescribeCommand command)
        {
            commandDescribeService.EditDescribe(command);
            var describes = describesService.GetAllDescribes();
            return PartialView("_TableBody", describes);
        }

        [HttpPost]
        public void Delete(int id)
        {
            commandDescribeService.DeleteDescribe(id);
        }
    }
}