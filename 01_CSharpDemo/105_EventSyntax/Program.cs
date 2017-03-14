using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _105_EventSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First
            //var e = new TestEvent(5);
            //e.SetValue(100);

            //e.ChangeNum +=new TestEvent.NumManipulationHandler(TestEvent.EventFailed);
            //e.SetValue(200);

            //Console.ReadLine();
            #endregion

            TestEvent e = new TestEvent(5);
            e.SetValue(100);

            e.ChangeNum +=new TestEvent.NumManipulationHandler(TestEvent.EventFailed);
            e.SetValue(70);

            Console.ReadLine();
        }
    }

    /// <summary>
    /// first
    /// </summary>
    //class TestEvent
    //{
    //    private int value;
    //    public delegate void NumManipulationHandler();
    //    public event NumManipulationHandler ChangeNum;

    //    protected virtual void OnNumChanged()
    //    {
    //        if (ChangeNum != null)
    //        {
    //            ChangeNum();
    //        }
    //        else
    //        {
    //            Console.WriteLine("Event Failed");
    //        }
    //    }

    //    public void SetValue(int n)
    //    {
    //        if (value != n)
    //        {
    //            value = n;
    //            OnNumChanged();
    //        }
    //    }

    //    public TestEvent(int n)
    //    {
    //        SetValue(n);
    //    }

    //    public static void EventFailed()
    //    {
    //        Console.WriteLine("Binded Event Failed");
    //    }
    //}

    class TestEvent
    {
        private int value;
        public delegate void NumManipulationHandler();
        public event NumManipulationHandler ChangeNum;

        public virtual void OnChangeNum()
        {
            if (ChangeNum != null)
            {
                ChangeNum();
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnChangeNum();
            }
        }

        public TestEvent(int n)
        {
            SetValue(n);
        }

        public static void EventFailed()
        {
            Console.WriteLine("Binded Data Failed");
        }
    }
}

