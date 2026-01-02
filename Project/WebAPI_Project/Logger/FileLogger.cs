namespace WebAPI_Project.Logger
{
    public class FileLogger
    {
        private static FileLogger _logger = new FileLogger();
        private FileLogger() { }

        private static FileLogger CurrentLogger
        {
            get { return _logger; }
        }

        public void Log(string message)
        {
            string path = @"D:\250845920054\MS Dot Net\WebSolution\WebAPI_Project\Data\data.txt";

            FileStream? fs = null;

            if (File.Exists(path))
            {
                fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            }
            else
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            }

            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine($"--> Logged at {DateTime.Now.ToString()} - {message}");

            writer.Close();
            fs.Close();
        }
    }
}
