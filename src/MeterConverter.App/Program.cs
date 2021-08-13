using static MeterConverter.Domain.UnitConverter;
using static System.Console;
using MeterConverter.Domain;

string stringbuffer;
Logger logger = new Logger("Console");

while ((stringbuffer = ReadLine()) != "exit") {
    ParseInput(stringbuffer, LengthUnits, ConvertUnit, out stringbuffer);
    logger.Log(stringbuffer);
}
