using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_5
{
    internal class KuliahMahasiswa1302213016
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"E:\#ME\KULIAH\TUGAS\S4\KPL\PRAKTIKUM\MOD7\TP_KPL_MODUL7_KELOMPOK_5\tpmodul7_kelompok_5\tp7_2_1302213016.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var course in jsonObject.courses)
            {
                Console.WriteLine($"MK {i} {course.code} - {course.name}");
                i++;
            }
        }

    }
}