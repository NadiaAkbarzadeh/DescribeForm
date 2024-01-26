using DescribeForm.Models;

namespace DescribeForm.Repositories.Interface
{
    public interface IDescribeRepository
    {
        int CreateDescribe(Describe describe);
        List<Describe> GetAll();

        Describe GetDescribeById(int id);
        void Update(Describe describe);
        void Remove(int id); 
    }
}
