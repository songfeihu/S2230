using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxDemo
{
    //泛型类
    class ComboBoxItem<T>
    {
        public string ItemText { get; set; }//显示的文字
        public T ItemValue { get; set; }//实际的对象
    }
}
