﻿using System;
using System.Collections.Generic;
using System.Text;
using MyBlog.Core.Utilities.Results.Abstract;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.Business.Abstract
{
	public interface IPostService
	{
		IDataResult<Post> GetById(int postId);
		IDataResult<PostDto> GetPostDto(int postId);
		IDataResult<List<PostsDto>> GetPostsDto();
		IDataResult<List<Post>> GetList();
		IResult Add(PostDto postDto);
		IResult Delete(int postId);
		IResult Update(PostDto postDto);
		IResult CheckIfPostTitleExists(string title);
		IDataResult<List<PostTagsDto>> GetPostTags(int postId);
		IDataResult<List<PostCategoriesDto>> GetPostCategories(int postId);
	}
}
