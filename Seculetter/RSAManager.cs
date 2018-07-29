using Newtonsoft.Json;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Seculetter
{
	public class RSAManager : IDisposable
	{
		private RSACryptoServiceProvider Rsa { get; set; } = new RSACryptoServiceProvider();

		public string CreatePublicKey()
		{
			var pub = Rsa.ExportParameters(false);
			return JsonConvert.SerializeObject(new
			{
				pub.Modulus,
				pub.Exponent
			});
		}

		public string CreatePrivateKey()
		{
			var pri = Rsa.ExportParameters(true);
			return JsonConvert.SerializeObject(new
			{
				pri.Modulus,
				pri.Exponent,
				pri.P,
				pri.Q,
				pri.DP,
				pri.DQ,
				pri.InverseQ,
				pri.D
			});
		}

		public string Encrypt(string text, string publicKey)
		{
			var param = JsonConvert.DeserializeObject<Prameters>(publicKey);
			Rsa.ImportParameters(new RSAParameters
			{
				Modulus = param.Modulus,
				Exponent = param.Exponent
			});

			var data = Rsa.Encrypt(Encoding.UTF8.GetBytes(text), false);

			return Convert.ToBase64String(data);
		}

		public string Decrypt(string cipher, string privatekey)
		{
			var param = JsonConvert.DeserializeObject<Prameters>(privatekey);
			Rsa.ImportParameters(new RSAParameters
			{
				Modulus = param.Modulus,
				Exponent = param.Exponent,
				P = param.P,
				Q = param.Q,
				DP = param.DP,
				DQ = param.DQ,
				InverseQ = param.InverseQ,
				D = param.D
			});

			var data = Rsa.Decrypt(Convert.FromBase64String(cipher), false);

			return Encoding.UTF8.GetString(data);
		}

		public void Dispose()
		{
			Rsa.Dispose();
		}

		private class Prameters
		{
			public Prameters() { }

			public Prameters(byte[] modulus, byte[] exponent)
			{
				Modulus = modulus;
				Exponent = exponent;
			}

			public Prameters(byte[] modulus, byte[] exponent, byte[] p, byte[] q, byte[] dp, byte[] dq, byte[] inverseQ, byte[] d)
			{
				Modulus = modulus;
				Exponent = exponent;
				P = p;
				Q = q;
				DP = dp;
				DQ = dq;
				InverseQ = inverseQ;
				D = d;
			}

			public byte[] Exponent;
			public byte[] Modulus;
			public byte[] P;
			public byte[] Q;
			public byte[] DP;
			public byte[] DQ;
			public byte[] InverseQ;
			public byte[] D;
		}
	}
}
