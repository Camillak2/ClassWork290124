﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork290124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUD.CreateUser(new User("Fedot", "udaloymolodec@mail.ru", 55));
        }
    }
}
