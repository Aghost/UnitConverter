using System.Collections.Generic;
namespace MeterConverter.Domain
{
    public interface IConverterService {
        double Calculate(double x, double y, double z);
        string ParseInput(string str, Dictionary<string, double> dict);
    }
}
