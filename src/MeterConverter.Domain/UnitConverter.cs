using System;
using System.Collections.Generic;

namespace MeterConverter.Domain
{
    public class UnitConverter {
        public static Dictionary<string, double> LengthUnits = new Dictionary<string, double> {
            { "mm", 0.001 },
            { "cm", 0.01 },
            { "in", 0.0254 },
            { "dm", 0.1 },
            { "m", 1 },
            { "km", 1000 }
        };

        public static Dictionary<string, double> MetricUnits = new Dictionary<string, double> {
            {"tera", 1000000000000},
            {"T", 1000000000000},
            {"giga", 1000000000},
            {"G", 1000000000},
            {"mega", 1000000},
            {"M", 1000000},
            {"kilo", 1000},
            {"k", 1000},
            {"hecto", 100},
            {"h", 100},
            {"deca", 10},
            {"da", 10},
            {"none", 1},
            {"deci", 0.1},
            {"d", 0.1},
            {"centi", 0.01},
            {"c", 0.01},
            {"milli", 0.001},
            {"m", 0.001},
            {"micro", 0.000001},
            {"u", 0.000001},
            {"nano", 0.000000001},
            {"n", 0.000000001},
            {"pico", 0.000000000001},
            {"p", 0.000000000001},
        };

        public static double ConvertUnit(double a, double b, double val) {
            return a * (val / b);
        }

        public static string ParseInput(string str, Dictionary<string, double> dict, Func<double, double, double, double> f) {
            string[] values = str.Split(' ');

            if ((values.Length == 3) && Double.TryParse(values[0], out double val) && val > 0 &&
                    dict.ContainsKey(values[1]) &&
                    dict.ContainsKey(values[2])) {
                return $"{f(dict[values[1]], dict[values[2]], val)}";
            }
            return $"Invalid Input\n> Valid Units: {String.Join(' ', dict.Keys)}";
        }
    }
}
