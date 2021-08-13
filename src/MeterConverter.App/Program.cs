using static System.Console;
using static MeterConverter.Domain.UnitConverter;

string input;

while ((input = ReadLine()) != "exit") {
    WriteLine(ParseInput(input, LengthUnits, ConvertUnit));
}
