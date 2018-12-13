using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_client
{
    class FormManager
    {
        private String error;

        public String Error
        {
            get
            {
                return error;
            }
            set
            {
                error = value;
            }
        }

        public String FormAddMessage(string purchaseId, string purchaseName, string quantity, string price)
        {
            String message = "";

            if (!purchaseId.Equals("") && !purchaseName.Equals("") && !quantity.Equals("") && !price.Equals(""))
            {
                error = CheckIntValue(quantity);
                error = CheckIntValue(price);
                message = " " + purchaseId + " " + purchaseName + " " + quantity + " " + price;
            }
            else
            {
                error = "Required fields are empty";
            }

            return message;
        }

        public String FormChangeMessage(string purchaseId, string purchaseName, string quantity, string price, string previousName)
        {
            String message = "";
            error = "";

            if (!previousName.Equals("") && !(purchaseId.Equals("") && purchaseName.Equals("") && quantity.Equals("") && price.Equals("")))
            {
                if (!quantity.Equals(""))
                {
                    error = CheckIntValue(quantity);
                }

                if (!price.Equals(""))
                {
                    error = CheckIntValue(price);
                }

                message = " " + purchaseId + " " + previousName + " " + purchaseName + " " + quantity + " " + price;
            }
            else
            {
                error = "Required fields are empty";
            }

            return message;
        }

        public String FormDeleteMessage(string purchaseId)
        {
            String message = "";
            error = "";

            if (!purchaseId.Equals(""))
            {
                message = " " + purchaseId;
            }
            else
            {
                error = "Required fields are empty";
            }

            return message;
        }

        public String FormFindMessage(string purchaseId, string purchaseName, string quantity, string price, int type)
        {
            String message = " " + type;
            error = "";

            switch (type)
            {
                case 0:
                    if (!purchaseId.Equals(""))
                    {
                        message += " " + purchaseId;
                    }
                    else
                    {
                        error = "Required fields are empty";
                    }
                    break;
                case 1:
                    if (!purchaseName.Equals(""))
                    {
                        message += " " + purchaseName;
                    }
                    else
                    {
                        error = "Required fields are empty";
                    }
                    break;
                case 2:
                    if (!quantity.Equals(""))
                    {
                        error = CheckIntValue(quantity);
                        message += " " + quantity;
                    }
                    else
                    {
                        error = "Required fields are empty";
                    }
                    break;
                case 3:
                    if (!price.Equals(""))
                    {
                        error = CheckIntValue(price);
                        message += " " + price;
                    }
                    else
                    {
                        error = "Required fields are empty";
                    }
                    break;
            }
            return message;
        }

        public String CheckIntValue(String text)
        {
            String result = "";

            try
            {
                if (System.Int32.Parse(text) <= 0)
                {
                    result = "The value should be positive";
                }
            }
            catch
            {
                result = "The value should be integer";
            }

            return result;
        }
    }
}
