using System.Threading;
using System.Threading.Tasks;

namespace SoftDesEksamen
{
    public abstract class ThreadProxy
    {

        protected Thread _thread;
        protected Thread _thread1;
        protected bool _running;

        public Thread Thread
        {
            get => _thread;
        }
        public bool isAlive
        {
            get => _thread.IsAlive && _thread1.IsAlive;
        }

        public bool Running
        {
            get => _running; 
        }

        public ThreadProxy()
        {
            _thread = new Thread(new ThreadStart(ThreadLoop));
            _thread1 = new Thread(new ThreadStart(ThreadLoop));
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
            _thread1.Start();
            while (!_thread.IsAlive && !_thread1.IsAlive);
        }

        public void Stop()
        {
            _running = false;
            _thread.Join();
            _thread1.Join();
        }
        
        
    }
}