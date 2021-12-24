using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StringToText {

    internal class Program {

        private static void Main(string[] args) {
            string fileName = "matstat.txt";
            string path = @"C:\Users\Guren\Desktop\";
            string[] allValuesArray = new string[100];

            try {
                using (StreamReader sr = new StreamReader(path + fileName)) {
                    allValuesArray = sr.ReadToEnd().Trim().Split(' ');
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            using (StreamWriter sw = new StreamWriter(path + "matstatNew.txt", false, Encoding.Default)) {
                string stroka = "";
                for (int i = 0; i < 10; i++) {
                    for (int j = 0; j < 10; j++) {
                        stroka += allValuesArray[i * 10 + j] + ";";
                    }
                    sw.WriteLine(stroka);
                    stroka = "";
                }
            }
            Console.ReadKey();
        }
    }
}