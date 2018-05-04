using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace 青鸟影院
{
    [Serializable]
    // 电影院类
    public class Cinema
    {
        public Cinema()
        {
            //二进制
            SoldTickets = new List<Ticket>();
            //时间表
            Schedule = new Schedule();
            //座位
            Seats = new Dictionary<string, Seat>();
        }


        public Schedule Schedule { get; set; }

        public Dictionary<string, Seat> Seats { get; set; }

        public List<Ticket> SoldTickets { get; set; }

        // 加载放映场次
        public void Load()
        {
            using (FileStream fs = new FileStream("student.dat",FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                this.SoldTickets = bf.Deserialize(fs) as List<Ticket>;
            }
        }


        // 保存销售信息
        public void Save()
        {
            using (FileStream fs = new FileStream("student.dat",FileMode.Create))
            {
                //序例化
                BinaryFormatter bf = new BinaryFormatter();
              
                bf.Serialize(fs, SoldTickets);
            }

        }
    }
}
