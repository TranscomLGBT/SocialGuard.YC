﻿namespace SocialGuard.YC.Data.Models.Config
{
	public interface IApiConfig
	{
		public string ApiHost { get; set; }
		public string EncryptionKey { get; set; }
	}
}
