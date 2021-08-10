using System;
using System.Collections.Generic;

namespace MeterConverter.Domain
{
    public class ConverterService {
        public static string ParseInput(string str, Dictionary<string, double> dict) {
            string[] values = str.Split(' ');

            try {
                if ((values.Length == 3) && (Double.TryParse(values[0], out double val) && val > 0)) {
                    return $"{val} {values[1]} = {dict[values[1]] * (1 / dict[values[2]] * val)} {values[2]}";
                }
                return $"Invalid Input\n> Usage: VALUE UNIT UNIT\n> Units: {String.Join(' ', dict.Keys)}";
            } catch (Exception e) {
                return values[0] == "exit" ? "exit..." : $"ERROR: {e.ToString().Split('\n')[0]}\n> Usage: value unit unit\n> units: {String.Join(' ', dict.Keys)}"; 
            }
        }
    }
}