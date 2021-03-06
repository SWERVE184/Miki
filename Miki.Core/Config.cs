﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miki
{
	public class Config
	{
		/// <summary>
		/// Discord API Token
		/// </summary>
		[JsonProperty("token")]
		public string Token { get; set; } = "";

		/// <summary>
		/// All user ids with admin access
		/// </summary>
		[JsonProperty("developers")]
		public List<ulong> DeveloperIds { get; set; } = new List<ulong>();

		/// <summary>
		/// Amount of shards for the bot to start
		/// </summary>
		[JsonProperty("shard_count")]
		public int ShardCount { get; set; } = 1;

		/// <summary>
		/// Carbon Server Statistics
		/// </summary>
		[JsonProperty("carbon_api_key")]
		public string CarbonKey { get; set; } = "";

		/// <summary>
		/// Discord.PW Server Statistics
		/// </summary>
		[JsonProperty("discord_pw_api_key")]
		public string DiscordPwKey { get; set; } = "";

		/// <summary>
		/// Discordbots.org Server Statistics
		/// </summary>
		[JsonProperty("discord_bots_api_key")]
		public string DiscordBotsOrgKey { get; set; } = "";

		/// <summary>
		/// Urban API Key (RapidAPI)
		/// </summary>
		[JsonProperty("urban_api_key")]
		public string UrbanKey { get; set; } = "";

		/// <summary>
		/// IMGUR API Key (RapidAPI)
		/// </summary>
		[JsonProperty("imgur_api_key")]
		public string ImgurKey { get; set; } = "";

		/// <summary>
		/// IMGUR Client ID (RapidAPI)
		/// </summary>
		[JsonProperty("imgur_client_id")]
		public string ImgurClientId { get; set; } = "";

		/// <summary>
		/// Rocket League Stats API Key
		/// </summary>
		[JsonProperty("rocket_league_key")]
		public string RocketLeagueKey { get; set; } = "";

		/// <summary>
		/// Steam API Key
		/// </summary>
		[JsonProperty("steam_api_key")]
		public string SteamAPIKey { get; set; } = "";

		/// <summary>
		/// Sentry Error Tracking
		/// </summary>
		[JsonProperty("sentry_io_key")]
		public string SharpRavenKey { get; set; } = "";

		/// <summary>
		/// Datadog API Key
		/// </summary>
		[JsonProperty("datadog_key")]
		public string DatadogKey { get; set; } = "";

		/// <summary>
		/// Datadog Agent host
		/// </summary>
		[JsonProperty("datadog_host")]
		public string DatadogHost { get; set; } = "127.0.0.1";

		/// <summary>
		/// Database connection string
		/// </summary>
		[JsonProperty("connection_string")]
		public string ConnString { get; set; } = "";

		/// <summary>
		/// Cache connection string
		/// </summary>
		[JsonProperty("redis_connection_string")]
		public string RedisConnectionString { get; set; } = "localhost";

		/// <summary>
		/// Miki API route
		/// </summary>
		[JsonProperty("miki_api_base_url")]
		public string MikiApiBaseUrl { get; set; } = "https://api.miki.ai/";

		/// <summary>
		/// Miki API Key
		/// </summary>
		[JsonProperty("miki_api_key")]
		public string MikiApiKey { get; set; } = "";
	}
}
