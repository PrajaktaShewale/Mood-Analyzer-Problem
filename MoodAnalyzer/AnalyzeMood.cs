using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class AnalyzeMood
    {
        public string message;

        public AnalyzeMood(string message)//create parameterized constructor
        {
            this.message = message;//assigning value to local variable
        }
        public string MoodAnalyzer()//create method to get mood using messege
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else if (message.ToLower().Contains("happy"))
                {
                    return "HAPPY";
                }
                else
                {
                    throw new Exception("NULL");
                }
            }
            catch (Exception ex)
            {                
                return "NULL";
            }
            
        }

    }
}
