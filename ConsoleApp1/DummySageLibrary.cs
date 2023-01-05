using System;
using Objets100cLib;

namespace DummySageLibrary
{
    public class DummySageLibrary
    {
        public string GetOMVersion()
        {
            try
            {
                BSCPTAApplication100c om_baseCial = new BSCPTAApplication100c();
                return "OM version : " + om_baseCial.Licence.Version;
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return e.Message;
            }
        }
    }
}
