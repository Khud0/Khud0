using System;
using System.Collections.Generic;
using System.Text;

namespace Khud0.Utility
{
    public static class StringBuilderModifier
    {
        public static void SwapCharacters(StringBuilder stringBuilder, int index1, int index2)
        {
            char temp = stringBuilder[index2];
            stringBuilder[index2] = stringBuilder[index1];
            stringBuilder[index1] = temp;
        }
    }
}
