using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mrealtime.Database
{
    class DBFire
    {
        FirebaseClient client;
        public DBFire()
        {
            client = new FirebaseClient("https://db-sample-c7e86.firebaseio.com/");
        }
        public async Task<List<Model.tdpdata>> getList()
        {
            var list = (await client.Child("tdpdata")
                       .OnceAsync<Model.tdpdata>())
                       .Select(item =>
                               new Model.tdpdata {
                                   nombre = item.Object.nombre,
                                   apellido = item.Object.apellido
                               }).ToList();
            return list;
        }
    }
}
