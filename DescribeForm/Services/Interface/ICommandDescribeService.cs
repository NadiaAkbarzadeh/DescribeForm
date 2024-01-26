using DescribeForm.Models.Command;

namespace DescribeForm.Services.Interface
{
    public interface ICommandDescribeService
    {
        int RegisterDescribe(RegisterDescribeCommand Command);
        void EditDescribe(EditDescribeCommand Command);
        void DeleteDescribe(int id);
    }
}
