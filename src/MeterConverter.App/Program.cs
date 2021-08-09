using System;
using System.Collections.Generic;
using static MeterConverter.Domain.UnitConverter;
using static System.Console;

string input = "";

do {
    WriteLine(ParseInput((input = ReadLine()), LengthUnits));

} while (input != "exit");
