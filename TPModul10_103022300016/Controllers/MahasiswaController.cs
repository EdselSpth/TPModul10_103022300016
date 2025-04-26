    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    namespace TPModul10_103022300016.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class MahasiswaController : ControllerBase
        {
            // list Mahasiswa berisi data mahasiswa
            private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
            {
                new Mahasiswa("Edsel Septa Haryanto", "103022300016"),
                new Mahasiswa("Gusti Agung Raka Darma Putra Kepakisan" , "103022300088"),
                new Mahasiswa("Tio Funny Tinambunan", "103022330036"),
                new Mahasiswa("Abdul Azis Saepurohmat", "1030223000092"),
                new Mahasiswa("Reza Indra Maulana", "103022300109"),
                new Mahasiswa("Deru Khairan Djuharianto", "103022300101"),
            };

            // GET: api/Mahasiswa : Mengembalikan output isi list Mahasiswa
            [HttpGet]
            public ActionResult<List<Mahasiswa>> GetAll()
            {
                return mahasiswaList;
            }

            // GET: /api/mahasiswa/{index}: Mengembalikan output isi list Mahasiswa sesuai index
            [HttpGet("{index}")]
            public ActionResult<Mahasiswa> GetByIndex(int index)
            {
                if (index < 0 || index >= mahasiswaList.Count)
                    return NotFound();
                return mahasiswaList[index];
            }

            // Post: /api/mahasiswa : Menambah data mahasiswa baru ke dalam list
            [HttpPost]
            public ActionResult<List<Mahasiswa>> Create(Mahasiswa mhs)
            {
                mahasiswaList.Add(mhs);
                return mahasiswaList;
            }

            // Delete: /api/mahasiswa/{index} : Menghapus data mahasiswa sesuai index
            [HttpDelete("{index}")]
            public ActionResult<List<Mahasiswa>> Delete(int index)
            {
                if (index < 0 || index >= mahasiswaList.Count)
                    return NotFound();
                mahasiswaList.RemoveAt(index);
                return mahasiswaList;
            }
        }
    }
