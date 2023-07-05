using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CallBackEx
{
    class cDelCallBack
    {
        public delegate string delCallBack(string strMsg);
        public delCallBack dCall;

        public cDelCallBack()
        {

        }

        public void fStart()
        {
            fCallProgress();
        }

        Thread _thread;
        int _iProgressLog = 0;

        private void fCallProgress()
        {
            _thread = new Thread(Run);
            _thread.Start();
        }


        private void Run()
        {
            _iProgressLog = 0;
            while (_iProgressLog < 100)
            {
                _iProgressLog += 10;
                dCall(_iProgressLog.ToString());

                Thread.Sleep(500);
            }
        }
    }
}
