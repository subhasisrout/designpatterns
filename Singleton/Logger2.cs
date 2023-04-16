// #Inspired from Riddhi Dutta's video - https://youtu.be/2Dw1v9QC408 and https://youtu.be/MtMRwUXG9Rc

namespace Singleton
{
    public class Logger2
    {
        //read more about volatile in the above videos
        //this is related to 'thread's local cache'. if something is marked as volatile, thread's local cache (faster) is not used. Rather the main memory (slower) is used.
        private static volatile Logger2 _instance;
        private Logger2()
        {

        }

        Logger2 Instance
        {
            get
            {
                if (_instance == null) //thread t1,t2 calls .Instance at the same time
                {
                    lock (typeof(Logger2)) //t1 takes the lock, t2 waits
                    {
                        if (_instance == null) //concept double-checking. t1 creates the instance, t2 sees it and returns it. if this double-check was not there, t2 would create another instance.
                        {
                            _instance = new Logger2();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
