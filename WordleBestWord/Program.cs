using System;
using System.IO;

namespace WordleBestWord
{
    internal class Program
    {

        int record = 0;
        bool run = true;
        static void Main(string[] args)
        {
            string[,] topletters = new string[2, 10];
            Program program1 = new Program();
            program1.allowedwords();

            Program program2 = new Program();
            program2.wordlist(topletters);

            Program program3 = new Program();
            program3.mains(topletters);

            string userName = Console.ReadLine();
        }
        public void allowedwords()
        {

            string[] wordlist = new string[10657];
            string currentletter;
            string[] alpha = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[,] letters = new string[2, 26] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" }, { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" } };

            char charcurrentletter;
            //Known word count of 1 - 12972

            StreamReader sr = new StreamReader("wordleclues.txt");
            for (int i = 0; i < 10657; i++)
            {
                wordlist[i] = sr.ReadLine();
            }
            sr.Close();

            //Steps through wordlist
            for (int index = 0; index < wordlist.Length; index++)
            {
                string currentword = wordlist[index];

                //Scans string
                for (int subindex = 0; subindex < wordlist[0].Length; subindex++)
                {
                    charcurrentletter = currentword[subindex];
                    currentletter = Char.ToString(charcurrentletter);

                    //Scans the lettersbet to match the current sub index
                    for (int letter = 0; letter < letters.Length / 2; letter++)
                    {
                        if (currentletter == letters[0, letter])
                        {
                            int sum = Int32.Parse(letters[1, letter]);
                            sum += 1;
                            letters[1, letter] = sum.ToString();
                        }
                    }
                }
            }

            //Sorts Array
            for (int index = 0; index < letters.Length / 2; index++)
            {
                for (int subindex = 0; subindex < letters.Length / 2; subindex++)
                {
                    int mainnumber = Int32.Parse(letters[1, index]);
                    int subnumber = Int32.Parse(letters[1, subindex]);

                    if (mainnumber > subnumber)
                    {
                        string[,] temp = new string[2, 1];
                        string[,] temp2 = new string[2, 1];

                        temp[0, 0] = letters[0, subindex];
                        temp2[1, 0] = letters[1, subindex];

                        letters[0, subindex] = letters[0, index];
                        letters[1, subindex] = letters[1, index];

                        letters[0, index] = temp[0, 0];
                        letters[1, index] = temp2[1, 0];
                    }
                }
            }
            Console.WriteLine("\n" + "Wordle Clue Words");
            Console.WriteLine("\n" + "------------------------");

            for (int index = 0; index < letters.Length / 2; index++)
            {
                Console.Write(letters[0, index] + " : ");
                Console.Write(letters[1, index] + "\n");
            }
            Console.WriteLine("\n" + "Best matching clues");
            Console.WriteLine("\n" + "------------------------------------------------------");

