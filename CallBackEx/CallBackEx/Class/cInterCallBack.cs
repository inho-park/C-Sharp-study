using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CallBackEx
{
    /// <summary>
    /// Interface 를 사용한 Class 에 대한 CallBack 구현
    /// </summary>
    class cInterCallBack
    {
        iCallBack _iCall;
        int _iCount = 1;

        public cInterCallBack(iCallBack iCall)
        {
            _iCall = iCall;
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
                _iCall.fCallBackMessage(_iProgressLog.ToString());

                Thread.Sleep(500);
            }
            _thread.Join();
        }
    }
}
