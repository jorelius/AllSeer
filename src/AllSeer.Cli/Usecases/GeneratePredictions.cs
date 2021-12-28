using System.Drawing;
using Yolov5Net.Scorer;
using Yolov5Net.Scorer.Models;

namespace AllSeer.Cli.Usecases;

public class GeneratePredictions
{
    public List<YoloPrediction> Execute(string imagePath)
    {
        using var image = Image.FromFile(imagePath);

        using var scorer = new YoloScorer<YoloCocoP5Model>(Config.DefaultModelPath);

        return scorer.Predict(image);
    }
}