namespace CoreProject.Services
{
    public class TimeService
    {
        public string Time{get;}
        public TimeService()
        {
            Time = System.DateTime.Now.ToString("hh:mm:ss");            
        }
    }
}