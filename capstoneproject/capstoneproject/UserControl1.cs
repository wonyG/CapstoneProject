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
    /// <summary>
    /// 패널에 필요한것: PictureBox 1개, Label 6개, Button 5개, 슬라이드 1개
    /// </summary>
    
    
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //TextBox에 있는 텍스트를 가져와서 Tag검색
            //SQL 쿼리문을 이용해서 DB에서 검색
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //UserControl2로 이동하는 버튼
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //listbox에서 선택된 곡을 제거하는 버튼
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //UserControl3로 이동하는 버튼
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //listbox에서 선택한 한 곡을 반복재생 하는 버튼
            //or 현재 재생중인 곡을 반복재생 하는 버튼
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //listbox 내부에 있는 모든 곡을 랜덤하게 재생하는 버튼
            //random()함수값/listbox 내부에 있는 개체의 갯수를 계산해서 재생하면 될듯
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //listbox 내부에 있는 모든 곡을 순차적으로 반복재생하는 버튼
            //if listbox.length < count, count = 0 를 사용하면 될듯
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
