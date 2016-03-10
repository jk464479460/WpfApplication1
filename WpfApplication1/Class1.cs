using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public delegate void UpdateUiTb(object sender, EventMy e);
    class Class1
    {
    }

    public class EventMy : EventArgs
    {
        public string Text { get; set; }
    }
    public class TestDispatcher
    {
        public event UpdateUiTb UpdateUiHandler;

        public void Update()
        {
            var sender = this;
            var para=new EventMy {Text=$"{DateTime.Now.Second}"};
           UpdateUiHandler?.Invoke(sender,para);
        }
    }
}
