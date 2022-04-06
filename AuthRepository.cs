using BusinessLayer;
using EntityLayer;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementApi
{

    public class AuthRepository : IDisposable
    {
        public AuthRepository()
        {

        }
        //private Object lockObject = new Object();

        public async Task<AdminEntity> FindUser(string identifiant,string password, string clientId)
        {
            // var hashPasswod = Helper.GetHash(password);
            var passwordHashed = Helper.GetHash(password);
            var convertIdentifian = "";
            if (identifiant.Contains('~'))
            {
                convertIdentifian = identifiant.Replace("~", "+");
            }
            else
            {
                convertIdentifian = identifiant;
            }
            if (clientId == EntityLayer.Constants.SellerAppClientId)
            {
                // AdminEntity Admin = ManageAdmin.ListAdmin(u => ((u.Identifiant == identifiant || u.Email == identifiant) && u.Password == hashPasswod) && u.Type == AdminType.Customer).FirstOrDefault();
                AdminEntity admin = ManageAdmin.ListAdmin(u => (( u.Email == convertIdentifian || u.Phone == convertIdentifian) && u.Password == passwordHashed)).FirstOrDefault();
                return admin;
            }
            if (clientId == EntityLayer.Constants.ExternalDeliveryAppClientId)
            {
                // UserEntity user = ManageUser.ListUser(u => ((u.Identifiant == identifiant || u.Email == identifiant) && u.Password == hashPasswod) && u.Type == UserType.Customer).FirstOrDefault();
                AdminEntity user = ManageAdmin.ListAdmin(u => ( u.Email == convertIdentifian || u.Phone == convertIdentifian) && u.Password == passwordHashed ).FirstOrDefault();
                return user;
            }
            if (clientId == EntityLayer.Constants.CustomerDeliveryClientId)
            {
                // UserEntity user = ManageUser.ListUser(u => ((u.Identifiant == identifiant || u.Email == identifiant) && u.Password == hashPasswod) && u.Type == UserType.Customer).FirstOrDefault();
                AdminEntity user = ManageAdmin.ListAdmin(u => ( u.Email == convertIdentifian || u.Phone == convertIdentifian) && u.Password == passwordHashed ).FirstOrDefault();
                return user;
            }
            else
            {
                //  UserEntity user = ManageUser.ListUser(u => ((u.Identifiant == identifiant || u.Email == identifiant) && u.Password == hashPasswod) && u.Type == UserType.Seller).FirstOrDefault();
                AdminEntity user = ManageAdmin.ListAdmin(u => ( u.Email == convertIdentifian || u.Phone == convertIdentifian) && u.Password == passwordHashed).FirstOrDefault();

                return user;
            }

        }
        public async Task<AdminEntity> FindUserByToken(string identifiant, string fbToken)
        {
            AdminEntity user = ManageAdmin.ListAdmin(u => u.Phone == identifiant).FirstOrDefault();
            return user;
        }


        public ClientEntity FindClient(string clientId)
        {
            var client = ManageClient.ListClients().FirstOrDefault(u => u.Id == clientId);

            return client;
        }

        public async Task<bool> AddRefreshToken(RefreshTokenEntity token)
        {
            var newRefreshResult = false;
            lock (token)
            {
                var existingToken = ManageRefreshTokens.ListRefreshTokens().SingleOrDefault(r => r.Subject == token.Subject && r.ClientId == token.ClientId);

                if (existingToken != null)
                {
                    RemoveRefreshToken(existingToken);
                }

                newRefreshResult = ManageRefreshTokens.NewRefreshToken(token);
            }
            return newRefreshResult;
        }

        public async Task<bool> RemoveRefreshToken(string refreshTokenId)
        {
            var refreshToken = ManageRefreshTokens.ListRefreshTokens().FirstOrDefault(r => r.Id == refreshTokenId);

            if (refreshToken != null)
            {
                return ManageRefreshTokens.DeleteRefreshToken(refreshToken);
            }
            return false;
        }

        public bool RemoveRefreshToken(RefreshTokenEntity refreshToken)
        {
            return ManageRefreshTokens.DeleteRefreshToken(refreshToken);
        }

        public async Task<RefreshTokenEntity> FindRefreshToken(string refreshTokenId)
        {
            var refreshToken = ManageRefreshTokens.ListRefreshTokens().FirstOrDefault(r => r.Id == refreshTokenId);

            return refreshToken;
        }

        public List<RefreshTokenEntity> GetAllRefreshTokens()
        {
            return ManageRefreshTokens.ListRefreshTokens();
        }

        public void Dispose()
        {
        }
    }
}