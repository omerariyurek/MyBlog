﻿using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Business.Abstract;
using MyBlog.Business.BusinessAspects.Autofac.Security;
using MyBlog.Business.Constants;
using MyBlog.Core.Aspects.Autofac.Caching;
using MyBlog.Core.Entities.Concrete;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Core.Utilities.Results.Concrete;
using MyBlog.DataAccess.Abstract;

namespace MyBlog.Business.Concrete.Managers
{
	public class UserManager : IUserService
	{
		private IUserDal _userDal;

		public UserManager(IUserDal userDal)
		{
			_userDal = userDal;
		}

		[CacheAspect(Priority = 2)]
		public IDataResult<List<OperationClaim>> OperationClaims(User user)
		{
			return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
		}

		public IDataResult<User> CheckIfUserNameExists(string userName)
		{
			var userToCheck = _userDal.Get(x => x.UserName == userName);
			if (userToCheck == null)
			{
				return new ErrorDataResult<User>(Messages.UserNotFound);
			}
			return new SuccessDataResult<User>(userToCheck);
		}
	}
}
