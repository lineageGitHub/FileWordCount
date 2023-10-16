// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;
using System.IO;
using System.Reflection.Metadata;

try
{
    int lowerCount = 0;
    int upperCount = 0;
    int overallCount = 0;
    int punctuationCount = 0;
    int digitCount = 0;
    IDictionary<string, int> map = new Dictionary<string, int>();

    StreamReader sr = new StreamReader("C:\\Users\\guyb\\Nextcloud\\Programming\\C#\\Practicles\\Week 4\\FileWordCount\\FileWordCount\\story.txt");
    string[] chrList = sr.ReadToEnd().Split(" ");
    foreach (string chr in chrList)
    {
        foreach (char c in chr)
        {

            {
                if (Char.IsLower(c))
                {
                    lowerCount++;

                }

                if (Char.IsUpper(c))
                {
                    upperCount ++;
                }


                if (Char.IsPunctuation(c))
                {
                    punctuationCount++;
                }

                if (Char.IsDigit(c))
                {
                    digitCount++;
                }

                if (char.IsLetter(c))
                {
                    if (map.ContainsKey(c.ToString()))
                    {
                        map[c.ToString()]++;

                    }
                    else
                    {
                        map[c.ToString()] = 1;
                    }
                }

            }

            overallCount = upperCount + lowerCount + punctuationCount + digitCount;

        }
    }

    Console.WriteLine("Lowercase letters: " + lowerCount);
    Console.WriteLine("Uppercase letters: " + upperCount);
    Console.WriteLine("Puntuation: " + punctuationCount);
    Console.WriteLine("Digits: " + digitCount);
    Console.WriteLine("Overall letters: " + overallCount);
    foreach (var i in map)
    {
        Console.WriteLine(i.Key + " : " + i.Value);
    }


}catch(Exception ex)
{

}
