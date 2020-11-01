using System;
namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] chara = str.ToCharArray();
            Array.Sort(chara);
            return new string(chara);
        }
    }
}
