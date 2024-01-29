using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork290124
{
    public class User
    {
        public User(string name, string email, int age)
        {
            Name = name;
            Email = email;
            Age = age;
        }

        public User(string name, string email, int age, int diplomNumber) : this(name, email, age)
        {
            DiplomNumber = diplomNumber;
        }
        [BsonIgnore]
        public ObjectId _id;
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        [BsonIgnoreIfDefault]
        public int DiplomNumber { get; set; }
    }
}
