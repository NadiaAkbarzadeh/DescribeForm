using DescribeForm.Models;

namespace DescribeForm.Services.Interface
{
    public interface IDescribesService
    {
        List<Describe> GetAllDescribes();
        Describe GetDescribe(int id);
    }
}
