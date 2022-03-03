using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20190140029
{
    /// <summary>
    /// Main Class
    /// </summary>
    /// <remarks> Operasi yang digunakan sebagai tampilan yang menghubungkan dengan operasi di IMatematika </remarks>
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Matematika : IMatematika
    {
        /// <summary>
        /// Fungsi Operasi dari pembagian
        /// </summary>
        /// <param name="a"> Angka pertama yang akan di masukkan </param>
        /// <param name="b"> Angka kedua yang akan di masukkan</param>
        /// <returns> Hasil dari proses pembagian parameter a dan b</returns>
        public int Bagi(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                ///<remarks> secara default, throw new Execption(ex.Message) pesan error secara default </remarks>
                ///<return> throw new faultExecption ("Pesan Salah"); Untuk meloloskan pesan error yang dikirim ke client </return>

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }

        }
        /// <summary>
        /// Fungsi Operasi dari perkalian
        /// </summary>
        /// <param name="a"> Angka pertama yang akan di masukkan </param>
        /// <param name="b"> Angka kedua yang akan di masukkan</param>
        /// <returns> Hasil dari proses perkalian parameter a dan b</returns>
        public int Kali(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                ///<remarks> secara default, throw new Execption(ex.Message) pesan error secara default </remarks>
                ///<return> throw new faultExecption ("Pesan Salah"); Untuk meloloskan pesan error yang dikirim ke client </return>

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }

        }
        /// <summary>
        /// Fungsi Operasi dari pengurangan
        /// </summary>
        /// <param name="a"> Angka pertama yang akan di masukkan </param>
        /// <param name="b"> Angka kedua yang akan di masukkan </param>
        /// <returns> Hasil dari proses pengurangan parameter a dan b </returns>
        public int Kurang(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                ///<remarks> secara default, throw new Execption(ex.Message) pesan error secara default </remarks>
                ///<return> throw new faultExecption ("Pesan Salah"); Untuk meloloskan pesan error yang dikirim ke client </return>

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }

        }
        /// <summary>
        /// Fungsi Operasi dari pertambahan
        /// </summary>
        /// <param name="a"> Angka pertama yang akan di masukkan </param>
        /// <param name="b"> Angka kedua yang akan di masukkan </param>
        /// <returns> Hasil dari proses Pertambahan parameter a dan b </returns>
        public int Tambah(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                ///<remarks> secara default, throw new Execption(ex.Message) pesan error secara default </remarks>
                ///<return> throw new faultExecption ("Pesan Salah"); Untuk meloloskan pesan error yang dikirim ke client </return>

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }

        }
        ///<remarks> TKoordinat:nama methodnya, a,b = input seperti int. </remarks>
        ///<returns> Membuat koordinat hasil lalu menjumlahkan xa dengan xb, ya dengan yb lalu dimasukkan ke hasil </returns>
        public Koordinat TKoordinat(Koordinat a, Koordinat b)
        {
            try
            {
                Koordinat hasil = new Koordinat();
                hasil.X = a.X + b.X;
                hasil.Y = a.Y + b.Y;
                return hasil;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                ///<remarks> secara default, throw new Execption(ex.Message) pesan error secara default </remarks>
                ///<return> throw new faultExecption ("Pesan Salah"); Untuk meloloskan pesan error yang dikirim ke client </return>

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }
        }
    }
}
