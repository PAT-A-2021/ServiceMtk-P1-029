using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20190140029
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMatematika
    {
        [OperationContract]
        [FaultContract(typeof(MathFault))] //Membuat kelas yang melambangkan execption
        /* output->*/
        int Tambah(int a, int b); //method

        [OperationContract]
        [FaultContract(typeof(MathFault))] //Membuat kelas yang melambangkan execption
        int Kurang(int a, int b); //input

        [OperationContract]
        [FaultContract(typeof(MathFault))] //Membuat kelas yang melambangkan execption
        int Kali(int a, int b);

        [OperationContract]
        [FaultContract(typeof(MathFault))] //Membuat kelas yang melambangkan execption
        int Bagi(int a, int b);

        [OperationContract]
        [FaultContract(typeof(MathFault))] //Membuat kelas yang melambangkan execption
        Koordinat TKoordinat(Koordinat a, Koordinat b); //object dari class
    }

    [DataContract]
    public class Koordinat
    {
        private int _x, _y; //atribut
        [DataMember]//membuka koordinat, x,y
        public int X //properties
        {
            get { return _x; }
            set { _x = value; }
        }
        [DataMember]
        public int Y //properties
        {
            get { return _y; }
            set { _y = value; }
        }
    }

    //Tambahkan kelas berikut
    [DataContract]
    class MathFault
    {
        [DataMember]
        public string Kode { get; set; }
        [DataMember]
        public string Pesan { get; set; }
    }
}
