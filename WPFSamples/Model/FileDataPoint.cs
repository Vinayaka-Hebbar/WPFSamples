using WPFSamples.Common;

namespace WPFSamples.Model
{
    public class FileDataPoint : IInfo
    {

        /// <summary>
        /// Instantialte New File Type Object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        public FileDataPoint(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public string Name { get; set; }

        public string Path { get; set; }
    }
}
