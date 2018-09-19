namespace Mines
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            var mineField = new StringBuilder(Console.ReadLine());
            var bombPattern = @"<([A-Za-z])([A-Za-z])>";

            var matches = Regex.Matches(mineField.ToString(), bombPattern);

            foreach (Match match in matches)
            {
                var bomb = match.Value;
                if (mineField.ToString().Contains(bomb) == false)
                {
                    break;
                }

                if (bomb == mineField.ToString())
                {
                    mineField.Replace(bomb, "____");
                    break;
                }

                var firstChar = char.Parse(match.Groups[1].Value);
                var secondChar = char.Parse(match.Groups[2].Value);
                var bombRange = Math.Abs((int)firstChar - secondChar);
                var bombIndex = mineField.ToString().IndexOf(bomb);
                var explode = 4 + (bombRange * 2);
                var explodePos = bombIndex - bombRange;
                var replacement = new string('_', explode);

                try
                {
                    mineField.Remove(explodePos, explode);
                    mineField.Insert(explodePos, replacement);
                }
                catch (Exception)
                {
                    var leftSide = mineField.ToString().Substring(0, bombIndex);
                    var rightSide = mineField.ToString().Substring(bombIndex + 4, mineField.Length - bombIndex - 4);
                    mineField.Replace(bomb, "____");

                    if (leftSide.Length > 0)
                    {
                        if (leftSide.Length < bombRange)
                        {
                            mineField.Replace(leftSide, new string('_', leftSide.Length));
                        }
                        else
                        {
                            mineField.Remove(explodePos, bombRange);
                            mineField.Insert(explodePos, new string('_', bombRange));
                        }
                    }
                   
                    if (rightSide.Length > 0)
                    {
                        if (rightSide.Length < bombRange)
                        {
                            mineField.Replace(rightSide, new string('_', rightSide.Length));
                        }
                        else
                        {
                            mineField.Remove(bombIndex + 4, bombRange);
                            mineField.Insert(bombIndex + 4, new string('_', bombRange));
                        }
                    }
                    
                }                
            }

            Console.WriteLine(mineField);
        }
    }
}
