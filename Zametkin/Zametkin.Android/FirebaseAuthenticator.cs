using System;

public class FirebaseAuthenticator : IFirebaseAuthenticator
{
    public async Task<string> LoginWithEmailPassword(string email, string password)
    {
        var user = await FirebaseAuth.Instance.
                        SignInWithEmailAndPasswordAsync(email, password);
        var token = await user.User.GetIdTokenAsync(false);
        return token.Token;
    }
}
