using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _模拟移动硬盘_U盘_MP3插入电脑
{
    class Program
    {
        static void Main(string[] args)
        {
            //可移动设备：移动硬盘，U盘，MP3
            //电脑检测到设备插入后做出反应
            //模拟反应读写
            MobileStorage ms = new MP3();//new UPan();//new MobileDisk();
            Computer cpu = new Computer(ms);
            //cpu.cpuRead(ms);
            //cpu.cpuWrite(ms);

            cpu.cpuRead();
            cpu.cpuWrite();

            Console.ReadKey();
        }
    }

    public abstract class MobileStorage
    {
        public abstract void Write();
        public abstract void Read();
    }

    public class MobileDisk : MobileStorage
    { 
        public override void Read()
        {
            Console.WriteLine("移动硬盘读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("移动硬盘写入数据");
        }
    }

    public class UPan : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("U盘写入数据");
        }
    }

    public class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("MP3写入数据");
        }
    }

    public class Computer
    {
        private MobileStorage _ms;

        public MobileStorage Ms
        {
            get { return _ms; }
            set { _ms = value; }
        }

        public Computer(MobileStorage ms)
        {
            this.Ms = ms;
        }
        public void cpuRead()
        {
            this.Ms.Read();
        }

        public void cpuWrite()
        {
            this.Ms.Write();
        }
    }
}
