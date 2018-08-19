using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questions
{
    public partial class QuestionForm : Form
    {
        /// <summary>
        /// 質問の最大数
        /// </summary>
        private const int MAX_QUESTION_COUNT = 2;

        /// <summary>
        /// 全質問を保持する配列
        /// </summary>
        private Question[] AllQuestions = new Question[MAX_QUESTION_COUNT];

        /// <summary>
        /// 4択ボタン
        /// </summary>
        private Button[] AnswerButtons = new Button[4];

        /// <summary>
        /// 現在表示している質問の番号
        /// </summary>
        private int CurrentNo = -1;

        /// <summary>
        /// 初期化処理
        /// </summary>
        public QuestionForm()
        {
            InitializeComponent();

            //問題の表示形式を指定
            this.Question.AutoSize = true;
            this.Question.Name = "label1";
            this.Question.TabIndex = 0;

            //フォームに置いたボタンのインスタンスを配列に格納
            //NOTE:デザイナ上では、ボタンを配列として置けないらしい。。
            this.AnswerButtons[0] = this.Answer1;
            this.AnswerButtons[1] = this.Answer2;
            this.AnswerButtons[2] = this.Answer3;
            this.AnswerButtons[3] = this.Answer4;

            //全問題の初期化
            for (int no = 0; no < MAX_QUESTION_COUNT; no++)
            {
                this.AllQuestions[no] = this.CreateQuestion(no);
            }

            this.DisplayQuestion();
        }

        /// <summary>
        /// 質問の作成処理
        /// </summary>
        /// <param name="questionNo">質問の番号</param>
        /// <param name="questionNo">質問の番号</param>
        /// <returns>番号に対応した質問のテキスト</returns>
        private Question CreateQuestion(int questionNo)
        {
            Question newQ = new Question();
            string stCurrentDir = System.Environment.CurrentDirectory;

            // TODO:ここの番号毎に問題の内容を書くこと
            switch (questionNo)
            {
                case 0:
                    //1問目
                    newQ.Text = "問題１";

                    newQ.ButtonText[0] = "1";
                    newQ.ButtonText[1] = "2";
                    newQ.ButtonText[2] = "3";
                    newQ.ButtonText[3] = "4";

                    /* 
                     * TODO:nullのところに、割り当てたい画像をセットすること
                     * あと、画像はImagesフォルダに突っ込んでね。
                     * また、モジュールを作ったなら以下の指定が望ましい
                     * newQ.Image = this.LoadQuestionImage(@".\Images\question1.png");
                    */
                    newQ.Image = this.LoadQuestionImage(@"..\..\Images\question1.png");

                    // NOTE:0なら1個目、1なら2個目、2なら3個目、3なら4個目のボタンを押すと正解
                    newQ.AnswerNo = 0; 
                    break;
                case 1:
                    //2問目（1問目と同様に初期化すること）
                    newQ.Text = "問題２";

                    newQ.ButtonText[0] = "1";
                    newQ.ButtonText[1] = "2";
                    newQ.ButtonText[2] = "3";
                    newQ.ButtonText[3] = "4";

                    newQ.Image = this.LoadQuestionImage(@"..\..\Images\question2.png");

                    newQ.AnswerNo = 3;
                    break;
                case 2:
                    newQ.Text = "c";
                    break;
                case 3:
                    newQ.Text = "d";
                    break;
                case 4:
                    newQ.Text = "e";  
                    break;
                default:
                    //このパスはエラー。ちゃんとデバッグしよう
                    newQ = null;
                    break;
            }
            return newQ;
        }

        /// <summary>
        /// 質問の画像を表示する処理
        /// </summary>
        /// <param name="dir">画像ファイルが置いてあるディレクトリ</param>
        /// <returns>ディレクトリに画像ファイルが無ければnull</returns>
        private Image LoadQuestionImage(string dir)
        {
            return System.IO.File.Exists(dir) ? Image.FromFile(dir) : null;
        }

        /// <summary>
        /// 質問の表示処理
        /// </summary>
        private void DisplayQuestion()
        {
            //表示する問題をランダムに決定する(0～49）
            CurrentNo = new System.Random().Next(MAX_QUESTION_COUNT);

            //画面に問題を表示
            this.Question.Text = AllQuestions[CurrentNo].Text;
            this.QuestionImage.Image = AllQuestions[CurrentNo].Image;

            for (int i = 0; i < this.AnswerButtons.Length; i++)
            {
                this.AnswerButtons[i].Text = AllQuestions[CurrentNo].ButtonText[i];
            }
        }

        /// <summary>
        /// 回答処理
        /// </summary>
        /// <param name="questionNo">質問の番号</param>
        /// <returns></returns>
        private bool IsCorrectAnswer(int questionNo)
        {
            return false;
        }

        #region ボタンの押下処理
        private void answer1_Click(object sender, EventArgs e)
        {
            this.DisplayAnswerResult(0);
        }

        private void answer2_Click(object sender, EventArgs e)
        {
            this.DisplayAnswerResult(1);
        }

        private void answer3_Click(object sender, EventArgs e)
        {
            this.DisplayAnswerResult(2);
        }

        private void answer4_Click(object sender, EventArgs e)
        {
            this.DisplayAnswerResult(3);
        }
        #endregion

        /// <summary>
        /// 回答結果をダイアログに表示する処理
        /// </summary>
        /// <param name="answerNo"></param>
        private void DisplayAnswerResult(int answerNo)
        {
            //NOTE:回答結果をどう表示するかよくわかってないが、今回はダイアログにする
            if (this.AllQuestions[CurrentNo].InAnswerCorrect(answerNo))
            {
                //正解時の処理
                MessageBox.Show("正解！");
            }
            else
            {
                //不正解時の処理
                MessageBox.Show("残念！");
            }

            this.DisplayQuestion();
        }

    }
}
