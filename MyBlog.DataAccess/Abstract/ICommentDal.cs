﻿using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.DataAccess.Abstract;
using MyBlog.Entities.Concrete;

namespace MyBlog.DataAccess.Abstract
{
	public interface ICommentDal : IEntityRepository<Comment>
	{
		List<Comment> GetAll();
		Comment GetComment(int commentId);
	}
}
