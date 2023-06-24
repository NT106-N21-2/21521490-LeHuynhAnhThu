using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace RSA
{
    public class RSAKeys // Create size of 2 keys: 4096 bits 
    {
        // SERVER
        public static AsymmetricCipherKeyPair ImportPrivateKey()
        {
            // Get the current directory
            var currentDirectory = Directory.GetCurrentDirectory();
            var basePath = currentDirectory.Split(new string[] { "\\bin" }, StringSplitOptions.None)[0];
            // Read the private key from PEM file
            string keyPath = basePath + "\\key\\privateKey.pem";
            string pem = File.ReadAllText(keyPath);
            // Parse the PEM and retrieve the key pair
            PemReader pr = new PemReader(new StringReader(pem));
            AsymmetricCipherKeyPair keyPair = (AsymmetricCipherKeyPair)pr.ReadObject();
            return keyPair;
        }
        public static string DecryptData(byte[] encryptedDataBytes)
        {
            // Import the private key
            AsymmetricCipherKeyPair keyPair = ImportPrivateKey();
            RsaPrivateCrtKeyParameters privateKey = (RsaPrivateCrtKeyParameters)keyPair.Private;
            RsaEngine engine = new RsaEngine();
            engine.Init(false, privateKey);

            int blockSize = engine.GetInputBlockSize();
            int encryptedDataLength = encryptedDataBytes.Length;
            using (MemoryStream decryptedData = new MemoryStream())
            {   
                // Process the encrypted data in blocks
                for (int i = 0; i < encryptedDataLength; i += blockSize)
                {
                    int blockSizeRemaining = Math.Min(blockSize, encryptedDataLength - i);
                    byte[] decryptedBlock = engine.ProcessBlock(encryptedDataBytes, i, blockSizeRemaining);
                    decryptedData.Write(decryptedBlock, 0, decryptedBlock.Length);
                }
                return Encoding.UTF8.GetString(decryptedData.ToArray());
            }
        }
        // CLIENT
        public static AsymmetricKeyParameter ImportPublicKey()
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var basePath = currentDirectory.Split(new string[] { "\\bin" }, StringSplitOptions.None)[0];
            string keyPath = basePath + "\\key\\publicKey.pem";
            string pem = File.ReadAllText(keyPath);
            PemReader pr = new PemReader(new StringReader(pem));
            AsymmetricKeyParameter publicKey = (AsymmetricKeyParameter)pr.ReadObject();
            return publicKey;
        }
        public static byte[] EncryptData(string data)
        {
            AsymmetricKeyParameter publicKey = ImportPublicKey();
            RsaKeyParameters rsaPublicKey = (RsaKeyParameters)publicKey;
            RsaEngine rsaEngine = new RsaEngine();
            rsaEngine.Init(true, rsaPublicKey);

            int blockSize = rsaEngine.GetInputBlockSize();
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            int dataLength = dataBytes.Length;
            using (MemoryStream encryptedData = new MemoryStream())
            {
                for (int i = 0; i < dataLength; i += blockSize)
                {
                    int blockSizeRemaining = Math.Min(blockSize, dataLength - i);
                    byte[] encryptedBlock = rsaEngine.ProcessBlock(dataBytes, i, blockSizeRemaining);
                    encryptedData.Write(encryptedBlock, 0, encryptedBlock.Length);
                }
                return encryptedData.ToArray();
            }
        }
    }
}
