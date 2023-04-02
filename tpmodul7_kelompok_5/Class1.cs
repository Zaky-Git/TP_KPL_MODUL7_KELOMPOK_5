using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace tpmodul7_kelompok_5
{

    internal class DataMahasiswaFasyaRaihanMaulana
    {
        public void readJSON()
        {
          
            string jsonString = File.ReadAllText(@"C:\Users\Raychan\Documents\KuliAhhh\Kuliah\Semester 4\Kontruksi Perangkat Lunak\Tugas Pendahuluan\Tugas Pendahuluan 7\Zaky-Git-TP_KPL_MOD7_KELOMPOK_5\tpmodul7_kelompok_5\tp7_1_1302213116.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"Nama {jsonObject.nama.depan} {jsonObject.nama.belakang} dengan nim {jsonObject.nim} dari fakultas {jsonObject.fakultas}");
        }
    }
}
