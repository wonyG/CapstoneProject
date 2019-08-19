using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstoneproject
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //추가할 태그를 선택할 콤보박스
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //combobox에서 선택한 태그를 음악에 추가하는 버튼
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //usercontrol3로 이동하는 버튼
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //변경 내용을 확인하고 반영하는 버튼
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //변경 내용을 적용하지 않고 취소하는 버튼
        }
    }
}
