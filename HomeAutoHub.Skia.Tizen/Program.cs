using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace HomeAutoHub.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new HomeAutoHub.App(), args);
            host.Run();
        }
    }
}
