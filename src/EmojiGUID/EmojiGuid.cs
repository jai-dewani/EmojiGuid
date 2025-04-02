using System;
using System.Text;

namespace EmojiGUID
{
    public class EmojiGuid
    {
        private readonly string guidValue;

        public EmojiGuid(string guidValue)
        {
            this.guidValue = guidValue;
        }

        public string ToString(string format)
        {
            switch (format)
            {
                case "D":
                    return guidValue;
                case "N":
                    return guidValue.Replace("-", "");
                case "B":
                    return "{" + guidValue + "}";
                case "P":
                    return "(" + guidValue + ")";
                default:
                    return guidValue;
            }
        }

        //TODO: Solve this function
        //public Guid ConvertToGuid()
        //{
        //    StringBuilder guidString = new StringBuilder();
        //    foreach (char c in guidValue)
        //    {
        //        Console.WriteLine(c);
        //        if (c != '-')
        //        {
        //            int index = Array.IndexOf(Emojis, c.ToString());
        //            guidString.Append(index.ToString("X"));
        //        }
        //        else
        //            guidString.Append(c);
        //    }

        //    Console.WriteLine(guidString);
        //    return new Guid(guidString.ToString());
        //}

        public override string ToString()
        {
            return guidValue;
        }

        public override bool Equals(object obj)
        {
            return obj is EmojiGuid guid &&
                   guidValue == guid.guidValue;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        #region Static 

        private static readonly string[] Emojis = new string[]
        {
            "😀", "😁", "😂", "🤣", "😃", "😄", "😅", "😆", "😉", "😊",
            "😋", "😎", "😍", "😘", "😗", "😙"
        };

        public static EmojiGuid GenerateEmojiGuid()
        {
            Guid guid = Guid.NewGuid();
            string guidString = guid.ToString(); // N format: 32 digits
            StringBuilder emojiGuid = new StringBuilder();

            foreach (char c in guidString)
            {
                if (c != '-')
                {
                    int index = int.Parse(c.ToString(), System.Globalization.NumberStyles.HexNumber);
                    emojiGuid.Append(Emojis[index]);
                }
                else
                    emojiGuid.Append(c);
            }

            return new EmojiGuid(emojiGuid.ToString());
        }

        #endregion
    }
}
