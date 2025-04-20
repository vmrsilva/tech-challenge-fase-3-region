using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Region.Domain.Region.Exception
{
    public class RegionAlreadyExistsException : System.Exception
    {
        public RegionAlreadyExistsException() : base(message: "Região já cadastrada.")
        {

        }
    }
}
