using SystemMetricsProvider metricsProvider = new();
FileMetricsLogger logger = new();

SystemMetricsMonitor systemMetricsMonitor = new(metricsProvider, logger);

await systemMetricsMonitor.MonitorAsync();
