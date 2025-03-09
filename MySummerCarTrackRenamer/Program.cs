namespace MySummerCarTrackRenamer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var curDir = Directory.GetCurrentDirectory();

            var inputDir = Path.Combine(curDir, "input");
            var outputDir = Path.Combine(curDir, "output");

            if (!Directory.Exists(inputDir) | !Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(inputDir);
                Directory.CreateDirectory(outputDir);

                Console.WriteLine("Directories was created(add files in input directory and restart programm)");
                return;
            }

            var inputFiles = Directory.GetFiles(inputDir);

            foreach (var file in Directory.GetFiles(outputDir))
            {
                File.Delete(file);
            }
            
            int trackCounter = 1;
            foreach ( var file in inputFiles )
            {
                var outFileName = Path.Combine (outputDir, $"track{trackCounter}.ogg");
                File.Move(file, outFileName);   
                Console.WriteLine($"track{trackCounter}.ogg");

                trackCounter++;
            }
            Console.WriteLine("Complete");
        }
    }
}
