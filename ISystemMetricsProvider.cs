namespace Task4;

public interface ISystemMetricsProvider
{
    IEnumerable<IHardware> GetMetrics();
}
