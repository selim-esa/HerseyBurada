using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete
{
    public class AdminRepository
    {
        protected readonly DataAccessDbContext _dataAccess;
        private List<User> _user = new List<User>();
        public List<User> GetAll() => _user;
        public void Add(User user)
        {
            _user.Add(user);

        }

        public void Update(User user)
        {
            var hasUser = _user.FirstOrDefault(User => user.Id == user.Id);
            if (hasUser == null)
            {
                throw new Exception($"Bu id sahip Admin bulunamadı");
            }
            hasUser.Email = user.Email;
            hasUser.Id = user.Id;
            hasUser.Name = user.Name;
            hasUser.Password = user.Password;

        }

        public void Remove(int Id)
        {
            var hasUser = _user.FirstOrDefault(p => p.Id == Id);
            if (hasUser != null)
            {
                throw new Exception($"Bu id() sahip Kullanıcı yoktur");
            }
            _user.Remove(hasUser);
        }

    }
}
