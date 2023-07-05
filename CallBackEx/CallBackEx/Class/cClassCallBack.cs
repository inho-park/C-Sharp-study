using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CallBackEx.Class
{
    class cClassCallBack
    {
        public void fStart()
        {
            fCallProgress();
        }

        #region 상태 체크
        Thread _thread;
        public int _iProgressLog = 0;
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
                Thread.Sleep(500);
            }
        }
        #endregion
    }
}
