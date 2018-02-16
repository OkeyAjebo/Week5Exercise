using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Exercise
{
    interface IPrintable
    {
        void Print();
        void ExportTo();
    }
    interface IStorable
    {
        void Read();
        void Write();
    }

    class Document : IPrintable, IStorable
    {
        public void ExportTo()
        {
        }

        public void Print()
        {
        }

        public void Read()
        {
        }

        public void Write()
        {
        }
    }
}

