using System;
using System.Security.Cryptography;
using System.Text;

public static class AuthService
{
    //FINAL PROJECT: ESTANOCO, PASCUAL, BAUTISTA
    // Simple SHA256 hash (demo only)
    public static string HashPassword(string password)
    {
        if (password == null) return null;
        using var sha = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(password);
        var hash = sha.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }

    public static bool VerifyPassword(string provided, string storedHash)
    {
        if (provided == null || storedHash == null) return false;
        var h = HashPassword(provided);
        return h == storedHash;
    }
}
