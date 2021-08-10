using static MeterConverter.Domain.UnitConverter;
using static System.Console;

string input;

while ((input = ReadLine()) != "exit") {
    WriteLine(ParseInput(input, LengthUnits));
}