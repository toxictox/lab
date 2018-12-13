using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Lab_3_server
{
    class FileManager
    {
        String fileName = "D:\\Учебное\\RIS\\Lab_3_server\\Lab_3_server\\text.txt";
        FileStream fileStream;
        StreamReader streamReader;
        StreamWriter streamWriter;

        public string ReadAllFromFile()
        {
            string result;
            fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            streamReader = new StreamReader(fileStream);

            result = streamReader.ReadToEnd();

            streamReader.Close();
            fileStream.Close();

            return result;
        }

        public void AddToFile(string row)
        {
            string[] info = row.Split(' ');
            fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fileStream.Seek(0, SeekOrigin.End);
            streamWriter = new StreamWriter(fileStream);

            streamWriter.WriteLine(info[1] + " " + info[2] + " " + info[3] + " " + info[4]);

            streamWriter.Close();
            fileStream.Close();
        }

        public List<IceCreamPurchase> ReadFromFile()
        {
            List<IceCreamPurchase> iceCreamPurchaseList = new List<IceCreamPurchase>();
            string line;
            string[] iceCreamPurchaseInfo;

            fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            fileStream.Seek(0, SeekOrigin.Begin);
            streamReader = new StreamReader(fileStream);

            while ((line = streamReader.ReadLine()) != null)
            {
                iceCreamPurchaseInfo = line.Split(' ');
                if (iceCreamPurchaseInfo.Length == 4)
                    iceCreamPurchaseList.Add(new IceCreamPurchase(System.Int32.Parse(iceCreamPurchaseInfo[0]), iceCreamPurchaseInfo[1], System.Int32.Parse(iceCreamPurchaseInfo[2]), System.Int32.Parse(iceCreamPurchaseInfo[3])));
            }

            streamReader.Close();
            fileStream.Close();

            return iceCreamPurchaseList;
        }

        public void RewriteFile(List<IceCreamPurchase> iceCreamPurchaseList)
        {
            File.Delete(fileName);

            fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            streamWriter = new StreamWriter(fileStream);

            foreach (IceCreamPurchase s in iceCreamPurchaseList)
            {
                streamWriter.WriteLine(s.Id + " " + s.Name + " " + s.Quantity + " " + s.Price);
            }

            streamWriter.Close();
            fileStream.Close();
        }

        public List<IceCreamPurchase> Sort(List<IceCreamPurchase> iceCreamPurchaseList, string type, string order)
        {
            int compared = 0;

            for (int i = 0; i < iceCreamPurchaseList.Count() - 1; i++)
            {
                for (int j = i + 1; j < iceCreamPurchaseList.Count(); j++)
                {
                    switch (type)
                    {
                        case "0":
                            compared = iceCreamPurchaseList.ElementAt(i).Id.CompareTo(iceCreamPurchaseList.ElementAt(j).Id);
                            break;
                        case "1":
                            compared = iceCreamPurchaseList.ElementAt(i).Name.CompareTo(iceCreamPurchaseList.ElementAt(j).Name);
                            break;
                        case "2":
                            compared = iceCreamPurchaseList.ElementAt(i).Quantity.CompareTo(iceCreamPurchaseList.ElementAt(j).Quantity);
                            break;
                        case "3":
                            compared = iceCreamPurchaseList.ElementAt(i).Price.CompareTo(iceCreamPurchaseList.ElementAt(j).Price);
                            break;
                    }

                    if ((!Boolean.Parse(order) && compared > 0) || (Boolean.Parse(order) && compared < 0))
                    {
                        iceCreamPurchaseList.Insert(i, iceCreamPurchaseList.ElementAt(j));
                        iceCreamPurchaseList.RemoveAt(j + 1);
                        i--;
                        break;
                    }
                }
            }
            return iceCreamPurchaseList;
        }

        public List<IceCreamPurchase> Find(List<IceCreamPurchase> iceCreamPurchaseList, string type, string value)
        {
            int find = -1;

            for (int i = 0; i < iceCreamPurchaseList.Count(); i++)
            {
                switch (Int32.Parse(type))
                {
                    case 0:
                        find = iceCreamPurchaseList.ElementAt(i).Id.ToString().CompareTo(value);
                        break;
                    case 1:
                        find = iceCreamPurchaseList.ElementAt(i).Name.CompareTo(value);
                        break;
                    case 2:
                        find = iceCreamPurchaseList.ElementAt(i).Quantity.ToString().CompareTo(value);
                        break;
                    case 3:
                        find = iceCreamPurchaseList.ElementAt(i).Price.ToString().CompareTo(value);
                        break;
                }

                if (find != 0)
                {
                    find = -1;
                    iceCreamPurchaseList.Remove(iceCreamPurchaseList.ElementAt(i));
                    i--;
                }
            }

            return iceCreamPurchaseList;
        }
    }
}
