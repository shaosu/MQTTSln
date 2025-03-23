using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMQTT.Controls
{
    public partial class uc_OnlineStatus : Control
    {
        private bool _online;
        public bool Online
        {
            get { return _online; }
            set
            {
                _online = value;
                this.Invalidate(); // 触发重绘  
            }
        }

        private string _OnlineTitle;
        public string OnlineTitle
        {
            get { return _OnlineTitle; }
            set
            {
                _OnlineTitle = value;
                this.Invalidate(); // 触发重绘
            }
        }

        private string _OffLineTitle;
        public string OffLineTitle
        {
            get { return _OffLineTitle; }
            set
            {
                _OffLineTitle = value;
                this.Invalidate();
            }
        }


        public uc_OnlineStatus()
        {
            InitializeComponent();
            OnlineTitle = "Online";
            OffLineTitle = "OffLine";
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Brush brush = new SolidBrush(Color.Red);
            string txt = _OffLineTitle;
            if (_online)
            {
                brush = new SolidBrush(Color.Green);
                txt = _OnlineTitle;
            }
            pe.Graphics.DrawString(txt, this.Font, brush, new PointF(0, 0));
        }
    }
}
