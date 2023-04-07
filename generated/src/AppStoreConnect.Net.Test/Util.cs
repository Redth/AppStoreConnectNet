using System;

namespace AppStoreConnect.Test
{
	public class Util
	{
		public static Client.AppStoreConnectConfiguration GetConfig()
		{
			var keyId = Environment.GetEnvironmentVariable("APP_STORE_CONNECT_KEY_ID");
			var issuerId = Environment.GetEnvironmentVariable("APP_STORE_CONNECT_ISSUER_ID");
			var privateKey = Environment.GetEnvironmentVariable("APP_STORE_CONNECT_PRIVATE_KEY");

			if (string.IsNullOrEmpty(keyId))
				throw new Exception("APP_STORE_CONNECT_KEY_ID Environment Variable not set");
			if (string.IsNullOrEmpty(issuerId))
				throw new Exception("APP_STORE_CONNECT_ISSUER_ID Environment Variable not set");
			if (string.IsNullOrEmpty(privateKey))
				throw new Exception("APP_STORE_CONNECT_PRIVATE_KEY Environment Variable not set");

			return new Client.AppStoreConnectConfiguration(keyId, issuerId, privateKey);
		}
	}
}
