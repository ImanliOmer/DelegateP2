﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Exceptions
{
    internal class Exceptionn
    {
        public void CapasityLimitException(int capasity, int count)
        {
            if (count == capasity)
            {
                throw new Exception("capasity is full");
            }
        }
        public void NotFoundException(int? Nfound)
        {
            if (Nfound == null)
            {
                throw new Exception("Not Found");
            }
        }
        public void AllReadyExsistException(int ProductZero)
        {
            if (ProductZero == 0)
            {
                throw new Exception("Product isn't found");
            }
        }


    }
}
