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
            AddTag addTag = new AddTag();
            addTag.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //검색할 태그를 입력할 textbox
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //설정 버튼
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //태그를 이용해 검색된 결과를 띄워놓을 listview
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //선택된 곡의 앨범아트가 표시될 picturebox
        }

        private void play_Click(object sender, EventArgs e)
        {
            //선택된 곡을 재생할 버튼
            //한번 더 누르면 일시정지로 기능함
        }

        private void stop_Click(object sender, EventArgs e)
        {
            //선택된 곡을 완전히 정지함
            //다시 재생버튼을 누를 경우 처음부터 다시 재생함
        }

        private void rew_Click(object sender, EventArgs e)
        {
            //선택된 곡의 처음으로 돌아가 재생함
        }

        private void prev_Click(object sender, EventArgs e)
        {
            //검색결과 정렬상에서 선택된 곡의 이전곡을 재생함
        }

        private void next_Click(object sender, EventArgs e)
        {
            //검색결과 정렬상에서 선택된 곡의 다음곡을 재생함
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            //재생 중인 곡의 진행상황을 프로그레스바의 차오름으로 표시
        }
    }
}
