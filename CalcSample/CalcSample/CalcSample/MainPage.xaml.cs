using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcSample
{

    public partial class MainPage : ContentPage
    {

        private Button[] buttons = new Button[AppConst.BUTTON_LENGTH];

        public MainPage()
        {
            InitializeComponent();

            // コードでボタンを作ってみる
            int x, y = 0;
            for (int ii = 0; ii < AppConst.BUTTON_LENGTH; ii++)
            {
                // 0～9のボタン生成
                buttons[ii] = new Button
                {
                    Text = ii.ToString(),
                };

                // イベント追加
                buttons[ii].Clicked += OnNumberButtonClicked;

                // 配置先の設定
                x = ii == 0 ? 0 : (ii - 1) % 3;
                y = ii == 0 ? 3 : 2 - (int) ((ii - 1) / 3);
                
                // レイアウトに配置
                layoutButtons.Children.Add(buttons[ii], x, y);

            }

            Button clear = new Button
            {
                Text = "C",
            };

            clear.Clicked += (sender, args) =>
            {
                tMain.Text = "";
            };

            layoutButtons.Children.Add(clear, 2, 3);

        }

        // 数字ボタン押下イベント
        void OnNumberButtonClicked(object sender, EventArgs args)
        {
            // 自分の数字を文字表示に追加
            tMain.Text += (sender as Button).Text;
        }
    }
}
