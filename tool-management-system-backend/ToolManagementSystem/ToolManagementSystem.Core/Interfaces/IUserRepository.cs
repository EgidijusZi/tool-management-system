using ToolManagementSystem.Domain.Entities;

namespace ToolManagementSystem.Core.Interfaces
{
    public interface IUserRepository
    {
        User FindByEmail(string email);
        User GetById(Guid id);

        IEnumerable<User> GetAll();

        User Register(User user);

        User Update(User user);

        void Delete(Guid id);
    }
}
