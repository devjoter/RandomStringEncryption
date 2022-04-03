Console.Write("Plain Text: \n\n");
string input = Console.ReadLine();
string output = "C:/";
// Write each directory name to a file.   
using (StreamWriter sw = new StreamWriter("output.txt"))
{
    output = Helpers.inputEncryption(input);
    sw.WriteLine(output);
}
Console.Write(output);
Console.WriteLine("\n\nAfter Decryption Plain Text: \n\n" + Helpers.inputDecryption(output));
Console.ReadKey();



