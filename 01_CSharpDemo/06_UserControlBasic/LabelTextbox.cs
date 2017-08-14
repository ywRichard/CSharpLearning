using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_UserControlBasic
{
    public partial class ctrLabelTextbox : UserControl
    {
        private PositionEnum position = PositionEnum.Right;

        private int textboxMargin = 0;
        public ctrLabelTextbox()
        {
            InitializeComponent();
        }

        public PositionEnum Position
        {
            get => position;
            set
            {
                position = value;
                MoveControls();
                PositionChanged?.Invoke(this, new EventArgs());
            }
        }
        public int TextboxMargin
        {
            get => textboxMargin;
            set
            {
                textboxMargin = value;
                MoveControls();
            }
        }

        public string LabelText
        {
            get
            { return lblCaption.Text; }
            set
            {
                lblCaption.Text = labelText = value;
                MoveControls();
            }
        }

        public string TextboxText
        {
            get { return txtTextbox.Text; }
            set { txtTextbox.Text = value; }
        }

        private string labelText = "";
        public enum PositionEnum
        {
            Right,
            Below
        }

        private void ctrLabelTextbox_Load(object sender, EventArgs e)
        {
            lblCaption.Text = labelText;
            this.Height = txtTextbox.Height > lblCaption.Height ?
                            txtTextbox.Height : lblCaption.Height;
            MoveControls();
        }

        private void ctrLabelTextbox_SizeChanged(object sender, EventArgs e)
        {
            MoveControls();
        }

        private void MoveControls()
        {
            switch (position)
            {
                case PositionEnum.Right:
                    {
                        txtTextbox.Top = lblCaption.Top;
                        if (textboxMargin == 0)
                        {
                            int width = Width - lblCaption.Width - 3;
                            txtTextbox.Left = lblCaption.Right + 3;
                            txtTextbox.Width = width;
                        }
                        else
                        {
                            txtTextbox.Left = textboxMargin + lblCaption.Width;
                            txtTextbox.Width = Width - txtTextbox.Left;
                        }
                        Height = (txtTextbox.Height > lblCaption.Height ?
                                    txtTextbox.Height : lblCaption.Height) + 10;
                    }
                    break;
                case PositionEnum.Below:
                    {
                        txtTextbox.Top = lblCaption.Bottom;
                        txtTextbox.Left = lblCaption.Left;
                        txtTextbox.Width = Width;
                        Height = txtTextbox.Height + lblCaption.Height;
                    }
                    break;
                default:
                    break;
            }
        }

        #region 继承自UserControl的事件
        private void txtTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        private void txtTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void txtTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }
        #endregion

        #region 父类中不存在的事件
        ///1、定义一个事件
        ///2、事件注册该方法
        ///3、调用用户注册的方法
        public event System.EventHandler PositionChanged;
        #endregion
    }
}
