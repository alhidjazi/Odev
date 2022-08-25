using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1  && gamer.FirstName == "osman"&& gamer.LastName == "musa" && gamer.TcNo == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
