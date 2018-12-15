using System.IO;

namespace PoLaKoSz.MusicFM.Tests.Integration
{
    internal abstract class TestClassBase
    {
        private readonly string _path;

        protected readonly HttpClientMock HttpClient;



        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        public TestClassBase()
            : this("") { }

        /// <summary>
        /// Initialize a new instance.
        /// </summary>
        /// <param name="module">Non null name of the module (subdirectory).</param>
        public TestClassBase(string module)
        {
            _path = Path.Combine("StaticResources", module);
            HttpClient = new HttpClientMock();
        }



        /// <summary>
        /// Get the source code from a previously saved HTML file.
        /// </summary>
        /// <param name="fileName">Non null file name without extension
        /// and relative or absolute path.</param>
        /// <returns>Non null string.</returns>
        protected void SetServerResponse(string fileName)
        {
            HttpClient.ResponseFromServer = File.ReadAllText(Path.Combine(_path, $"{fileName}.html"));
        }

        /// <summary>
        /// Get the source code from a previously saved file.
        /// </summary>
        /// <param name="fileName">Non null file name WITH extension
        /// and relative or absolute path.</param>
        /// <returns>Non null string.</returns>
        protected void SetResponseFromServer(string fileName)
        {
            HttpClient.ResponseFromServer = File.ReadAllText(Path.Combine(_path, fileName));
        }
    }
}
