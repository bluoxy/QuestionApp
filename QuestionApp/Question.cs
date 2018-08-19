using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Questions
{
    /// <summary>
    /// 問題の情報を保持するクラス
    /// </summary>
    public class Question
    {
        /// <summary>
        /// 問題文のテキスト
        /// </summary>
        public string Text;

        /// <summary>
        /// 4択のボタンに表示するテキスト
        /// </summary>
        public string[] ButtonText = new string[4];

        /// <summary>
        /// 画面に表示する画像
        /// </summary>
        public Image Image;

        /// <summary>
        /// 正解の番号(0～3のみ)
        /// </summary>
        public int AnswerNo;

        /// <summary>
        /// 正答か確認する処理
        /// </summary>
        /// <param name="no">回答者の押した番号</param>
        /// <returns>正答か否か</returns>
        public bool InAnswerCorrect(int no)
        {
            return AnswerNo == no;
        }
    }
}
