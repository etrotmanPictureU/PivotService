
using Core.Utilities;
using PivotData.DataModel;
using PivotData.Repository;
using PivotDomain.DataPocos;

namespace PivotBusiness
{
    public class UserBusiness : IUserBusiness
    {
        string encryptionKey = "PIVOT99212";
        IUserRepository<PivotEntities> userRepository = null;
        public UserBusiness(IUserRepository<PivotEntities> userRepository)
        {
            this.userRepository = userRepository;
        }


        public int Login(string userName, string password)
        {
            User user = userRepository.GetUser(userName);

            string decryptedPassword = Security.Decrypt(user.Password, encryptionKey);
            if (decryptedPassword == password)
            {
                return 1;
            }
            return 0;
        }

        public int CreateUser(PivotDomain.DataPocos.User user)
        {
            string encryptedPassword = Security.Encrypt(user.Password, encryptionKey);
            user.Password = encryptedPassword;
            return userRepository.Create(user);
           
        }

        public int ChangePassword(int UserKey, string newPassword)
        {
            string encryptedPassword = Security.Encrypt(newPassword, encryptionKey);
           
            return 0;
        }


    }
}
