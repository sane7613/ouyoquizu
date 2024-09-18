using System.Windows.Forms;

namespace ouyoquizu
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorLight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColorDark = new System.Windows.Forms.ToolStripMenuItem();
            this.title = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Anser = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Label();
            this.finishe = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游明朝 Demibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(170, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "問題数を設定してください";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.Red;
            this.start_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.start_button.ForeColor = System.Drawing.SystemColors.Window;
            this.start_button.Location = new System.Drawing.Point(319, 350);
            this.start_button.Margin = new System.Windows.Forms.Padding(0);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(161, 52);
            this.start_button.TabIndex = 2;
            this.start_button.Text = "スタート！";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            this.start_button.MouseLeave += new System.EventHandler(this.start_button_MouseLeave);
            this.start_button.MouseHover += new System.EventHandler(this.start_button_MouseHover);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(500, 266);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 20);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Silver;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMenu,
            this.menuSet});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
            this.menu.TabIndex = 4;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // menuMenu
            // 
            this.menuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClose});
            this.menuMenu.Name = "menuMenu";
            this.menuMenu.Size = new System.Drawing.Size(71, 20);
            this.menuMenu.Text = "メニュー(&M)";
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuClose.Size = new System.Drawing.Size(138, 22);
            this.menuClose.Text = "終了";
            this.menuClose.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // menuSet
            // 
            this.menuSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuColor});
            this.menuSet.Name = "menuSet";
            this.menuSet.Size = new System.Drawing.Size(57, 20);
            this.menuSet.Text = "設定(&S)";
            // 
            // menuColor
            // 
            this.menuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuColorLight,
            this.menuColorDark});
            this.menuColor.Name = "menuColor";
            this.menuColor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuColor.Size = new System.Drawing.Size(138, 22);
            this.menuColor.Text = "背景";
            // 
            // menuColorLight
            // 
            this.menuColorLight.Checked = true;
            this.menuColorLight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuColorLight.Name = "menuColorLight";
            this.menuColorLight.Size = new System.Drawing.Size(101, 22);
            this.menuColorLight.Text = "Light";
            this.menuColorLight.Click += new System.EventHandler(this.MenuColorLight_Click);
            // 
            // menuColorDark
            // 
            this.menuColorDark.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuColorDark.Name = "menuColorDark";
            this.menuColorDark.Size = new System.Drawing.Size(101, 22);
            this.menuColorDark.Text = "Dark";
            this.menuColorDark.Click += new System.EventHandler(this.MenuColorDark_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("ＭＳ 明朝", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.title.Location = new System.Drawing.Point(132, 126);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(510, 48);
            this.title.TabIndex = 5;
            this.title.Text = "応用情報技術者クイズ";
            this.title.Click += new System.EventHandler(this.tilte_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(301, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 52);
            this.button4.TabIndex = 10;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(301, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(55, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.CausesValidation = false;
            this.button1.Location = new System.Drawing.Point(55, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("游明朝", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(66, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(669, 142);
            this.label2.TabIndex = 11;
            this.label2.Text = "　主記憶をいくつかの区画に分割し、連続したメモリへのアクセスを高速化することを表す単語。";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("游明朝", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(145, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "1";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("游明朝 Demibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(66, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "問題.";
            this.label4.Visible = false;
            // 
            // Anser
            // 
            this.Anser.AutoSize = true;
            this.Anser.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Anser.ForeColor = System.Drawing.Color.Red;
            this.Anser.Location = new System.Drawing.Point(532, 350);
            this.Anser.Name = "Anser";
            this.Anser.Size = new System.Drawing.Size(78, 27);
            this.Anser.TabIndex = 14;
            this.Anser.Text = "Anser";
            this.Anser.Visible = false;
            this.Anser.Click += new System.EventHandler(this.Anser_Click);
            // 
            // next
            // 
            this.next.AutoSize = true;
            this.next.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.next.Location = new System.Drawing.Point(534, 400);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(97, 16);
            this.next.TabIndex = 15;
            this.next.Text = "次の問題へ→";
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.label5_Click);
            // 
            // finishe
            // 
            this.finishe.AutoSize = true;
            this.finishe.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.finishe.Location = new System.Drawing.Point(531, 400);
            this.finishe.Name = "finishe";
            this.finishe.Size = new System.Drawing.Size(100, 16);
            this.finishe.TabIndex = 16;
            this.finishe.Text = "結果確認へ→";
            this.finishe.Visible = false;
            this.finishe.Click += new System.EventHandler(this.finishe_Click);
            // 
            // result
            // 
            this.result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("ＭＳ 明朝", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.result.Location = new System.Drawing.Point(154, 209);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(95, 37);
            this.result.TabIndex = 17;
            this.result.Text = "結果";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.result.Visible = false;
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reset.Location = new System.Drawing.Point(534, 400);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(115, 16);
            this.reset.TabIndex = 18;
            this.reset.Text = "スタート画面へ→";
            this.reset.Visible = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(678, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "終了";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.result);
            this.Controls.Add(this.finishe);
            this.Controls.Add(this.next);
            this.Controls.Add(this.Anser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            this.Text = "応用情報技術者クイズ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void MenuClose_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("終了してもよろしいですか？", "通知", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void MenuColorDark_Click(object sender, System.EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkGray;
            this.menuColorDark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuColorLight.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.start_button.BackColor = System.Drawing.Color.DarkRed;
        }

        private void MenuColorLight_Click(object sender, System.EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.Info;
            this.menuColorLight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuColorLight.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.start_button.BackColor = System.Drawing.Color.Red;
        }

    

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuMenu;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.ToolStripMenuItem menuSet;
        private System.Windows.Forms.ToolStripMenuItem menuColor;
        private ToolStripMenuItem menuColorLight;
        private ToolStripMenuItem menuColorDark;
        private Label title;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Anser;
        private Label next;
        private Label finishe;
        private Label result;
        private Label reset;
        private Button button5;
    }
}

