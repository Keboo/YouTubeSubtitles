using System.Security.Cryptography;
namespace KebooBot.Lib;

internal static class BinaryDataExtensions
{
    public static string CalculateSHA256(this BinaryData binaryData)
    {
        byte[] byteArray = SHA256.HashData(binaryData.ToMemory().Span);
        return Convert.ToHexString(byteArray).ToLowerInvariant();
    }
}

