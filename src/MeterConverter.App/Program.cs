using static System.Console;
using static MeterConverter.Domain.UnitConverter;

string stringbuffer;

while ((stringbuffer = ReadLine()) != "exit") {
    WriteLine(ParseInput(stringbuffer, LengthUnits, ConvertUnit, out stringbuffer) ? stringbuffer : stringbuffer);
}
