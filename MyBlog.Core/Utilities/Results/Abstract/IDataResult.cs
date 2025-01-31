﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Core.Utilities.Results.Abstract
{
	public interface IDataResult<out T> : IResult
	{
		T Data { get; }
	}
}
