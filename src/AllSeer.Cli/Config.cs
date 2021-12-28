namespace AllSeer.Cli;
public static class Config
{
    public const string DefaultModelUrl = "https://github.com/jorelius/AllSeer/blob/main/src/AllSeer.Cli/Assets/Weights/yolov5s.onnx?raw=true";

    public static string UserPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
    public static string WeightPath { get; set; } = Path.GetFullPath(Path.Combine(UserPath, ".allseer/Assets/Weights"));

    public static string DefaultModel { get; set; } = "yolov5s.onnx";
    public static string DefaultModelPath { get; set; } = Path.GetFullPath(Path.Combine(WeightPath, DefaultModel));
}