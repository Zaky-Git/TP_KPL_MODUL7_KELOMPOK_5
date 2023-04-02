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
    internal class KuliahMahasiswa1302210097
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"E:\Tugas Kuliah\Semester 4\KPL\Praktikum\TP_MODUL7_1302210097\TP_KPL_MODUL7_KELOMPOK_5\tpmodul7_kelompok_5\tp7_2_1302210097.json");

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