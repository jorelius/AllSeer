using System.Drawing;
using Yolov5Net.Scorer;

namespace AllSeer.Cli.Usecases
{
    public class MarkupImage
    {
        public void Execute(List<YoloPrediction> predictions, string imagePath, string outputPath)
        {
            using var image = Image.FromFile(imagePath);

            using var graphics = Graphics.FromImage(image);

            foreach (var prediction in predictions) // iterate predictions to draw results
            {
                double score = Math.Round(prediction.Score, 2);

                graphics.DrawRectangles(new Pen(prediction.Label.Color, 1),
                    new[] { prediction.Rectangle });

                var (x, y) = (prediction.Rectangle.X - 3, prediction.Rectangle.Y - 23);

                graphics.DrawString($"{prediction.Label.Name} ({score})",
                    new Font("Arial", 16, GraphicsUnit.Pixel), new SolidBrush(prediction.Label.Color),
                    new PointF(x, y));
            }

            image.Save(outputPath);
        }
    }
}