using static System.Console;
using static MeterConverter.Domain.UnitConverter;
using MeterConverter.Domain;

string stringbuffer;
Logger logger = new Logger("Console");

while ((stringbuffer = ReadLine()) != "exit") {
    logger.Log(ParseInput(stringbuffer, LengthUnits, ConvertUnit, out stringbuffer) ? stringbuffer : stringbuffer);
}
