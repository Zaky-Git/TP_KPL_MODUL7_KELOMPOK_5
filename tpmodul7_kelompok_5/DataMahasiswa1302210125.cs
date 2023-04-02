using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_5
{
    internal class DataMahasiswa1302210125
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText(@"C:\Users\iceice\Documents\semester 4\kpl\GITGITUB\TP_MOD7_1302210125\TP_KPL_MODUL7_KELOMPOK_5\tpmodul7_kelompok_5\tp7_1_1302210125.json");

            dynamic jsonObject = JsonConvert.DeserializeObject(jsonString);

            Console.WriteLine($"Nama {jsonObject.nama.depan} {jsonObject.nama.belakang} dengan nim {jsonObject.nim} dari fakultas {jsonObject.fakultas}");
        }
    }
}