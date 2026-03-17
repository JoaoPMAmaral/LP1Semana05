using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CanvasImage tux = new CanvasImage("tux.png");

            tux.MaxWidth(20);


            if(args.Length == 0)
            {
                AnsiConsole.Write(tux);
            }
            else
            {
                CanvasImage image = new CanvasImage(args[0]);

                int imageWidth = int.Parse(args[1]);
                image.MaxWidth(imageWidth);

                AnsiConsole.Write(image);
            }
        }
    }
}