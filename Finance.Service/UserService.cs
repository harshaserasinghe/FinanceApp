using AutoMapper;
using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Core.Mappers;
using Finance.Data;
using System.Linq;

namespace Finance.Service
{
    public class UserService
    {
        private FinanceDbContext FinanaceDbContext { get; set; }
        private IMapper Mapper { get; set; }

        public UserService()
        {
            FinanaceDbContext = new FinanceDbContext();
            Mapper = new Mapper(new EntityMappingConfig().mapperConfig);
        }

        public UserDTO GetUser(string username)
        {
            var user = FinanaceDbContext.Users.FirstOrDefault(u => u.Name == username);

            if (user == null)
            {
                user = new User { Name = username };
                FinanaceDbContext.Users.Add(user);
                FinanaceDbContext.SaveChanges();
            }

            var userDto = Mapper.Map<UserDTO>(user);
            return userDto;
        }

    }
}
