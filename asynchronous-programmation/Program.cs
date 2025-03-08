public async task DownloadDataAsync()
{
    console.WriteLine("Downloading data started...");
    await Task.Delay(2000);
    console.WriteLine("Downloading data completed...");
}
