using System;
using System.Windows.Forms;

namespace DynPicker
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //�������ӿ��̵߳��ã���ͻ�ǲ����ܳ�ͻ�ģ��Ⱳ�Ӷ������ܳ�ͻ��
            Control.CheckForIllegalCrossThreadCalls = false;
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
