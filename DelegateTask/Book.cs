using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTask
{
    class Book
    {
        private static int _totalCount;
        public Book()
        {
            _totalCount++;
            No = _totalCount;
        }
        public int No { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public Genre Type{ get; set; }
        public double Price { get; set; }


    }
}
