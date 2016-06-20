using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        string filename = @"d:\testbinary.st";
        #region 结构体
        [StructLayout(LayoutKind.Sequential), Serializable]
        public struct MY_STRUCT
        {
            public double x;          //点的经度坐标
            public double y;          //点的纬度坐标
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
            public string Name;        //Name[40]; //名称
            public long PointID;  //点的ID号
            public long TypeCode; //客户不使用该字段
        }
        #endregion

        public void WriteInfo(byte[] bt)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
                return;
            }
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(bt);
            bw.Flush();
            bw.Close();
            fs.Close();
            MessageBox.Show("保存成功!");
        }
        public byte[] ReadInfo(string file)
        {
            FileStream fs = new FileStream(file, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            byte[] bt = br.ReadBytes(144);
            br.Close();
            fs.Close();
            return bt;
        }
        private MY_STRUCT Byte2Struct(byte[] arr)
        {
            int structSize = Marshal.SizeOf(typeof(MY_STRUCT));
            IntPtr ptemp = Marshal.AllocHGlobal(structSize);
            Marshal.Copy(arr, 0, ptemp, structSize);
            MY_STRUCT rs = (MY_STRUCT)Marshal.PtrToStructure(ptemp, typeof(MY_STRUCT));
            Marshal.FreeHGlobal(ptemp);
            return rs;
        }
        private byte[] Struct2Byte(MY_STRUCT s)
        {
            int structSize = Marshal.SizeOf(typeof(MY_STRUCT));
            byte[] buffer = new byte[structSize];
            //分配结构体大小的内存空间 
            IntPtr structPtr = Marshal.AllocHGlobal(structSize);
            //将结构体拷到分配好的内存空间 
            Marshal.StructureToPtr(s, structPtr, false);
            //从内存空间拷到byte数组 
            Marshal.Copy(structPtr, buffer, 0, structSize);
            //释放内存空间 
            Marshal.FreeHGlobal(structPtr);
            return buffer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MY_STRUCT[] arr = new MY_STRUCT[2];
            MY_STRUCT np = new MY_STRUCT();
            np.x = 112.123456;
            np.y = 21.56789;
            np.Name = "深圳市政府1";
            np.PointID = Convert.ToInt64(1234);
            np.TypeCode = Convert.ToInt64(65);
            arr[0] = np;
            np = new MY_STRUCT();
            np.x = 113.123456;
            np.y = 22.56789;
            np.Name = "深圳市政府2";
            np.PointID = Convert.ToInt64(1235);
            np.TypeCode = Convert.ToInt64(66);
            arr[1] = np;
            int structSize = Marshal.SizeOf(typeof(MY_STRUCT));
            byte[] temp = new byte[structSize * arr.Length];
            byte[] temp1 = Struct2Byte(arr[0]);
            byte[] temp2 = Struct2Byte(arr[1]);
            Array.Copy(temp1, 0, temp, 0, temp1.Length);
            Array.Copy(temp2, 0, temp, structSize, temp2.Length);
            WriteInfo(temp);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            byte[] bt = ReadInfo(filename);
            int structSize = Marshal.SizeOf(typeof(MY_STRUCT));
            int num = bt.Length / structSize;
            List<MY_STRUCT> list = new List<MY_STRUCT>();
            for (int i = 0; i < num; i++)
            {
                byte[] temp = new byte[structSize];
                Array.Copy(bt, i * structSize, temp, 0, structSize);
                MY_STRUCT np = new MY_STRUCT();
                np = Byte2Struct(temp);
                list.Add(np);
            }
            MessageBox.Show("读取成功!"+list.ToString());
        }

    }
}
