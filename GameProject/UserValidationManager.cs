using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool ValiDate(Gamer gamer)
        {
            if (gamer.BirthYear == 1994 && gamer.FirstName == "Benjamin" && gamer.LastName == "Onwuachi" && gamer.IdentityNumber==12345)
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
