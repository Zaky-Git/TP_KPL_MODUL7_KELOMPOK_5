using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace tpmodul7_kelompok_5
{
    internal class KuliahMahasiswa1302213067
    {
        public void ReadJson()
        {
            string file = File.ReadAllText(@"D:\Zaky\Kuliah\Semester 4\Kontruksi Perangkat Lunak\TP\MOD7\TP_KPL_MODUL7_KELOMPOK_5\tpmodul7_kelompok_5\tp7_2_1302213067.json");

            dynamic JsonObj = JsonConvert.DeserializeObject(file);

            int i = 1;

            foreach (var course in JsonObj.courses)
            {
                Console.WriteLine($"MK {i} {course.code}-{course.name}");
                i++;
            }
        }

    }
}