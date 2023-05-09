using System.Net;

namespace AsyncAwaitExample;

internal class MyClass
{
    public static async Task<string> DownloadDataAsync(string url)
    {
        using WebClient client = new();
            
        return await client.DownloadStringTaskAsync(url);
    }
}

/*
In this example, the DownloadDataAsync method is marked as async 
and returns a Task<string>. Inside the method, the 
DownloadStringTaskAsync method of the WebClient class is called using the await keyword. This causes the method to 
wait for the completion of the download operation before continuing.
 */