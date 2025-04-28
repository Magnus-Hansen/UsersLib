using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersLib
{
    public class UserRepo
    {
        private List<User> _users { get; set; } = new List<User>();
        private int _nextId { get; set; }

        public UserRepo()
        {
            
        }

        public List<User> GetAll()
        {
            return new List<User>(_users);
        }

        public User Get(int id)
        {
            User? user = _users.Find(p => p.Id == id);
            if (user != null)
            {
                return user;
            }
            return null;
        }

        public User Add(User user)
        {
            user.Validate();
            _nextId++;
            user.Id = _nextId;
            _users.Add(user);
            return user;
        }

        public User Delete(int id)
        {
            if (Get(id) != null)
            {
                User user = Get(id);

                _users.Remove(Get(id));
                return user;
            }
            return null;
        }
    }
}