            //Find words that contain all of the top 5 most used number with out repeats
            for (int i = 0; i < wordlist.Length; i++)
            {
                bool passed = false;
                string currentstring = wordlist[i];

                for (int j = 0; j < 5; j++)
                {
                    currentletter = letters[0, j];

                    for (int k = 0; k < 5; k++)
                    {
                        String Scurrentstring = Char.ToString(currentstring[k]);
                        if (Scurrentstring == currentletter)
                        {
                            passed = true;
                            break;
                        }
                        else
                        {
                            passed = false;
                        }
                    }
                    if (!passed)
                    {
                        break;
                    }
                }
                if (passed)
                {
                    Console.Write(currentstring + "\n");
                }
            }
            Console.Write("\n" + "\n");
        }
        public void wordlist(string[,] topletters)
        {
            string[] wordlist = new string[2315];
            string currentletter;
            string[] alpha = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[,] letters = new string[2, 26] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" }, { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" } };

            char charcurrentletter;
            //Known word count of 1 - 12972

            StreamReader sr = new StreamReader("wordle.txt");
            for (int i = 0; i < 2315; i++)
            {
                wordlist[i] = sr.ReadLine();
            }
            sr.Close();

            //Steps through wordlist
            for (int index = 0; index < wordlist.Length; index++)
            {
                string currentword = wordlist[index];

                //Scans string
                for (int subindex = 0; subindex < wordlist[0].Length; subindex++)
                {
                    charcurrentletter = currentword[subindex];
                    currentletter = Char.ToString(charcurrentletter);

                    //Scans the lettersbet to match the current sub index
                    for (int letter = 0; letter < letters.Length / 2; letter++)
                    {
                        if (currentletter == letters[0, letter])
                        {
                            int sum = Int32.Parse(letters[1, letter]);
                            sum += 1;
                            letters[1, letter] = sum.ToString();
                        }
                    }
                }
            }

            //Sorts Array
            for (int index = 0; index < letters.Length / 2; index++)
            {
                for (int subindex = 0; subindex < letters.Length / 2; subindex++)
                {
                    int mainnumber = Int32.Parse(letters[1, index]);
                    int subnumber = Int32.Parse(letters[1, subindex]);

                    if (mainnumber > subnumber)
                    {
                        string[,] temp = new string[2, 1];
                        string[,] temp2 = new string[2, 1];

                        temp[0, 0] = letters[0, subindex];
                        temp2[1, 0] = letters[1, subindex];

                        letters[0, subindex] = letters[0, index];
                        letters[1, subindex] = letters[1, index];

                        letters[0, index] = temp[0, 0];
                        letters[1, index] = temp2[1, 0];
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                topletters[0, i] = letters[0, i];
                topletters[1, i] = letters[1, i];
            }

            Console.WriteLine("\n" + "Allowed answers");
            Console.WriteLine("\n" + "------------------------");

            for (int index = 0; index < letters.Length / 2; index++)
            {
                Console.Write(letters[0, index] + " : ");
                Console.Write(letters[1, index] + "\n");
            }
            Console.WriteLine("\n" + "Best matching word");
            Console.WriteLine("\n" + "------------------------------------------------------");

            //Find words that contain all of the top 5 most used number with out repeats
            for (int i = 0; i < wordlist.Length; i++)
            {
                bool passed = false;
                string currentstring = wordlist[i];

                for (int j = 0; j < 5; j++)
                {
                    currentletter = letters[0, j];

                    for (int k = 0; k < 5; k++)
                    {
                        String Scurrentstring = Char.ToString(currentstring[k]);
                        if (Scurrentstring == currentletter)
                        {
                            passed = true;
                            break;
                        }
                        else
                        {
                            passed = false;
                        }
                    }
                    if (!passed)
                    {
                        break;
                    }
                }
                if (passed)
                {
                    Console.Write(currentstring + "\n");
                }
            }
        }

        //This function will try diffrent combos of letters and find the one that returns a word from the list with the highest score
        //Score being based on how many time each letter is found in the wordlist

        public void mains(string[,] topletters)
        {

            string[,] a = topletters;
            heapPermutation(a, 10, a.Length / 2);
        }
        public void findword(string[,] a)
        {
        }

        public void heapPermutation(string[,] a, int size, int n)
        {
            // if size becomes 1 then prints the obtained
            // permutation

            if (size == 1)
            {
                string[] wordlist = new string[2315];
                string currentletter;
                int topscore = 0;

                //Known word count of 1 - 12972

                StreamReader sr = new StreamReader("wordle.txt");
                for (int i = 0; i < 2315; i++)
                {
                    wordlist[i] = sr.ReadLine();
                }
                sr.Close();

                for (int i = 0; i < wordlist.Length; i++)
                {
                    bool passed = false;
                    string currentstring = wordlist[i];

                    for (int j = 0; j < 5; j++)
                    {
                        currentletter = a[0, j];

                        for (int k = 0; k < 5; k++)
                        {
                            String Scurrentstring = Char.ToString(currentstring[k]);
                            if (Scurrentstring == currentletter)
                            {
                                passed = true;
                                break;
                            }
                            else
                            {
                                passed = false;
                            }
                        }
                        if (!passed)
                        {
                            break;
                        }
                    }
                    if (passed)
                    {
                        for (int xx = 0; xx < 5; xx++)
                        {
                            int num = Int32.Parse(a[1, xx]);
                            topscore += num;
                        }
                        if (topscore > record)
                        {
                            Console.Write(currentstring + "\n");
                            record = topscore;
                            run = false;
                            //Once I have any word I can break the permutation algorithm as every thing else will have a worse score and there is no need to test
                        }
                        topscore = 0;
                    }
                }
            }

            if (run)
            {
                for (int i = 0; i < size; i++)
                {
                    heapPermutation(a, size - 1, n);

                    if (size % 2 == 1)
                    {
                        string temp = a[0, 0];
                        a[0, 0] = a[0, size - 1];
                        a[0, size - 1] = temp;

                        temp = a[1, 0];
                        a[1, 0] = a[1, size - 1];
                        a[1, size - 1] = temp;
                    }

                    else
                    {
                        string temp = a[0, i];
                        a[0, i] = a[0, size - 1];
                        a[0, size - 1] = temp;

                        temp = a[1, i];
                        a[1, i] = a[1, size - 1];
                        a[1, size - 1] = temp;
                    }
                }
            }
        }
    }
}
