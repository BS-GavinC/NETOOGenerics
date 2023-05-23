using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETOOGenerics
{
    public class User<Tid>
    {
        public User(Tid id)
        {
            Id = id;
        }
        public Tid Id { get; set; }

        public bool isMyId(Tid id)
        {
            return id.Equals(Id);
        }
    }

    public class UserClassic<T>
    {
        public int Id { get; set; }

        public bool isMyId(int id)
        {
            return id == Id;
        }
    }


}
