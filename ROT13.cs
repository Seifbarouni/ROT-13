namespace ROT_13
{
    public class ROT13
    {
        public string Transform(string input)
        {
            char[] characters = input.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                int num = (int)characters[i];

                if (num >= 'a' && num <= 'z')
                {
                    if (num > 'm')
                    {
                        num -= 13;
                    }
                    else
                    {
                        num += 13;
                    }
                }
                else if (num >= 'A' && num <= 'Z')
                {
                    if (num > 'M')
                    {
                        num -= 13;
                    }
                    else
                    {
                        num += 13;
                    }
                }
                characters[i] = (char)num;
            }
            return new string(characters);
        }
    }
}