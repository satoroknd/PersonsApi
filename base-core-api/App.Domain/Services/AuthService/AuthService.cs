using App.Common.Classes.Contracts;
using App.Common.Classes.DTO;
using App.Common.Resources;
using App.Domain.Services.HashService;
using App.Domain.Services.PersonService;
using App.Infraestructure.Repositories.Auth;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IHashService _hashService;
        private readonly IMapper _mapper;
        private readonly IPersonService _personService;

        public AuthService(IAuthRepository authRepository, IHashService hashService, IMapper mapper, IPersonService personService)
        {
            _authRepository = authRepository;
            _hashService = hashService;
            _mapper = mapper;
            _personService = personService;
        }

        public UserContract LoginUser(LoginDTO loginDto)
        {
            UserContract userResponse = new UserContract();
            UserContract user = _mapper.Map<UserContract>(_authRepository.GetByEmail(loginDto.Email));
            if (user == null)
            {
                userResponse.Message = ApplicationMessages.UserNoExist;
                return userResponse;
            }

            if (_hashService.HashPassword(loginDto.Password) != user.Password)
            {
                userResponse.Message = ApplicationMessages.PasswordNoMatch;
                return userResponse;
            }
            return user;
        }

        public string RegisterUser(RegisterDTO dto)
        {
            DateTime creationDate = DateTime.Now;
            UserContract userContract = _mapper.Map<UserContract>(dto);
            userContract.Password = _hashService.HashPassword(dto.Password);
            userContract.CreationDate = creationDate;
            string message = "";
            if (dto.Password != dto.PasswordConfirm)
            {
                message = ApplicationMessages.PasswordNoMatch;
                return message;
            }

            _authRepository.RegisterUser(userContract);
            _personService.AddPerson(dto, creationDate);
            message = ApplicationMessages.UserCreatedSucces;
            return message;
        }
    }
}
