using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        DirectoryInfo di = new DirectoryInfo(@"C:\VS2022\TestData");
        string saveFileName = "\\WindowsFormsApplications2.txt";
        public Form1()
        {
            if (!di.Exists)
                di.Create();
            List<string> boardData = fileLoad();

            InitializeComponent();
            
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("제목을 입력하세요.", "알림");
                return;
            }
            if (txtContent.Text == "")
            {
                MessageBox.Show("내용을 입력하세요.", "알림");
                return;
            }

            if(fileSave(txtTitle.Text, txtContent.Text))
            {
                MessageBox.Show("성공적으로 저장했습니다.", "알림");
                txtTitle.Clear();
                txtContent.Clear();
            }
            else
            {
                MessageBox.Show("저장에 실패했습니다.", "경고");
                return;
            }

        }

        private void listBoard_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // ---------------------------------------------

        // 1.파일처리 메서드
        private bool fileSave(String title, string content)
        {
            try
            {
                StreamWriter sw;    // 파일 쓰기를 위한 StreamWriter class ㅅㅓㄴ언
                sw = File.AppendText(di + saveFileName);   // 파일 클래스를 통한 텍스트파일 열기
                sw.WriteLine(title + "|" + content);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("fileSave Exception : " + ex.Message);
                MessageBox.Show(ex.Message, "경고");
                return false;
            }

            return true;
        }

        private List<string> fileLoad()
        {
            try
            {
                File.ReadAllText(di + saveFileName);
                StreamReader sr;
            }
            catch (FileNotFoundException notFonund)
            {
                File.Create(di + saveFileName);
                return null;
                // Console.WriteLine("fileLoad Exception : "+ notFonund.Message);
                // MessageBox.Show(notFonund.Message, "경고");

            }
            catch (Exception ex)
            {
                Console.WriteLine("fileLoad Exception : " + ex.Message);
                MessageBox.Show(ex.Message, "경고");
                return null;
            }
            
            return new List<string>();
        }

    }
}
