using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_5
{
    internal class DataMahasiswa1302213067
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"D:\Zaky\Kuliah\Semester 4\Kontruksi Perangkat Lunak\TP\MOD7\TP_KPL_MODUL7_KELOMPOK_5\tpmodul7_kelompok_5\tp7_1_1302213067.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"Nama {jsonObject.nama.depan} {jsonObject.nama.belakang} dengan nim {jsonObject.nim} dari fakultas {jsonObject.fakultas}");
        }
    }
}