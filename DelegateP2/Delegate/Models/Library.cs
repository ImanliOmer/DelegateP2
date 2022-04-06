using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Models
{
    internal class Library : IEntity
    {
        public int BookLimit { get; set; }

       private List<Book> _books = new List<Book> { };









        public int Id => throw new NotImplementedException();
    }
}
