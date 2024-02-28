using System.Security.Cryptography;
using System.Text;

namespace TescatGlobalServer.Helpers
{
    public class AlgorithmAES
    {
        public static string EncryptString(string plainText)
        {
            try
            {
                if (IsBase64String(plainText))
                {
                    // Si ya está en formato base64, devuelve el texto original sin realizar ninguna operación
                    return plainText;
                }
                // Obtiene la clave de la variable de entorno
                string keyBase64 = Environment.GetEnvironmentVariable("LlaveCifrada");

                if (string.IsNullOrEmpty(keyBase64))
                {
                    throw new InvalidOperationException("La variable de entorno no está configurada o es inválida.");
                }

                // Convierte la clave base64 a bytes
                byte[] key = Convert.FromBase64String(keyBase64);

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = key;

                    // Genera un nuevo IV (Initialization Vector) aleatorio para cada encriptación
                    aesAlg.GenerateIV();
                    byte[] iv = aesAlg.IV;

                    // Crea un objeto para almacenar el texto cifrado
                    byte[] encrypted;

                    // Crea un encriptador para realizar la encriptación
                    using (ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, iv))
                    {
                        // Convierte el string a bytes
                        byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

                        // Encripta los bytes
                        encrypted = encryptor.TransformFinalBlock(plainTextBytes, 0, plainTextBytes.Length);
                    }

                    // Combina el IV y el texto cifrado en un solo array de bytes
                    byte[] combinedIvAndCipherText = new byte[iv.Length + encrypted.Length];
                    Array.Copy(iv, 0, combinedIvAndCipherText, 0, iv.Length);
                    Array.Copy(encrypted, 0, combinedIvAndCipherText, iv.Length, encrypted.Length);

                    // Convierte el array combinado a base64 para su fácil almacenamiento y transporte
                    return Convert.ToBase64String(combinedIvAndCipherText);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un problema al desencriptar: " + ex.Message);
                return null;
            }
            
        }
        public static string DecryptString(string cipherText)
        {
            try
            {
                string keyBase64 = Environment.GetEnvironmentVariable("LlaveCifrada");

                if (string.IsNullOrEmpty(keyBase64))
                {
                    throw new InvalidOperationException("La variable de entorno no está configurada o es inválida.");
                }
                byte[] key = Convert.FromBase64String(keyBase64);

                // Convierte el texto cifrado de base64 a bytes
                Console.WriteLine("DesdeAlogritmo" + cipherText);
                byte[] combinedIvAndCipherText = Convert.FromBase64String(cipherText);

                // Extrae el IV (Initialization Vector) del array combinado
                byte[] iv = new byte[16]; // La longitud del IV depende del algoritmo de encriptación utilizado
                Array.Copy(combinedIvAndCipherText, 0, iv, 0, iv.Length);

                // Extrae el texto cifrado del array combinado
                byte[] cipherTextBytes = new byte[combinedIvAndCipherText.Length - iv.Length];
                Array.Copy(combinedIvAndCipherText, iv.Length, cipherTextBytes, 0, cipherTextBytes.Length);

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = key;
                    aesAlg.IV = iv;

                    // Crea un objeto para almacenar el texto descifrado
                    byte[] decryptedBytes;

                    // Crea un desencriptador para realizar la desencriptación
                    using (ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
                    {
                        // Desencripta los bytes
                        decryptedBytes = decryptor.TransformFinalBlock(cipherTextBytes, 0, cipherTextBytes.Length);
                    }
                    // Convierte los bytes descifrados a string
                    return Encoding.UTF8.GetString(decryptedBytes);
                }
            }
            catch (Exception ex)
            {
                // Manejo de cualquier otra excepción que no sea InvalidOperationException
                Console.WriteLine("Ocurrio un problema al desencriptar: " + ex.Message);
                return null;
            }
            
        }
        private static bool IsBase64String(string s)
        {
            // Intenta convertir el string a bytes en base64
            try
            {
                byte[] data = Convert.FromBase64String(s);
                // Decodificación exitosa, devuelve true
                return true;
            }
            catch (FormatException)
            {
                // Si ocurre una excepción, el string no es base64
                return false;
            }
        }
    }
}
