using PowerArgs;

public class GeneratePredictionsArgs
{
    [ArgDescription("path to source image file"), ArgExistingFile, ArgShortcut("s")]
    public string FilePath { get; set; }

    [ArgDescription("path to output file"), ArgShortcut("o")]
    public string? OutputFilePath { get; set; }

    [ArgDescription("filter labels"), ArgShortcut("f")]
    public List<string> Filter { get; set; }
}