using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CollectionDataContext
{
    public class User
    {
        static Random r = new Random();
        public User()
        {
        }
        public User(string name, string firstName)
        {
            Name = name;
            FirstName = firstName;
            Age = r.Next(12, 58);
        }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }

    }

    public class Users : ObservableCollection<User>
    {
        public Users()
        {
            Add(new User("Smtih", "John"));
            Add(new User("Smtih", "Robert"));
            Add(new User("Leroy", "Marc"));
        }
    }

}
