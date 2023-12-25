using ReadingPleasure.Common.Exceptions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingPleasure.Common.Exceptions.Edition
{
    public class EditionNotFoundException : NotFoundException
    {
        public EditionNotFoundException() : base("Edition was not found")
        {
        }
    }
}
