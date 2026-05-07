using Microsoft.AspNetCore.Identity;

// Password Hasher
PasswordHasher<string> hasher =
    new PasswordHasher<string>();

string password = "Admin123";

// Hash Password
string hash =
    hasher.HashPassword(null, password);

Console.WriteLine("Hashed Password:");
Console.WriteLine(hash);

// Verify Password
var result = hasher.VerifyHashedPassword(
    null,
    hash,
    password);

Console.WriteLine(result);