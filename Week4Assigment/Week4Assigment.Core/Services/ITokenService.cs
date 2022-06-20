using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4Assigment.Core.Configuration;
using Week4Assigment.Core.DTOs;
using Week4Assigment.Core.Models;

namespace Week4Assigment.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);

        ClientTokenDto CreateTokenByClient(Client client);
    }
}
