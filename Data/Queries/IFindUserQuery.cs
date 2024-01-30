using InnerCircle.Authentication.Data.Models;

namespace InnerCircle.Authentication.Data.Queries
{
    public interface IFindUserQuery
    {
        Task<User?> FindUserByCorporateEmailAsync(string corporateEmail);
    }
}