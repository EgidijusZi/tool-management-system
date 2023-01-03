using ToolManagementSystem.Core.Interfaces;
using ToolManagementSystem.Domain.Entities;
using ToolManagementSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ToolManagementSystem.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ToolStoreDbContext _dbContext;
        public UserRepository(ToolStoreDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public User FindByEmail(string email)
        {
            var user = _dbContext.Users.SingleOrDefault(user => user.Email == email);
            return user;
        }
        public User Register(User user)
        {
            user.Id = Guid.NewGuid();
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            return user;
        }

        public void Delete(Guid id)
        {
            var user = _dbContext.Users.SingleOrDefault(user => user.Id == id);

            if (user is null) 
            {
                throw new Exception("User not found");
            }

            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            var users = _dbContext.Users.ToList();
            return users;
        }

        public User GetById(Guid id)
        {
            var user = _dbContext.Users.FirstOrDefault(user => user.Id == id);
            return user;
        }

        public User Update(User user)
        {
            var local = _dbContext.Users
                .Local
                .FirstOrDefault(oldUser => oldUser.Id == user.Id);

            if (local != null)
            {
                _dbContext.Entry(local).State = EntityState.Detached;
            }

            _dbContext.Entry(user).State = EntityState.Modified;
            _dbContext.SaveChanges();

            return user;
        }
    }
}
