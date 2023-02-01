using App.Common.Classes.Contracts;
using App.Common.Classes.DTO;
using App.Infraestructure.Database.Entities;
using App.Infrastructure.Database.Context;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infraestructure.Repositories.Auth
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationContext _context;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public AuthRepository(ApplicationContext context, IConfiguration configuration, IMapper mapper)
        {
            _configuration = configuration;
            _context = context;
            _mapper = mapper;
        }

        public UserEntity GetByEmail(string email)
        {
            UserEntity user = _context.Users.Where(p => p.UserName == email).FirstOrDefault();
            return user;
        }

        public void RegisterUser(UserContract userContract)
        {
            if (userContract is not null)
            {
                UserEntity userEntity = _mapper.Map<UserEntity>(userContract);
                this._context.Add(userEntity);
            }
            this._context.SaveChanges();
        }
    }
}
