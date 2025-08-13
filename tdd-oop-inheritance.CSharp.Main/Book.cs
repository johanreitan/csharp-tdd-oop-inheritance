﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Book : ReadingObject{
        public Author Author { get; set; }
        public Book(string title, Author author) : base(title)
        {
            Author = author;
        }
        
        
    }
}
