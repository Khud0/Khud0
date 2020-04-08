using System;
using System.Collections.Generic;
using System.Text;

namespace Khud0
{
    namespace Utility
    {
        public static class StringCheck
        {
            /// <summary>
            /// Checks if there are charToCount duplicates in a stringToSearchIn
            /// </summary>
            public static bool CharacterRepeats(string stringToSearchIn, char charToCount)
            {
                int stringLength = stringToSearchIn.Length;
                bool moreThanOneCharacter = false;
                int charCount = 0;

                for (int i=0; i<stringLength; i++)
                {
                    if (stringToSearchIn[i].Equals(charToCount))
                    {
                        if (++charCount > 1) 
                        {
                            moreThanOneCharacter = true;
                            break;
                        }
                    }
                }

                return moreThanOneCharacter;
            }
        }
    }
}
