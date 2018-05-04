using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ComboBoxItem<T>
    {   
        public string ItemText { get; set; }
        public T ItemValue { get; set; }
    }
}
