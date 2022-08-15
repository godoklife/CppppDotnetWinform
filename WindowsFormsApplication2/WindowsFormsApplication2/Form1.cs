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
        string[,] listData = null;   // 파일 불러오기 메서드에서 초기화 시킨다.
        public Form1()
        {
            if (!di.Exists) // 게시글 저장 폴더가 없을 경우
            {
                di.Create();    // 폴더 생성
            }
            listData = fileLoad();  // 파일 불러오기(인수 기본값 : 게시글 파일)
            InitializeComponent();  // 컴포넌트 초기화 매서드
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

       

        private void btnTest_Click(object sender, EventArgs e)
        {
            showList(listData);
        }

        private void listDoubleClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("선택 : "+listBoard.SelectedIndices.Count); // 열(col)값
            Console.WriteLine("선택 : " + listBoard.FocusedItem.Index);   // 행(row)값
        }

        // ---------------------------------------------

        // 1. 파일 저장 메서드 (기본값 : 게시글 txt파일)
        private bool fileSave(String title, string content, string fileName= "\\WindowsFormsApplications2.txt")
        {
            try
            {
                StreamWriter sw;    // 파일 쓰기를 위한 StreamWriter class ㅅㅓㄴ언
                sw = File.AppendText(di + fileName);   // 파일 클래스를 통한 텍스트파일 열기
                sw.Write("<title>" + title + "</title>" + "<content>" + content + "</content>");
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

        // 2. 파일 불러오기 메서드 (기본값 : 게시글 txt파일)
        private string[,] fileLoad(string fileName= "\\WindowsFormsApplications2.txt")
        {
            try
            {
                Console.WriteLine("1 : " + fileName);       //  \WindowsFormsApplications2.txt
                Console.WriteLine("2 : " + di.FullName);    // C:\C:\VS2022\TestData
                Console.WriteLine("3 : " + di.Name);        // TestData
                Console.WriteLine("4 : " + di.Root);        // C:\
                Console.WriteLine("5 : " + di);             // C:\VS2022\TestData
                Console.WriteLine("6 : " + di + fileName);  // C:\VS2022\TestData\WindowsFormsApplications2.txt

                StreamReader sr = new StreamReader(di.FullName+fileName);
                String tmpData = sr.ReadToEnd();

                string[] splitStr = { "<title>", "</title>", "<content>", "</content>" };
                string[] splitData = tmpData.Split(splitStr, StringSplitOptions.RemoveEmptyEntries);
                //////////////////////////////////////////////////////////
                string[,] data = new string[splitData.Length / 2, 2];
                
                for(int i=0; i<splitData.Length ; i+=2)
                {
                    data[i/2, 0] = splitData[i];
                    data[i/2, 1] = splitData[i+1];
                }


               

                sr.Close();
                return data;
            }
            catch (FileNotFoundException notFonund) // 파일이 없을시 빈 텍스트파일 생성
            {
                Console.WriteLine(notFonund.Message);
                File.Create(di + fileName).Close();
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("fileLoad Exception : " + ex.Message);
                MessageBox.Show(ex.Message, "경고");

                return null;
            }
            
        }

        // 3. 리스트뷰 초기화 메서드
        private void showList(string[,] listData)
        {
            fileLoad(); // listData 최신화
            listBoard.Items.Clear();    // 리스트뷰의 데이타(Col, 열) 초기화
                // 메모리까지 초기화되는가? 문서 찾아볼것

            if (listData == null)   // 저장된 게시글 데이타가 없을 경우
            {
                Console.WriteLine("listData == null");
                ListViewItem lvi = new ListViewItem();

                lvi.Text = "표시할 값이 없습니다.";  // 제목 열
                lvi.SubItems.Add("");  // 내용 열
                // 표시할 글이 없을때 출력할 코드 작성
                listBoard.Items.Add(lvi);
            }
            else
            {
                for(int i=0; i<listData.GetLength(0); i++)  // x값의 길이
                {
                    Console.WriteLine("i : " + i);
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = (listData[i,0]);           // 제목 열
                    lvi.SubItems.Add(listData[i,1]);    // 내용 열
                    listBoard.Items.Add(lvi);
                }
            }
        }

        private void listBoard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
