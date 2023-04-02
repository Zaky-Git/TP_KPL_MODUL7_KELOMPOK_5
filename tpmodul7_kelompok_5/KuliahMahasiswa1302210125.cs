using System;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace tpmodul7_kelompok_5
{
    internal class KuliahMahasiswa1302210125
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"C:\Users\iceice\Documents\semester 4\kpl\GITGITUB\TP_MOD7_1302210125\TP_KPL_MODUL7_KELOMPOK_5\tpmodul7_kelompok_5\tp7_2_1302210125.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int iter = 1;
            foreach (var course in jsonObject.courses)
            {
                Console.WriteLine($"MK {iter} {course.code}-{course.name}");
                iter++;
            }
        }
    }
}