﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StringLibrary
{
    public static class StringLibrary
    {
        public static bool StartsWithUpper(this string? str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
        }
    }
}