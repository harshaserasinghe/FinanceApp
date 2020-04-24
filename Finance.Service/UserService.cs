using AutoMapper;
using Finance.Core.DTOs;
using Finance.Core.Entities;
using Finance.Core.Mappers;
using Finance.Data;
using System.IO;
using System.Linq;

namespace Finance.Service
{
    public class UserService
    {
        public FinanceDbContext finanaceDbContext { get; }
        public Mapper mapper { get; }

        public UserService()
        {
            finanaceDbContext = new FinanceDbContext();
            mapper = new Mapper(new EntityMappingConfig().mapperConfig);
        }

        public UserDto GetUser(string username)
        {
            var user = finanaceDbContext.Users.FirstOrDefault(u => u.Name == username);

            if (user == null)
            {
                user = new User { Name = username };
                finanaceDbContext.Users.Add(user);
                finanaceDbContext.SaveChanges();

                var path = Path.Combine(FileService.UserFilePath, $"user_{user.UserId.ToString()}.xml");
                FileService.SaveOrUpdateEntityToFile(user, path);
            }

            var userDto = mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}
