public static class SecurityManager
{
    
    // Mindestens 10 Zeichen lang
    //
    // Besteht aus Zahlen (48 - 57) und Buchstaben (65 - 90, 97 - 122)
    //
    // Enthält mindestens ein Sonderzeichen

    public static bool IsValidPassword(string password)
    {
        var specialCharacterCount = 0;
        foreach (var character in password)
        {
            if (character < 33 || character > 126) return false;
            
            if (character > 57 && character < 65 
                || character > 90 && character < 97 
                || character > 122) specialCharacterCount++;
        }
        
        return specialCharacterCount > 0;
    }
    
    
}