﻿using System.Linq;

namespace BLL.Extensions
{
	public static class QueryableExtensions
	{
		public static PaginatedList<T> ToPaginatedList<T>(this IQueryable<T> query, int pageIndex, int pageSize)
		{
			var totalCount = query.Count();
			var collection = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

			return new PaginatedList<T>(pageIndex, pageSize, totalCount, collection);
		}
	}
}
