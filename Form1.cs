using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Stroop_Test
{
    public enum Language { English, Chinese }
    public partial class Form1: Form {
        // Default language is English
        private Language _language;
        private int _mark;
        private Colors _colorList;
        private System.Windows.Forms.Timer _timer;
        private DateTime _startTime;
        private TimeSpan _elapsedTime;

        public Form1() {
            InitializeComponent();
            InitializeTimer();
            StartMenu();
            _colorList = new Colors();
            _language = Language.English;
            EnglishLanguage();
            _mark = 0;
        }

        private void languageButton_Click(object sender, EventArgs e) {
            if (_language == Language.English) {
                _language = Language.Chinese;
                // Update the UI elements to Chinese
                ChineseLanguage();
            } else if (_language == Language.Chinese) {
                _language = Language.English;
                // Update the UI elements to English
                EnglishLanguage();
            }
        }
        private void InitializeTimer() {
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 10;
            _timer.Tick += Timer_Tick;
            _elapsedTime = TimeSpan.Zero;
        }

        private void StartTimer() {
            InitializeTimer();
            _startTime = DateTime.Now;
            _timer.Start();
        }

        private void StopTimer() {
            _timer.Stop();
            _elapsedTime += DateTime.Now - _startTime;
        }

        private void Timer_Tick(object sender, EventArgs e) {
            TimeSpan currentElapsed = DateTime.Now - _startTime + _elapsedTime;
            timeLabel.Text = "Time: " + string.Format("{0:00}.{1:00}",
                (int)currentElapsed.Seconds,
                currentElapsed.Milliseconds / 10);
        }

        private void startButton_Click(object sender, EventArgs e) {
            GameMenu();
        }

        private void helpButton_Click(object sender, EventArgs e) {
            if (_language == Language.English) {
                MessageBox.Show("The Stroop Effect is a psychological phenomenon where the brain takes longer to process conflicting information, such as reading a color word that is printed in a different color. This test measures your reaction time and accuracy in identifying colors versus words.", "What is Stroop Effect?", MessageBoxButtons.OK, MessageBoxIcon.Question);
            } else if (_language == Language.Chinese) {
                MessageBox.Show("斯特鲁普效应是一个心理现象，当大脑处理冲突信息时会花费更长的时间，例如阅读一个颜色词，而这个词是用不同的颜色显示的。这个测试是测试你在识别颜色和文字时的反应时间和准确性。", "什么是斯特鲁普效应？", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void exitButton_Click(object sender, EventArgs e) {
            StartMenu();
            _mark = 0;
        }

        private void colorButton1_Click(object sender, EventArgs e) {
            if (_language == Language.English && colorButton1.BackColor == Color.FromName(colorLabel.Text)) {
                _mark++;
            } else if (_language == Language.Chinese && colorButton1.BackColor == Color.FromName(_colorList.GetEnglishColor(colorLabel.Text))) {
                _mark++;
            } else {
                _mark -= 2;
            }

            GenerateColor();
        }

        private void colorButton2_Click(object sender, EventArgs e) {
            if (_language == Language.English && colorButton2.BackColor == Color.FromName(colorLabel.Text)) {
                _mark++;
            } else if (_language == Language.Chinese && colorButton2.BackColor == Color.FromName(_colorList.GetEnglishColor(colorLabel.Text))) {
                _mark++;
            } else {
                _mark -= 3;
            }
            GenerateColor();
        }

        private void colorButton3_Click(object sender, EventArgs e) {
            if (_language == Language.English && colorButton3.BackColor == Color.FromName(colorLabel.Text)) {
                _mark++;
            } else if (_language == Language.Chinese && colorButton3.BackColor == Color.FromName(_colorList.GetEnglishColor(colorLabel.Text))) {
                _mark++;
            } else {
                _mark -= 3;
            }
            GenerateColor();
        }

        private void colorButton4_Click(object sender, EventArgs e) {
            if (_language == Language.English && colorButton4.BackColor == Color.FromName(colorLabel.Text)) {
                _mark++;
            } else if (_language == Language.Chinese && colorButton4.BackColor == Color.FromName(_colorList.GetEnglishColor(colorLabel.Text))) {
                _mark++;
            } else {
                _mark -= 3;
            }
            GenerateColor();
        }

        private void StartMenu() {
            StopTimer();
            _mark = 0;
            startButton.Show();
            languageButton.Show();
            helpButton.Show();
            titleLabel.Show();
            descriptionLabel.Show();

            exitButton.Hide();
            markLabel.Hide();
            colorLabel.Hide();
            timeLabel.Hide();
            colorButton1.Hide();
            colorButton2.Hide();
            colorButton3.Hide();
            colorButton4.Hide();
        }

        private void GameMenu() {
            StartTimer();
            _mark = 0;
            startButton.Hide();
            languageButton.Hide();
            helpButton.Hide();
            titleLabel.Hide();
            descriptionLabel.Hide();

            exitButton.Show();
            markLabel.Show();
            colorLabel.Show();
            timeLabel.Show();
            colorButton1.Show();
            colorButton2.Show();
            colorButton3.Show();
            colorButton4.Show();

            GenerateColor();
        }

        private void ChineseLanguage() {
            languageButton.Text = "EN";
            startButton.Text = "开始";
            titleLabel.Text = "斯特鲁普效应测试";
            descriptionLabel.Text = "在这个游戏中，题目会随机生成一个颜色的文字，同时下面会列出几个颜色选项；\r\n你需要根据文字的内容，选择选项中对应的颜色。\r\n选择正确加一分，选择错误扣三分，到达二十分则游戏结束。";
            descriptionLabel.Font = new Font(descriptionLabel.Font.FontFamily, 12F);
            markLabel.Text = "分数: " + _mark.ToString();
        }

        private void EnglishLanguage() {
            languageButton.Text = "CN";
            startButton.Text = "Start";
            titleLabel.Text = "Stroop Effect Test";
            descriptionLabel.Text = "In this game, you'll see a word written in a random color. \r\nBelow it, you'll choose the option that matches the meaning of the word, not its color.\r\nCorrect answers score one point; incorrect answers lose three point. The game ends when you reach 20 points.";
            descriptionLabel.Font = new Font(descriptionLabel.Font.FontFamily, 10F);
            markLabel.Text = "Marks: " + _mark.ToString();
        }
        private void Shuffle<T>(List<T> list) {
            Random random = new Random();
            int n = list.Count;

            while (n > 1) {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void GenerateColor() {
            switch (_language) {
                case Language.English:
                EnglishLanguage();
                if (_mark >= 20) {
                    StopTimer();
                    MessageBox.Show("You completed the challenge!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    StartMenu();
                } else if (_mark <= -10) {
                    StopTimer();
                    MessageBox.Show("You need to work harder", "What a pity", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    StartMenu();
                }
                break;

                case Language.Chinese:
                ChineseLanguage();
                if (_mark >= 20) {
                    StopTimer();
                    MessageBox.Show("你完成了挑战！", "恭喜你！", MessageBoxButtons.OK, MessageBoxIcon.None);
                    StartMenu();
                } else if (_mark <= -10) {
                    StopTimer();
                    MessageBox.Show("还要加把劲阿", "可惜了", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    StartMenu();
                }
                break;
            }

            _colorList.RandomColor();

            List<string> colorList_en = _colorList.ReturnEnglishColorList();
            List<string> colorList_cn = _colorList.ReturnChineseColorList();

            if (_language == Language.English) {
                colorLabel.Text = colorList_en[0];
            } else if (_language == Language.Chinese) {
                colorLabel.Text = colorList_cn[0];
            } else {
                colorLabel.Text = "Color";
            }

            colorLabel.ForeColor = Color.FromName(colorList_en[1]);

            // Setting Button color
            Shuffle(colorList_en);
            colorButton1.BackColor = Color.FromName(colorList_en[0]);
            colorButton2.BackColor = Color.FromName(colorList_en[1]);
            colorButton3.BackColor = Color.FromName(colorList_en[2]);
            colorButton4.BackColor = Color.FromName(colorList_en[3]);
        }
    }
}