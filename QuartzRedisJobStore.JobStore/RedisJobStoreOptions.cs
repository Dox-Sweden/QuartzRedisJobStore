using System;
using System.Collections.Generic;

namespace QuartzRedisJobStore.JobStore
{
    public class RedisJobStoreOptions
    {
        public IDictionary<Type, Type> JobTypeMap { get; set; }
    }
}
