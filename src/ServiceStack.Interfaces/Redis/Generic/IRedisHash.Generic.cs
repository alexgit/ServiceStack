//
// https://github.com/mythz/ServiceStack.Redis
// ServiceStack.Redis: ECMA CLI Binding to the Redis key-value storage system
//
// Authors:
//   Demis Bellot (demis.bellot@gmail.com)
//
// Copyright 2013 Service Stack LLC. All Rights Reserved.
//
// Licensed under the same terms of ServiceStack.
//

using System.Collections.Generic;
using ServiceStack.Model;
using ServiceStack.Model;

namespace ServiceStack.Redis.Generic
{
	public interface IRedisHash<TKey, TValue> : IDictionary<TKey, TValue>, IHasStringId
	{
		Dictionary<TKey, TValue> GetAll();
	}

}
