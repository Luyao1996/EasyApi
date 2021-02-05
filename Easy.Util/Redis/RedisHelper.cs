using System;
using System.Collections.Generic;
using System.Text;
using Easy.Util.Config;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.Options;

namespace Easy.Util.Redis
{
    public class RedisHelper
    {
        private static RedisCache _redisCache = null;
        private static RedisCacheOptions options = null;
        static RedisHelper()
        {
            options = new RedisCacheOptions();
            options.Configuration = ConfigHelper.JobjConfig["Redis"]["ConnectionString"].ToString();
            options.InstanceName = ConfigHelper.JobjConfig["Redis"]["IntanceName"].ToString();
            _redisCache = new RedisCache(options);
        }

        public Get<T> Get(string key, IDistributedCache cacheDb)
    }
}
