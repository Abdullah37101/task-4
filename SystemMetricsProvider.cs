namespace Task4;
public class SystemMetricsProvider : ISystemMetricsProvider, IDisposable
{
    private readonly Computer _computer;
    public SystemMetricsProvider()
    {
        _computer = new Computer
        {
            IsCpuEnabled = true,
            IsGpuEnabled = true,
            IsMemoryEnabled = true,
            IsMotherboardEnabled = true,
            IsStorageEnabled = true,
            IsNetworkEnabled = true
        };

        _computer.Open();
        _computer.Accept(new UpdateVisitor());
    }


    public IEnumerable<IHardware> GetMetrics() =>
        _computer.Hardware;

    public void Dispose()
    {
        _computer.Close();
    }
}