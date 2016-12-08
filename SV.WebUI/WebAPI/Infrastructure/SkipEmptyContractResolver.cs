﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections;
using System.Reflection;

namespace WebAPI.Infrastructure
{
	// from http://stackoverflow.com/a/18486790/4275342
	public class SkipEmptyContractResolver : DefaultContractResolver
	{
		public SkipEmptyContractResolver(bool shareCache = false) : base(shareCache) { }

		protected override JsonProperty CreateProperty(MemberInfo member,
				MemberSerialization memberSerialization)
		{
			JsonProperty property = base.CreateProperty(member, memberSerialization);
			bool isDefaultValueIgnored =
				((property.DefaultValueHandling ?? DefaultValueHandling.Ignore)
					& DefaultValueHandling.Ignore) != 0;
			if (isDefaultValueIgnored
					&& !typeof(string).IsAssignableFrom(property.PropertyType)
					&& typeof(IEnumerable).IsAssignableFrom(property.PropertyType))
			{
				Predicate<object> newShouldSerialize = obj => {
					var collection = property.ValueProvider.GetValue(obj) as ICollection;
					return collection == null || collection.Count != 0;
				};
				Predicate<object> oldShouldSerialize = property.ShouldSerialize;
				property.ShouldSerialize = oldShouldSerialize != null
					? o => oldShouldSerialize(o) && newShouldSerialize(o)
					: newShouldSerialize;
			}
			return property;
		}
	}
}