using Core.Utilities.Results;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Deleted(User user);
        IResult Update(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int Id);
        IDataResult<User> GetByMail(string email);
        IDataResult<List<OperationClaim>> GetClaims(User user);
    }
}
