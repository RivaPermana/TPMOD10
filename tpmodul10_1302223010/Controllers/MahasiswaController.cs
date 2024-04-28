using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302223010.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController
    {
        private static List<Mahasiswa> mhs = new List<Mahasiswa>()
        {
            new Mahasiswa("Riva Dwi Fadhillah Fajri Permana", "1302223010"),
            new Mahasiswa("Cokorda Arturito Revan Putra Diarta", "1302223057"),
            new Mahasiswa("Rd.M. Faisal Ramadhan Junaidi", "1302220093"),
            new Mahasiswa("Farrel Haykal Giffari", "1302220064"),
            new Mahasiswa("Rifqi Alghifari", "1302223028"),
            new Mahasiswa("Faishal Harits Al-Fajri", "1302223120"),
        };

        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return mhs;
        }

        [HttpPost]
        public void post([FromBody] Mahasiswa ListMahasiswa)
        {
            mhs.Add(ListMahasiswa);
        }
        [HttpGet("{id}")]

        public Mahasiswa Get(int id)
        {
            return mhs[id];
        }
        [HttpDelete("{id}")]

        public void delete(int id)
        {
            mhs.RemoveAt(id);
        }

    }
}
