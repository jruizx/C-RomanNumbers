using System;
using System.Collections.Generic;

namespace RomanNumbers
{
    public class Converter
    {
        private RomanNumeral[] romanNumerals = {
            
            new RomanNumeral("M", 1000),
            new RomanNumeral("CM", 900),
            new RomanNumeral("D", 500),
            new RomanNumeral("CD", 400),
            new RomanNumeral("C", 100),
            new RomanNumeral("XC", 90),
            new RomanNumeral("L", 50),
            new RomanNumeral("XL", 40),
            new RomanNumeral("X", 10),
            new RomanNumeral("IX", 9),
            new RomanNumeral("V", 5),
            new RomanNumeral("IV", 4),
            new RomanNumeral("I", 1)
            
        };

        public string Convert(int arabic)
        {
            var result = "";

            foreach(var numeral in romanNumerals) {

                while(arabic >= numeral.Value) {
                    result += numeral.Symbol;
                    arabic = arabic - numeral.Value;
                }
            }

            return result;
        }
    }

    public class RomanNumeral {
        public RomanNumeral(string symbol, int value) {
            Symbol = symbol;
            Value = value;
        }

        public string Symbol { get; }
        public int Value { get; }
    }
}
