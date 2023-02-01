using App.Common.Classes.Contracts;
using App.Common.Classes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.AuthService
{
    public interface IAuthService
    {
        string RegisterUser(RegisterDTO registerDto);

        UserContract LoginUser(LoginDTO loginDto);
    }
}
