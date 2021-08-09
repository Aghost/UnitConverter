#
##
converterservice
ILogger logger

public static IConverterService
public ILogger logger;

class ConverterService : IConverterService {
    public ConverterService(ILogger logger) {
    }
}

logger = new logger
converter = new converter(logger);
