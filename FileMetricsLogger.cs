namespace Task4;

public class FileMetricsLogger : IMetricsLogger
{
    private const string LogFilePath = "log.txt";
    public async Task LogAsync(IEnumerable<IHardware> hardware)
    {
        using StreamWriter writer = new(LogFilePath, append: true);

        await writer.WriteLineAsync($"Log Time: {DateTime.Now}" + writer.NewLine);

        foreach (IHardware singleHardware in hardware)
        {
            await writer.WriteLineAsync($"Hardware: {singleHardware.Name} ({singleHardware.HardwareType})");
            foreach (ISensor sensor in singleHardware.Sensors)
                await writer.WriteLineAsync($"  Sensor: {sensor.Name} ({sensor.SensorType}) - Value: {sensor.Value}");
        }

        await writer.WriteLineAsync(writer.NewLine);
        await writer.FlushAsync();
    }

}
