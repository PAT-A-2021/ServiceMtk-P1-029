﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20190140029
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Matematika : IMatematika
    {
        public int Bagi(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //secara default
                //throw new Execption(ex.Message) //pesan error secara default
                //throw new faultExecption ("Pesan Salah"); //Untuk meloloskan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }

        }
        public int Kali(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //secara default
                //throw new Execption(ex.Message) //pesan error secara default
                //throw new faultExecption ("Pesan Salah"); //Untuk meloloskan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }

        }
        public int Kurang(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //secara default
                //throw new Execption(ex.Message) //pesan error secara default
                //throw new faultExecption ("Pesan Salah"); //Untuk meloloskan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }

        }
        public int Tambah(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //secara default
                //throw new Execption(ex.Message) //pesan error secara default
                //throw new faultExecption ("Pesan Salah"); //Untuk meloloskan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }

        }
        //TKoordinat:nama methodnya, a,b = input seperti int.
        //Membuat koordinat hasil lalu menjumlahkan xa dengan xb, ya dengan yb lalu dimasukkan ke hasil
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

                //secara default
                //throw new Execption(ex.Message) //pesan error secara default
                //throw new faultExecption ("Pesan Salah"); //Untuk meloloskan pesan error yang dikirim ke client

                MathFault mf = new MathFault();
                mf.Kode = "Inputan Yang Anda Masukkan Salah";
                mf.Pesan = "Masukkan Input Yang Benar";
                throw new FaultException<MathFault>(mf);
            }
        }
    }
}