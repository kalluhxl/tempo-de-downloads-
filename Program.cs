double fileSizeMB = 50000;
double speedMbps = 10;
double speedMBs = speedMbps / 8;
double timeInSeconds = fileSizeMB / speedMBs;
TimeSpan time = TimeSpan.FromSeconds (timeInSeconds);
Console.WriteLine($"tempo estimado: {time.Minutes}m {time.Seconds}s");
