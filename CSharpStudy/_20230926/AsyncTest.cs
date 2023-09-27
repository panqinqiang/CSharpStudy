namespace CSharpStudy._20230926;

public class AsyncTest
{
    public async Task<string> DownloadDataAsync(string url)
    {
        using (var client = new HttpClient())
        {
            var data = await client.GetStringAsync(url);
            return data;
        }
    }
}