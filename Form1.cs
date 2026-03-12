namespace CatchButton
{
    public partial class Form1 : Form
    {
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
            // 5. 시각적 피드백(폼 제목 표시줄에 좌표 출력)
            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }
    }
}
