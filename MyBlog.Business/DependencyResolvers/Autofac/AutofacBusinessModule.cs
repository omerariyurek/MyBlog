﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using MyBlog.Business.Abstract;
using MyBlog.Business.Concrete.Managers;
using MyBlog.Core.Utilities.Interceptors.Autofac;
using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Concrete.EntityFramework;

namespace MyBlog.Business.DependencyResolvers.Autofac
{
	public class AutofacBusinessModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<PostManager>().As<IPostService>();
			builder.RegisterType<EfPostDal>().As<IPostDal>();

			var assembly = System.Reflection.Assembly.GetExecutingAssembly(); //current assembly
			builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(
				new ProxyGenerationOptions()
				{
					Selector = new AspectInterceptorSelector()
				}).SingleInstance();



		}
	}
}
