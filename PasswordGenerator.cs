using System;
using System.Collections.Generic;
using System.Linq;


namespace PasswordGenerator
{
    class PasswordGenerator
    {
        Random random = new Random();

        List<string> upperAlphabet = new List<string>()
           {
            "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
            };

        List<string> lowerAlphabet = new List<string>()
          {
            "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
          };

        List<int> numbers = new List<int>()
          {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9
          };

        List<string> symbols = new List<string>()
        {
            "!", "£", "$", "%", "&", "/", "^", "*"
        };

        List<string> password = new List<string>();

        string uLetter, lLetter, num, sym, pass = "";

        public void genPass()
        {
            while (password.Count < 3)
            {
                int index = random.Next(upperAlphabet.Count);
                uLetter = upperAlphabet[index];
                password.Add(uLetter);

                while (password.Count >= 3 && password.Count < 6)
                {
                    index = random.Next(lowerAlphabet.Count);
                    lLetter = lowerAlphabet[index];
                    password.Add(lLetter);


                    while (password.Count >= 6 && password.Count < 9)
                    {
                        index = random.Next(numbers.Count);
                        num = numbers[index].ToString();
                        password.Add(num);

                        while (password.Count >= 9 && password.Count < 12)
                        {
                            index = random.Next(symbols.Count);
                            sym = symbols[index];
                            password.Add(sym);
                        }
                    }
                }
            }
            var shuffled = password.OrderBy(random => Guid.NewGuid()).ToList();

            Console.WriteLine(string.Join("", shuffled));
        }
    }
}
