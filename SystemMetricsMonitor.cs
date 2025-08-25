namespace Task4;

public class SystemMetricsMonitor
{
    private readonly ISystemMetricsProvider _metricsProvider;
    private readonly IMetricsLogger _metricsLogger;
    public SystemMetricsMonitor(ISystemMetricsProvider metricsProvider, IMetricsLogger metricsLogger)
    {
        _metricsProvider = metricsProvider;
        _metricsLogger = metricsLogger;
    }
    public async Task MonitorAsync()
    {
        while (true)
        {
            var hardware = _metricsProvider.GetMetrics();
            await _metricsLogger.LogAsync(hardware);

            await Task.Delay(60000);
        }
    }
}
