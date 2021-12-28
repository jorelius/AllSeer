using System.Net.Http;

namespace AllSeer.Cli.Usecases;

public class CreateNewProfile
{
    static readonly HttpClient client = new HttpClient();

    public async Task Execute()
    {
        if (!Directory.Exists(Config.WeightPath))
        {
            // create directory
            try
            {
                Console.WriteLine($"App config directory created: ~/.allseer");
                Directory.CreateDirectory(Config.WeightPath);

            } 
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine($"Failed to create weights directory: {Config.WeightPath}");
            }
        }

        if (!File.Exists(Config.DefaultModelPath))
        {
            Console.Write($"Downloading default model..");

            // download default model
            using Stream t = await client.GetStreamAsync(Config.DefaultModelUrl);
            using FileStream fs = File.Create(Config.DefaultModelPath);
            
            t.CopyTo(fs);

            Console.WriteLine($"complete");
        }
    }
}