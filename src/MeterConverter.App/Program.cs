using System;
using System.Collections.Generic;
using static MeterConverter.Domain.UnitConverter;
using static System.Console;

string input;

do {
    input = ReadLine();
    WriteLine(ParseInput(input, LengthUnits));
} while (input != "exit");
