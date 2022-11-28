using System.Diagnostics;


namespace ProcesManager
{
    public class PManager
    {
        public Process[] _processes { get; }

        public PManager()
        {
            _processes = Process.GetProcesses();
           
        }
        public void openCalc()
        {
            Process process = new Process();
            Process.Start("calc");
        }
        public void CloseProcess(string name)
        {
            var process = _processes.FirstOrDefault(p => p.ProcessName == name);
            if(process != null)
            {
                try
                {
                    process.Kill();
                }
                catch (Exception e)
                {

                }
            }
        }
        public void OpenProcess(string name)
        {
            if (name.Length > 0)
            {
                Process.Start(name.ToLower());
            }
        }
       

    }
}