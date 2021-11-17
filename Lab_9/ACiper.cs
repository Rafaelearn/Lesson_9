namespace Lab_9
{
    class ACiper : ICipher
    {
        private string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public void Decode(ref string s)
        {
            string strNew = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (abc.IndexOf(s[i]) == -1)
                {
                    strNew += s[i];
                }
                else
                {
                    if (s[i] == 'a')
                    {
                        strNew += 'z';
                    }
                    else if (s[i] == 'A')
                    {
                        strNew += 'Z';
                    }
                    else
                    {
                        strNew += (char)((int)s[i] - 1);
                    }
                }
            }
            s = strNew;
        }
        public void Encode(ref string s)
        {
            string strNew = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (abc.IndexOf(s[i]) == -1)
                {
                    strNew += s[i];
                }
                else
                {
                    if (s[i] == 'z')
                    {
                        strNew += 'a';
                    }
                    else if (s[i] == 'Z')
                    {
                        strNew += 'A';
                    }
                    else
                    {
                        strNew += (char)((int)s[i] + 1);
                    }
                }
            }
            s = strNew;
        }
    }
}
