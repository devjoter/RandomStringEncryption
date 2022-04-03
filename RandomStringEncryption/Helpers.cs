
using System.Collections;

public static class Helpers
{
    internal static string inputEncryption(string input)
    {
        return encryption(input);
    }
    internal static string inputDecryption(string input)
    {
        return decryption(input);
    }
    private static string encryption(string inputString)
    {
        string cipherText = "";

        //Step : 1  
        //Convert input string characters in respected ascii codes & store it in array like below mentioned example of C# code.  

        ArrayList asciiArr = new ArrayList();

        for (int i = 0; i < inputString.Length; i++)
        {
            asciiArr.Add((int)Convert.ToChar(inputString[i]));
        }

        //Step : 2  
        //Fill A to Z array in capital or small letters  

        ArrayList atozArr = new ArrayList();

        for (int i = 0, j = 65; i < 26; i++, j++)
        {
            atozArr.Add((char)j);
        }

        //Step : 3  
        // Choose randomly single character index from A to Z and differentiate it's position in one variable & it's respected ascii value in second variable  
        //Note: Here i'm referencing an function return a random value from minimum - maximum range.   

        int positionAscii = Convert.ToInt32(atozArr[(new Random()).Next(26)]);

        //Step : 4  
        //Addition of every input String each element to positionAscii  

        ArrayList outputArr = new ArrayList();

        for (int i = 0; i < inputString.Length; i++)
        {
            outputArr.Add(Convert.ToInt32(asciiArr[i]) + positionAscii);
        }

        int[] k = (int[])outputArr.ToArray(Type.GetType("System.Int32"));

        Console.Write("\nCipher Text: \n\n");

        foreach (int i in k)
        {
            cipherText = cipherText + (char)i;
        }

        //Step : 5  
        //Attachment of key to encrypted string or not it's your choice & it's your modification scenario, here i'm attaching a key with an encrypted string   

        if (inputString.Length.Equals(cipherText.Length))
        {
            cipherText = cipherText + (char)positionAscii;
        }

        //Step : 6  
        //Finally your encryption is ready to send  
        return cipherText;
    }

    public static string decryption(string cipherText)
    {
        //Step : 1  
        //Take decryption key from cipherText  

        int positionAscii = Convert.ToInt32(cipherText[cipherText.Length - 1]);

        //Step : 2  
        //Substract value of key from each characters of cipherText  

        string plainText = "";

        foreach (int i in cipherText)
        {
            plainText = plainText + (char)(Convert.ToInt32(i) - positionAscii);
        }

        return plainText;
    }


}

