using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace C
{
    public interface ICC {
        public CompositeCommand CCS { get; }
    }
    public class CC : ICC
    {
        public CompositeCommand CCS { get; }=new CompositeCommand();
    }
}
