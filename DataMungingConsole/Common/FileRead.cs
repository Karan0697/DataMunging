namespace DataMungingConsole.Common
{
    public class FileRead
    {
        public static IEnumerable<string> Read(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException(nameof(fileName));
            }

            // Read all lines from the file
            var lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                yield return line;
            }

        }
    }
}
