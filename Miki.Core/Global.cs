﻿using SharpRaven;
using System;
using StatsdClient;
using StackExchange.Redis.Extensions.Core;

namespace Miki
{
    /// <summary>
    /// Global data for constant folder structures and versioning.
    /// </summary>
    public class Global
    {
        public static RavenClient ravenClient;
		public static ICacheClient redisClient;
		public static Config config = new Config();

	}
  
	  public class Constants
    {
        public const string NotDefined = "$not-defined";
    }
}