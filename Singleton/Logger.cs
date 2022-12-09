namespace Singleton
{
    class Logger
    {
        //Lazy<T> gives us thread-safety out-of-the-box
        //Note - Nowdays all singleton objects are created from IoC containers.
        private static readonly Lazy<Logger> _lazyLogger
            = new Lazy<Logger>(() => new Logger()); //the part inside () is executed lazily when .Value is called
        private Logger()
        {

        }

        public static Logger Instance
        {
            get { return _lazyLogger.Value; }
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
