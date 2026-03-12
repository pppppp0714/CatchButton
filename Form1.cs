using System.Media;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        // 점수 변수 (초기값 0)
        public int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void thiefbutton_MouseEnter(object sender, EventArgs e)
        {
            // 1. 난수 생성기 준비
            Random rd = new Random();
            // 2. 가용 영역 계산(버튼이 폼 테두리에 걸리지 않게 보호)
            // ClientSize는 타이틀바와 테두리를 제외한 실제 흰 도화지 영역임
            // 최대가용치는 도화지영역에서 버튼크기를 뺀값
            int maxX = this.ClientSize.Width - thiefbutton.Width;
            int maxY = this.ClientSize.Height - thiefbutton.Height;
            // 3. 랜덤 좌표 추출(0 ~ 최대가용치사이)
            int nextX = rd.Next(0, maxX);
            int nextY = rd.Next(0, maxY);
            // 4. 위치 할당(새로운 Point 객체생성)
            thiefbutton.Location = new Point(nextX, nextY);
            // 5. 도망갔을 시 점수 차감
            score = score - 10;
            // 6. 시각적 피드백(폼 제목 표시줄에 좌표와 현재 점수 출력)
            this.Text = $"버튼위치 : ({nextX}, {nextY}) / 현재 점수 : {score}";
            // 7. 도망갔을 시의 효과음 출력
            SystemSounds.Beep.Play();
        }

        private void thiefbutton_Click(object sender, EventArgs e)
        {
            // 1. 성공 효과음 재생
            SystemSounds.Asterisk.Play();
            // 2. 메시지박스 표시
            System.Windows.Forms.MessageBox.Show("축하합니다~!");
            // 3. 잡았을 시 점수 증가
            score = score + 100;
            // 4. 시각적 피드백(현재 점수 출력)
            this.Text = $"현재 점수 : {score}";
            // 5. 성공 시 버튼 크기를 10% 줄임 (최소 크기 보장)
            int newWidth = Math.Max((int)(thiefbutton.Width * 0.9), 10);
            int newHeight = Math.Max((int)(thiefbutton.Height * 0.9), 10);
            thiefbutton.Size = new Size(newWidth, newHeight);
        }
    }
}
