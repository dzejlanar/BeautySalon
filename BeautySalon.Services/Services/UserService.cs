using AutoMapper;
using BeautySalon.Model;
using BeautySalon.Model.Requests;
using BeautySalon.Model.SearchObjects;
using BeautySalon.Model.ViewModels;
using BeautySalon.Services.Database;
using BeautySalon.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace BeautySalon.Services.Services
{
    public class UserService : CRUDService<UserVM, User, UserSearchObject, UserInsertRequest, UserUpdateRequest>, IUserService
    {
        public UserService(BeautySalonContext context, IMapper mapper) : base(context, mapper) { }

        public override IQueryable<User> AddFilter(IQueryable<User> query, UserSearchObject? searchObject)
        {
            var queryable = base.AddFilter(query, searchObject).Include(q => q.UserRoles).ThenInclude(ur => ur.Role);

            if (!string.IsNullOrWhiteSpace(searchObject?.FirstLastNameGT))
            {
                return queryable.Where(q => (q.FirstName + " " + q.LastName).StartsWith(searchObject.FirstLastNameGT));
            }

            if (!string.IsNullOrWhiteSpace(searchObject?.Email))
            {
                return queryable.Where(q => q.Email.Equals(searchObject.Email));
            }

            return queryable;
        }

        public override UserVM Insert(UserInsertRequest insertObject)
        {
            ValidatePassword(insertObject.Password, insertObject.PasswordConfirmation);

            var model = base.Insert(insertObject);

            insertObject.RoleIds.ForEach(roleId =>
            {
                var role = _context.Roles.Find(roleId);
                if (role != null) {
                    var userRole = new UserRole
                    {
                        RoleId = roleId,
                        UserId = model.UserId,
                        UpdatedDate = DateTime.Now
                    };

                    _context.Add(userRole);
                }
            });

            _context.SaveChanges();
            return model;
        }

        public override UserVM? Update(int id, UserUpdateRequest updateObject)
        {
            var entityToUpdate = _context.Users.Find(id);

            if (entityToUpdate == null)
                return null;

            if (!string.IsNullOrWhiteSpace(updateObject.Password) && !string.IsNullOrWhiteSpace(updateObject.PasswordConfirmation))
            {
                ValidatePassword(updateObject.Password, updateObject.PasswordConfirmation);

                var salt = GenerateSalt();
                entityToUpdate.PasswordSalt = salt;
                entityToUpdate.PasswordHash = GenerateHash(salt, updateObject.Password);
            }

            entityToUpdate.FirstName = updateObject.FirstName;
            entityToUpdate.LastName = updateObject.LastName;
            entityToUpdate.IsActive = updateObject.IsActive;
            entityToUpdate.Gender = updateObject.Gender;
            entityToUpdate.DateOfBirth = updateObject.DateOfBirth;
            
            if (!string.IsNullOrEmpty(updateObject.Address))
                entityToUpdate.Address = updateObject.Address;

            if (updateObject.AppointmentCount != null)
                entityToUpdate.AppointmentCount = updateObject.AppointmentCount;

            entityToUpdate.UpdatedDate = DateTime.Now;

            var model = _mapper.Map<UserVM>(entityToUpdate);

            updateObject.RoleIds.ForEach(roleId =>
            {
                var role = _context.Roles.Find(roleId);
                if (role != null)
                {
                    var userRole = new UserRole
                    {
                        RoleId = roleId,
                        UserId = model.UserId,
                        UpdatedDate = DateTime.Now
                    };

                    _context.Add(userRole);
                }
            });

            _context.SaveChanges();
            return model;
        }

        public override void BeforeInsert(User entity, UserInsertRequest insertObject)
        {
            var salt = GenerateSalt();
            entity.PasswordSalt = salt;
            entity.PasswordHash = GenerateHash(salt, insertObject.Password);
            entity.CreatedDate = DateTime.Now;
        }

        public static string GenerateSalt()
        {
            var byteArray = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(byteArray);

            return Convert.ToBase64String(byteArray);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public UserVM? Login(string username, string password)
        {
            var userEntity = _context.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).FirstOrDefault(u => u.Username.Equals(username));

            if (userEntity == null)
                return null;

            var passwordHash = GenerateHash(userEntity.PasswordSalt, password);

            if (!passwordHash.Equals(userEntity.PasswordHash))
                return null;

            return _mapper.Map<UserVM>(userEntity);
        }

        private void ValidatePassword(string password, string passwordConfirmation)
        {
            if (!password.Equals(passwordConfirmation))
                throw new UserException("Password and password confirmation must be the same.");
        }
    }
}
