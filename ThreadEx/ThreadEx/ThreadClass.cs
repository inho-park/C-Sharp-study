using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadEx
{
    public class ThreadClass
    {
        public delegate void delMessage(int Value);
        public event delMessage eventdelMessage;


        Thread _thread;
        public int value;
        int var = 0;
        Random rd = new Random();
        private bool running = false;
        public ThreadClass()
        {
            _thread = new Thread(Run);
            _thread.IsBackground = true;
            _thread.Start();
        }
        public void ThreadStart()
        {
            running = true;
        }
        public void ThreadStop()
        {
            running = false;
        }


        private void Run()
        {
            try
            { 
                while (true)
                {
                    if (running)
                    {
                        var = rd.Next(1, 11);

                        if (value + var > 100)
                        {
                            value = 100;
                            running = !running;
                        }
                        else
                        {
                            value += var;
                        }

                        eventdelMessage(value);

                    }
                    // 요청한 Thread 가 현재 Main Thread 에 있는 Control 을 엑세스할 수 있는 지 확인
                    // 함수 값
             
                    Thread.Sleep(300);
                }


            }
            catch
            { 
            }

        }
    }
}
