using System;
using System.Threading.Tasks;

public interface IFirebaseAuthenticator
{
    Task<string> LoginWithEmailPassword(string email, string password);
}
