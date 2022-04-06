using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Models
{
    internal class Book:IEntity
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string PageCount { get; set; }

        public Book(string name,string authorname,string pagecount)
        {
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
        }

        public int Id => throw new NotImplementedException();

    }
}
