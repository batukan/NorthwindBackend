﻿namespace Core.CrossCuttingConcerns.Caching.Microsoft
{
    public class MemoryCacheManager:ICacheManager 
    {
        public T Get<T>(string key)
        {
            throw new System.NotImplementedException();
        }

        public object Get(string key)
        {
            throw new System.NotImplementedException();
        }

        public void Add(string key, object data, int duration)
        {
            throw new System.NotImplementedException();
        }

        public bool isAdded(string key)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveByPattern(string pattern)
        {
            throw new System.NotImplementedException();
        }
    }
}