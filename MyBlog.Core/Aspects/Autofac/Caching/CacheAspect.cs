﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Core.CrossCuttingConcerns.Caching.Abstract;
using MyBlog.Core.Utilities.Interceptors.Autofac;
using MyBlog.Core.Utilities.IoC;

namespace MyBlog.Core.Aspects.Autofac.Caching
{
	public class CacheAspect : MethodInterception
	{
		private int _duration;
		private ICacheManager _cacheManager;

		public CacheAspect(int duration= 43200)//default 1 month cache
		{
			_duration = duration;
			_cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
		}

		public override void Intercept(IInvocation invocation)
		{
			var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}");
			var arguments = invocation.Arguments.ToList();
			var key = $"{methodName}({string.Join(",",arguments.Select(x=>x?.ToString()??"<Null>"))})";
			if (_cacheManager.IsAdd(key))
			{
				invocation.ReturnValue = _cacheManager.Get(key);
				return;
			}
			invocation.Proceed();
			_cacheManager.Add(key,invocation.ReturnValue,_duration);
		}
	}
}
