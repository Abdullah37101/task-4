namespace Task4;

public interface IMetricsLogger
{
    Task LogAsync(IEnumerable<IHardware> hardware);
}
