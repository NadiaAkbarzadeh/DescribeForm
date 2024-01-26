using DescribeForm.Models;
using DescribeForm.Models.Command;
using DescribeForm.Repositories.Interface;
using DescribeForm.Services.Interface;

namespace DescribeForm.Services.Implementation
{
    public class CommandDescribeService : ICommandDescribeService

    {
        private readonly IDescribeRepository describeRepository;

        public CommandDescribeService(IDescribeRepository describeRepository)
        {
            this.describeRepository = describeRepository;
        }
        public int RegisterDescribe(RegisterDescribeCommand command)
        {
            var describe = new Describe()
            {
                Name = command.Name,
            };
            return describeRepository.CreateDescribe(describe);
        }
        public void EditDescribe(EditDescribeCommand command)
        {
           var describe = describeRepository.GetDescribeById(command.Id);

            describe.Name = command.Name;
            describeRepository.Update(describe);


        }
        public void DeleteDescribe(int id)
        {

            describeRepository.Remove(id);
            
        }

     
    }
}
