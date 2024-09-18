using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ouyoquizu
{
    public partial class Form1 : Form
    {
        public static int i = 1;
        public static int j = 0;
        public static string k = "";
        public static int total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable data_Table = new DataTable();
            data_Table.Columns.Add("id");
            data_Table.Columns.Add("name");

            DataRow dr = data_Table.NewRow();
            dr["id"] = "10";
            dr["name"] = "10";
            data_Table.Rows.Add(dr);

            dr = data_Table.NewRow();
            dr["id"] = "11";
            dr["name"] = "20";
            data_Table.Rows.Add(dr);

            this.comboBox1.DataSource = data_Table;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "id";

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            Form1.total = int.Parse(comboBox1.Text);
            this.start_button.Visible = false;
            this.label1.Visible = false;
            this.comboBox1.Visible = false;
            this.title.Visible = false;

            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
            this.button5.Visible = true;

            this.button5.Focus();

            var Q_List = new List<string>()
            { "最初に格納したデータから順に処理を行うデータ構造","最後に格納したデータから順に処理を行うデータ構造",
              "物理層の中継機能を提供し、ケーブルを流れる電気信号を増幅する装置","データリンク層の中継機能を提供し、流れてきたパケットを監視し受け渡しを行う装置",
              "単位時間あたりの処理できる仕事量を表す指標","システムに処理要求を送ってから、処理が完了するまでにかかる時間",
              "ソースコードをひとつずつ翻訳しながら実行する時に使う言語プロセッサプログラム","データベースを操作する一連の流れをまとめ、DBMSにあらかじめ保存しておくこと",
              "電子メールの送信に使うプロトコル","電子メールの受信に使うプロトコル","作業成果物の作成者以外の参加者がモデレータとして主導すること",
              "パイプライン処理を行う回路を複数持たせることで全く同時に複数の命令を実行できるようにしたもの",
              "アナログデータを一定の時間単位で区切り、その時間ごとの信号レベルを標本として抽出したもの","CPUとメインメモリの間にある記憶装置で、CPUがアクセスする頻度の高いデータや命令を保存する",
              "複数の処理が互いに、他の処理が排他的に利用している資源（リソース）の開放を待つ状態となり、どの処理も進まなくなること",
              "なんらかの装置・システムにおいて、構成部品の破損や誤操作・誤動作による障害が発生した場合、常に安全側に動作するようにすること",
              "不要になったメモリ領域やオブジェクトを自動的に削除する仕組み","データの発生源の近くで処理を行うネットワーク技法",
              "システムや機器の一部が故障しても、予備の系統に切り替えるなどして機能を保ち、正常に稼働させ続ける仕組み",
              "コンピュータに不正侵入し、ユーザの個人情報や行動を監視して、ユーザが気づかないうちに外部に情報を送信するプログラム",
              "際限のあるリソース（資源）を順繰りに割り振ってゆく方式","「競合他社を圧倒的に上まわるレベルの能力」「競合他社に真似できない核となる能力」の事",
              "インターネット上でドメイン名とIPアドレスを紐づける役割を担うシステム","インターネットやスマートフォンなどを介して行われる商品やサービスの売買、つまりネット通販やネットショップなどを指す言葉",
              "システム設計を視覚的に図式化しての標準化されたモデリング手法の提供を目的としたもの",
              "異なるクラスのオブジェクトが同じインターフェースやメソッドを共有し、それぞれ異なる方法でこれらを実装すること",
              "企業内のIT戦略を立案したり実際に実行したりする際の責任者としての役割を負う",
              "ハードディスクにファイルを保存するときに、ファイルを一続きに保存できなくなり、ディスク上にとびとびに断片化されて記録している状態のこと",
              "データを複数のハードディスクに分散して書き込むこと",
              "複数の独立した作業や工程が連続して実施される際に、作業の日程計画を図形と数字で表現するためのフローチャート図",
              "細かく分断されたメモリ領域（フラグメント）をひとまとめにし、それらを連続したメモリ領域にすること",
              "コンピュータの通信で誤り検出に使われる技術"
            };

            var A_List = new List<string>()
            { "キュー","スタック","リピータ","ブリッジ","スループット","ターンアラウンドタイム","インタプリタ",
              "ストアドプロシージャ","SMTP","POP","インスペクション","スーパースカラ","サンプリング","キャッシュメモリ",
              "デッドロック","フェールセーフ","ガーベジコレクション","エッジコンピューティング","フォールトトレラント",
              "スパイウェア","ラウンドロビン","コアコンピタンス","DNS","EC","UML","ポリモーフィズム","CIO",
              "フラグメンテーション","ストライピング","アローダイアグラム","メモリコンパクション","パリティ"
            };

            Random r = new Random();
            int randomValue = r.Next(30);

            var memo = new List<int>()
            { randomValue };

            string Q = Q_List[randomValue];
            string A = A_List[randomValue];
            var Anser = new List<string>()
            { A };
            Form1.k = A;

            int i = 0;

            while (i <= 2)
            {
                Random random = new Random();
                int rnd = random.Next(5);

                if (Anser.Contains(A_List[rnd]) == false)
                {
                    Anser.Add(A_List[rnd]);
                    i++;
                }
            }

            Anser = Anser.OrderBy(a => Guid.NewGuid()).ToList();

            this.label2.Text = Q;
            this.button1.Text = Anser[0];
            this.button2.Text = Anser[1];
            this.button3.Text = Anser[2];
            this.button4.Text = Anser[3];
            this.Anser.Text = "A." + A;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void start_button_MouseHover(object sender, EventArgs e)
        {
            this.start_button.BackColor = Color.LightCoral;
        }

        private void start_button_MouseLeave(object sender, EventArgs e)
        {
            this.start_button.BackColor = Color.Red;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tilte_Click(object sender, EventArgs e)
        {

        }

 

        private void label5_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;

            if (button1.Text == k)
            {
                button1.UseVisualStyleBackColor = true;
            }
            if (button2.Text == k)
            {
                button2.UseVisualStyleBackColor = true;
            }
            if (button3.Text == k)
            {
                button3.UseVisualStyleBackColor = true;
            }
            if (button4.Text == k)
            {
                button4.UseVisualStyleBackColor = true;
            }

            Form1.i++;
            this.label3.Text = Form1.i.ToString();



            this.next.Visible = false;
            this.Anser.Visible = false;

            var Q_List = new List<string>()
            { "最初に格納したデータから順に処理を行うデータ構造","最後に格納したデータから順に処理を行うデータ構造",
              "物理層の中継機能を提供し、ケーブルを流れる電気信号を増幅する装置","データリンク層の中継機能を提供し、流れてきたパケットを監視し受け渡しを行う装置",
              "単位時間あたりの処理できる仕事量を表す指標","システムに処理要求を送ってから、処理が完了するまでにかかる時間",
              "ソースコードをひとつずつ翻訳しながら実行する時に使う言語プロセッサプログラム","データベースを操作する一連の流れをまとめ、DBMSにあらかじめ保存しておくこと",
              "電子メールの送信に使うプロトコル","電子メールの受信に使うプロトコル","作業成果物の作成者以外の参加者がモデレータとして主導すること",
              "パイプライン処理を行う回路を複数持たせることで全く同時に複数の命令を実行できるようにしたもの",
              "アナログデータを一定の時間単位で区切り、その時間ごとの信号レベルを標本として抽出したもの","CPUとメインメモリの間にある記憶装置で、CPUがアクセスする頻度の高いデータや命令を保存する",
              "複数の処理が互いに、他の処理が排他的に利用している資源（リソース）の開放を待つ状態となり、どの処理も進まなくなること",
              "なんらかの装置・システムにおいて、構成部品の破損や誤操作・誤動作による障害が発生した場合、常に安全側に動作するようにすること",
              "不要になったメモリ領域やオブジェクトを自動的に削除する仕組み","データの発生源の近くで処理を行うネットワーク技法",
              "システムや機器の一部が故障しても、予備の系統に切り替えるなどして機能を保ち、正常に稼働させ続ける仕組み",
              "コンピュータに不正侵入し、ユーザの個人情報や行動を監視して、ユーザが気づかないうちに外部に情報を送信するプログラム",
              "際限のあるリソース（資源）を順繰りに割り振ってゆく方式","「競合他社を圧倒的に上まわるレベルの能力」「競合他社に真似できない核となる能力」の事",
              "インターネット上でドメイン名とIPアドレスを紐づける役割を担うシステム","インターネットやスマートフォンなどを介して行われる商品やサービスの売買、つまりネット通販やネットショップなどを指す言葉",
              "システム設計を視覚的に図式化しての標準化されたモデリング手法の提供を目的としたもの",
              "異なるクラスのオブジェクトが同じインターフェースやメソッドを共有し、それぞれ異なる方法でこれらを実装すること",
              "企業内のIT戦略を立案したり実際に実行したりする際の責任者としての役割を負う存在",
              "ハードディスクにファイルを保存するときに、ファイルを一続きに保存できなくなり、ディスク上にとびとびに断片化されて記録している状態のこと",
              "データを複数のハードディスクに分散して書き込むこと",
              "複数の独立した作業や工程が連続して実施される際に、作業の日程計画を図形と数字で表現するためのフローチャート図",
              "細かく分断されたメモリ領域（フラグメント）をひとまとめにし、それらを連続したメモリ領域にすること",
              "コンピュータの通信で誤り検出に使われる技術"
            };

            var A_List = new List<string>()
            { "キュー","スタック","リピータ","ブリッジ","スループット","ターンアラウンドタイム","インタプリタ",
              "ストアドプロシージャ","SMTP","POP","インスペクション","スーパースカラ","サンプリング","キャッシュメモリ",
              "デッドロック","フェールセーフ","ガーベジコレクション","エッジコンピューティング","フォールトトレラント",
              "スパイウェア","ラウンドロビン","コアコンピタンス","DNS","EC","UML","ポリモーフィズム","CIO",
              "フラグメンテーション","ストライピング","アローダイアグラム","メモリコンパクション","パリティ"
            };

            
            Random r = new Random();
            int randomValue = r.Next(30);

            string Q = Q_List[randomValue];
            string A = A_List[randomValue];
            var Anser = new List<string>()
            { A };
            Form1.k = A;

            int i = 0;

            while (i <= 2)
            {
                Random random = new Random();
                int rnd = random.Next(5);

                if (Anser.Contains(A_List[rnd]) == false)
                {
                    Anser.Add(A_List[rnd]);
                    i++;
                }
            }

            Anser = Anser.OrderBy(a => Guid.NewGuid()).ToList();

            this.label2.Text = Q;
            this.button1.Text = Anser[0];
            this.button2.Text = Anser[1];
            this.button3.Text = Anser[2];
            this.button4.Text = Anser[3];
            this.Anser.Text = "A." + A;
        }



        private void Anser_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;

            if (button1.Text == k)
            {
                button1.UseVisualStyleBackColor = false;
            }
            if (button2.Text == k)
            {
                button2.UseVisualStyleBackColor = false;
            }
            if (button3.Text == k)
            {
                button3.UseVisualStyleBackColor = false;
            }
            if (button4.Text == k)
            {
                button4.UseVisualStyleBackColor = false;
            }

            if (Form1.i == Form1.total)
            {
                this.finishe.Visible = true;

                if (this.button1.Text == k)
                {
                    this.Anser.Visible = true;
                    ++Form1.j;
                }

                else
                {
                    this.Anser.Visible = true;
                }
            }

            else
            {
                if (this.button1.Text == k)
                {
                    this.Anser.Visible = true;
                    this.next.Visible = true;
                    ++Form1.j;
                }

                else
                {
                    this.Anser.Visible = true;
                    this.next.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;

            if (button1.Text == k)
            {
                button1.UseVisualStyleBackColor = false;
            }
            if (button2.Text == k)
            {
                button2.UseVisualStyleBackColor = false;
            }
            if (button3.Text == k)
            {
                button3.UseVisualStyleBackColor = false;
            }
            if (button4.Text == k)
            {
                button4.UseVisualStyleBackColor = false;
            }

            if (Form1.i == Form1.total)
            {
                this.finishe.Visible = true;

                if (this.button2.Text == k)
                {
                    this.Anser.Visible = true;
                    ++Form1.j;

                }

                else
                {
                    this.Anser.Visible = true;
                }
            }

            else
            {
            if (this.button2.Text == k)
            {
                this.Anser.Visible = true;
                this.next.Visible = true;
                ++Form1.j;

            }

            else
            {
                this.Anser.Visible = true;
                this.next.Visible = true;
            }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;

            if (button1.Text == k)
            {
                button1.UseVisualStyleBackColor = false;
            }
            if (button2.Text == k)
            {
                button2.UseVisualStyleBackColor = false;
            }
            if (button3.Text == k)
            {
                button3.UseVisualStyleBackColor = false;
            }
            if (button4.Text == k)
            {
                button4.UseVisualStyleBackColor = false;
            }

            if (Form1.i == Form1.total)
            {
                this.finishe.Visible = true;

                if (this.button3.Text == k)
                {
                    this.Anser.Visible = true;
                    ++Form1.j;

                }

                else
                {
                    this.Anser.Visible = true;
                }
            }
        

            else
            {
                if (this.button3.Text == k)
                {
                    this.Anser.Visible = true;
                    this.next.Visible = true;
                    ++Form1.j;

                }

                else
                {
                    this.Anser.Visible = true;
                    this.next.Visible = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;

            if (button1.Text == k)
            {
                button1.UseVisualStyleBackColor = false;
            }
            if (button2.Text == k)
            {
                button2.UseVisualStyleBackColor = false;
            }
            if (button3.Text == k)
            {
                button3.UseVisualStyleBackColor = false;
            }
            if (button4.Text == k)
            {
                button4.UseVisualStyleBackColor = false;
            }

                if (Form1.i == Form1.total)
            {
                this.finishe.Visible = true;

                if (this.button4.Text == k)
                {
                    this.Anser.Visible = true;
                    ++Form1.j;

                }

                else
                {
                    this.Anser.Visible = true;
                }
            }

            else
            {
                if (this.button4.Text == k)
                {
                    this.Anser.Visible = true;
                    this.next.Visible = true;
                    ++Form1.j;

                }

                else
                {
                    this.Anser.Visible = true;
                    this.next.Visible = true;
                }
            }
        }

        private void finishe_Click(object sender, EventArgs e)
        {
            string x = total.ToString();
            string y = Form1.j.ToString();
            this.result.Text = ("結果は" + x + "問中" + y + "問正解！");
            this.result.Visible = true;
            this.reset.Visible = true;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;   
            this.button3.Visible = false;
            this.button4.Visible = false;
            this.finishe.Visible = false;
            this.button5.Visible = false;
            this.Anser.Visible = false;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            this.result.Visible = false;
            this.reset.Visible = false;
            this.title.Visible = true;
            this.start_button.Visible = true;
            this.label1.Visible = true;
            this.comboBox1.Visible = true;

            Form1.i = 0;
            Form1.j = 0;
            Form1.total = 0;
            Form1.k = "";

            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button3.UseVisualStyleBackColor = true;
            this.button4.UseVisualStyleBackColor = true;

            Form1.i++;
            this.label3.Text = Form1.i.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            this.finishe.Visible = false;
            this.title.Visible = true;
            this.start_button.Visible = true;
            this.label1.Visible = true;
            this.comboBox1.Visible = true;
            this.button5.Visible = false;

            Form1.i = 0;
            Form1.j = 0;
            Form1.total = 0;
            Form1.k = "";
        }
    }
}