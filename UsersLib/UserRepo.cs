using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersLib
{
    public class UserRepo
    {
        //private List<User> _users = new List<User>();
        //private SortedList<int, User> _users = new SortedList<int, User>();
        private SortedDictionary<int, User> _users = new SortedDictionary<int, User>();
        private int _nextId { get; set; } = 0;

        public UserRepo()
        {
            Add(new User("testName", "testPassword"));
        }

        public List<User> GetAll()
        {
            //return new List<User>(_users);
            return new List<User>(_users.Values);
        }

        public User? Get(int id)
        {
            //User? user = _users.Find(p => p.Id == id);
            //User? user = _users.GetValueAtIndex(id);
            User? user = _users.FirstOrDefault(p => p.Key == id).Value;
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
            /*user.Id = _nextId;
            _users.Add(user);*/
            _users.Add(_nextId, user);
            return user;
        }

        public User? Delete(int id)
        {
            if (Get(id) != null)
            {
                User user = Get(id);

                //_users.Remove(Get(id));
                //_users.RemoveAt(id);
                _users.Remove(id);
                return user;
            }
            return null;
        }
        /*public User? Update(int id, string? name, string? password)
        {
            if (Get(id) != null) 
            {
                User updatedUser = Get(id);
                if (name != null)
                {
                    updatedUser.UserName = name;
                }
                if (password != null)
                {
                    updatedUser.Password = password;
                }
                return updatedUser;
            }
            return null;
        }*/
    }
}
