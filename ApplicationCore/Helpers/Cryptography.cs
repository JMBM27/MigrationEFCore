namespace ApplicationCore.Helpers;

public static class Cryptography
{

    public static string ReturnHash(string plainText)
    {
        string salt = BCrypt.Net.BCrypt.GenerateSalt(12);

        return BCrypt.Net.BCrypt.HashPassword(plainText, salt);
    }

    public static bool VerifyPassword(string enteredPassword, string storedHash)
    => BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);
}
