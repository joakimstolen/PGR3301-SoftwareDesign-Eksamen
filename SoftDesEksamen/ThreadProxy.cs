using System.Threading;
using System.Threading.Tasks;

namespace SoftDesEksamen
{
    public abstract class ThreadProxy
    {

        protected Thread _thread { get; set; }
        protected bool _running { get; set; }


        public ThreadProxy()
        {
            _thread = new Thread(new ThreadStart(ThreadLoop));
            _running = false; 
        }

        public abstract void Task();

        public abstract void Task2();

 
        protected void ThreadLoop()
        {
            while (_running)
            {
                Task();
                Task2();
            }
        }

        public void Start()
        {
            _running = true;
            _thread.Start();
            while (!_thread.IsAlive);
        }

        public void Stop()
        {
            _running = false;
            _thread.Join();
        }
        
        
    }
}