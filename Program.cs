using System;
using System.Text;

class Program
{
    static void Main()
    {
        string encryptedMessage = "10010110 11110111 01010110 00000001 00010111 00100110 01010111 00000001 00010111 01110110 01010111 00110110 11110111 11010111 01010111 00000011";
        string result = DecryptMessage(encryptedMessage);

        Console.WriteLine(result);

    }

    static string DecryptMessage(string message)
    {
        string[] encryptedMessage = message.Split(' ');
        byte[] decryptedMessageArray = new byte[encryptedMessage.Length];

        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            char[] bitsArray = encryptedMessage[i].ToCharArray();

            bitsArray[6] = (bitsArray[6] == '1') ? '0' : '1';       
            bitsArray[7] = (bitsArray[7] == '1') ? '0' : '1';       
        
            string newByte = new string(bitsArray[4..]) + new string(bitsArray[0..4]);

            decryptedMessageArray[i] = Convert.ToByte(newByte, 2);
        }

        return Encoding.ASCII.GetString(decryptedMessageArray);
    }

  
}
