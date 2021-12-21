using System.Text.Json;
using AllSeer.Cli.Usecases;
using PowerArgs;
using Yolov5Net.Scorer;
using Yolov5Net.Scorer.Models;

[TabCompletion]
[ArgExceptionBehavior(ArgExceptionPolicy.StandardExceptionHandling)]
[ArgDescription("Object detection and classification")]
[ArgExample("allseer predict -s './file.jpg' -o './result.jpg'", "", Title = "generate label predictions")]
[ArgExample("allseer predict -s './file.jpg' -f person", "", Title = "filter predictions to only those with label 'person'")]
public class Controller
{
    [HelpHook, ArgShortcut("-?"), ArgDescription("Shows this help")]
    public bool Help { get; set; }

    [ArgActionMethod, ArgDescription("Generate Label Predictions and markup image."), ArgShortcut("p")]
    public void Predict(GeneratePredictionsArgs args)
    {
        var predictions = new GeneratePredictions().Execute(args.FilePath);

        if (args.Filter != null && args.Filter.Count > 0)
        {
            predictions = predictions.Where(p => args.Filter.Any(f => string.Equals(f, p.Label.Name, StringComparison.InvariantCultureIgnoreCase))).ToList();
        }

        if (predictions.Count > 0)
        {
            Console.Write(JsonSerializer.Serialize<List<YoloPrediction>>(predictions, new JsonSerializerOptions() { WriteIndented = true }));

            if (!string.IsNullOrEmpty(args.OutputFilePath))
            {
                new GeneratePredictionImage().Execute(predictions, args.FilePath, args.OutputFilePath);
            }
        }
    }

    [ArgActionMethod, ArgDescription("List all labels"), ArgShortcut("l")]
    public void Labels()
    {
        Console.Write(JsonSerializer.Serialize<IEnumerable<string>>(new YoloCocoP5Model().Labels.Select(l => l.Name), new JsonSerializerOptions() { WriteIndented = true }));
    }
}