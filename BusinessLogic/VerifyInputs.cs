using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
   public class VerifyInputs
    {

        //Test for item number
        public int testItemNumber(string strItemNumber)
        {
            int itemNumber = 0;

            try
            {
                //Convert the string to a number
                itemNumber = Convert.ToInt32(strItemNumber);

                return (itemNumber);
            }
            catch
            {
                return 0;
            }
        }

        public decimal testItemCost(string strItemCost)
        {
            decimal itemCost = 0;

            try
            {
                //Convert string to number
                itemCost = Convert.ToDecimal(strItemCost);

                return (itemCost);
            }
            catch
            {
                return 0;
            }
        }
    }
}
