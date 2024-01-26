using DescribeForm.Models;
using DescribeForm.Repositories.Interface;
using DescribeForm.Services.Interface;

namespace DescribeForm.Services.Implementation
{
    public class DescribesService : IDescribesService
    {
        private readonly IDescribeRepository describeRepository;

        public DescribesService(IDescribeRepository describeRepository)
        {
            this.describeRepository = describeRepository;
        }
        public List<Describe> GetAllDescribes()
        {
            return describeRepository.GetAll();
        }

        public Describe GetDescribe(int id)
        {
            return describeRepository.GetDescribeById(id);
        }
    }
}
