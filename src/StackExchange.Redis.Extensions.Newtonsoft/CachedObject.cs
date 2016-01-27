﻿namespace StackExchange.Redis.Extensions.Newtonsoft
{
	public class CachedObject<T>
	{
		private CachedObject()
		{
		}

		public CachedObject(T cachedValue)
		{
			CachedValue = cachedValue;
		}

		public T CachedValue { get; set; }
	}
}