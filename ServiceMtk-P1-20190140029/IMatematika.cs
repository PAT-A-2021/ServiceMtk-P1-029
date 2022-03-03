using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace ServiceMtk_P1_20190140029
{
    /// <summary>
    /// Berhubungan dengan method atau fungsi-fungsi dari service
    /// </summary>
    /// <remarks> Penghubung IMatematika dengan Matematika</remarks>
    ///<return>NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.</return>
    [ServiceContract]
    public interface IMatematika
    {
        [OperationContract]
        [FaultContract(typeof(MathFault))] ///<remarks>Membuat kelas yang melambangkan execption</remarks>
        /* output->*/
        int Tambah(int a, int b); ///<remarks>method</remarks>

        [OperationContract]
        [FaultContract(typeof(MathFault))] ///<remarks>Membuat kelas yang melambangkan execption</remarks>
        int Kurang(int a, int b); ///<remarks>input</remarks>

        [OperationContract]
        [FaultContract(typeof(MathFault))] ///<remarks>Membuat kelas yang melambangkan execption</remarks>
        int Kali(int a, int b);

        [OperationContract]
        [FaultContract(typeof(MathFault))] ///<remarks>Membuat kelas yang melambangkan execption</remarks>
        int Bagi(int a, int b);

        [OperationContract]
        [FaultContract(typeof(MathFault))] ///<remarks>Membuat kelas yang melambangkan execption</remarks>
        Koordinat TKoordinat(Koordinat a, Koordinat b); //object dari class
    }
    /// <summary>
    /// Berhubungan dengan data-data parameter dan property dari object service
    /// </summary>
    /// <remarks>Untuk mendefinisikan Class dari koordinat</remarks>
    [DataContract]
    public class Koordinat
    {
        private int _x, _y; ///<remarks>atribut</remarks>
        [DataMember]///<remarks>membuka koordinat, x,y</remarks>
        public int X ///<remarks>properties</remarks>
        {
            get { return _x; }
            set { _x = value; }
        }
        [DataMember]
        public int Y ///<remarks>properties</remarks>
        {
            get { return _y; }
            set { _y = value; }
        }
    }

    ///<remarks>Tambahkan kelas berikut</remarks>
    [DataContract]
    class MathFault
    {
        [DataMember]
        public string Kode { get; set; }
        [DataMember]
        public string Pesan { get; set; }
    }
}
