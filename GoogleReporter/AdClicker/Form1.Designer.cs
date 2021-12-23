
namespace AdClicker
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.keyword = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetDivider1 = new MetroSet_UI.Controls.MetroSetDivider();
            this.metroSetDivider2 = new MetroSet_UI.Controls.MetroSetDivider();
            this.metroSetDivider4 = new MetroSet_UI.Controls.MetroSetDivider();
            this.startButton = new MetroSet_UI.Controls.MetroSetDefaultButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clickCount = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.doWork = new System.Windows.Forms.Timer(this.components);
            this.changeUserAgent = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.useragent = new System.Windows.Forms.Label();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.changeVersionTimer = new MetroSet_UI.Controls.MetroSetNumeric();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.onlyDesktop = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.onlyMobile = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.loading = new System.Windows.Forms.PictureBox();
            this.keywordList = new MetroSet_UI.Controls.MetroSetListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.metroSetTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(349, 8);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLight";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-4, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 15);
            this.panel1.TabIndex = 1;
            // 
            // keyword
            // 
            this.keyword.AutoCompleteCustomSource = null;
            this.keyword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.keyword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.keyword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.keyword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.keyword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.keyword.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.keyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keyword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.keyword.Image = null;
            this.keyword.IsDerivedStyle = true;
            this.keyword.Lines = null;
            this.keyword.Location = new System.Drawing.Point(11, 114);
            this.keyword.MaxLength = 32767;
            this.keyword.Multiline = false;
            this.keyword.Name = "keyword";
            this.keyword.ReadOnly = false;
            this.keyword.Size = new System.Drawing.Size(333, 29);
            this.keyword.Style = MetroSet_UI.Enums.Style.Light;
            this.keyword.StyleManager = null;
            this.keyword.TabIndex = 3;
            this.keyword.Text = "Kelime";
            this.keyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.keyword.ThemeAuthor = "Narwin";
            this.keyword.ThemeName = "MetroLight";
            this.keyword.UseSystemPasswordChar = false;
            this.keyword.WatermarkText = "";
            this.keyword.Leave += new System.EventHandler(this.metroSetTextBox1_Leave);
            this.keyword.Enter += new System.EventHandler(this.metroSetTextBox1_Enter);
            // 
            // metroSetDivider1
            // 
            this.metroSetDivider1.IsDerivedStyle = true;
            this.metroSetDivider1.Location = new System.Drawing.Point(-5, 160);
            this.metroSetDivider1.Name = "metroSetDivider1";
            this.metroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider1.Size = new System.Drawing.Size(463, 4);
            this.metroSetDivider1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDivider1.StyleManager = null;
            this.metroSetDivider1.TabIndex = 12;
            this.metroSetDivider1.Text = "metroSetDivider1";
            this.metroSetDivider1.ThemeAuthor = "Narwin";
            this.metroSetDivider1.ThemeName = "MetroLight";
            this.metroSetDivider1.Thickness = 1;
            // 
            // metroSetDivider2
            // 
            this.metroSetDivider2.IsDerivedStyle = true;
            this.metroSetDivider2.Location = new System.Drawing.Point(-8, 458);
            this.metroSetDivider2.Name = "metroSetDivider2";
            this.metroSetDivider2.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider2.Size = new System.Drawing.Size(463, 4);
            this.metroSetDivider2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDivider2.StyleManager = null;
            this.metroSetDivider2.TabIndex = 13;
            this.metroSetDivider2.Text = "metroSetDivider2";
            this.metroSetDivider2.ThemeAuthor = "Narwin";
            this.metroSetDivider2.ThemeName = "MetroLight";
            this.metroSetDivider2.Thickness = 1;
            // 
            // metroSetDivider4
            // 
            this.metroSetDivider4.IsDerivedStyle = true;
            this.metroSetDivider4.Location = new System.Drawing.Point(-4, 313);
            this.metroSetDivider4.Name = "metroSetDivider4";
            this.metroSetDivider4.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider4.Size = new System.Drawing.Size(463, 4);
            this.metroSetDivider4.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetDivider4.StyleManager = null;
            this.metroSetDivider4.TabIndex = 15;
            this.metroSetDivider4.Text = "metroSetDivider4";
            this.metroSetDivider4.ThemeAuthor = "Narwin";
            this.metroSetDivider4.ThemeName = "MetroLight";
            this.metroSetDivider4.Thickness = 1;
            // 
            // startButton
            // 
            this.startButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.startButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.startButton.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.startButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.startButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.startButton.HoverTextColor = System.Drawing.Color.White;
            this.startButton.IsDerivedStyle = true;
            this.startButton.Location = new System.Drawing.Point(338, 480);
            this.startButton.Name = "startButton";
            this.startButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.startButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.startButton.NormalTextColor = System.Drawing.Color.Black;
            this.startButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.startButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.startButton.PressTextColor = System.Drawing.Color.White;
            this.startButton.Size = new System.Drawing.Size(102, 44);
            this.startButton.Style = MetroSet_UI.Enums.Style.Light;
            this.startButton.StyleManager = null;
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Başlat";
            this.startButton.ThemeAuthor = "Narwin";
            this.startButton.ThemeName = "MetroLight";
            this.startButton.Click += new System.EventHandler(this.metroSetDefaultButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(11, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Aranılacak Kelime Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Google Şikayet Edici";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.label6.Location = new System.Drawing.Point(9, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Durum: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.label8.Location = new System.Drawing.Point(9, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "Rapor Edilme Sayısı:";
            // 
            // clickCount
            // 
            this.clickCount.AutoSize = true;
            this.clickCount.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.clickCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.clickCount.Location = new System.Drawing.Point(156, 506);
            this.clickCount.Name = "clickCount";
            this.clickCount.Size = new System.Drawing.Size(17, 19);
            this.clickCount.TabIndex = 29;
            this.clickCount.Text = "0";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.status.Location = new System.Drawing.Point(156, 477);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(60, 19);
            this.status.TabIndex = 30;
            this.status.Text = "Bekliyor";
            // 
            // doWork
            // 
            this.doWork.Interval = 10000;
            this.doWork.Tick += new System.EventHandler(this.doWork_Tick);
            // 
            // changeUserAgent
            // 
            this.changeUserAgent.Interval = 10000;
            this.changeUserAgent.Tick += new System.EventHandler(this.changeUserAgent_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.label7.Location = new System.Drawing.Point(10, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Geçerli User-agent:";
            // 
            // useragent
            // 
            this.useragent.AutoSize = true;
            this.useragent.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.useragent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.useragent.Location = new System.Drawing.Point(156, 532);
            this.useragent.Name = "useragent";
            this.useragent.Size = new System.Drawing.Size(14, 19);
            this.useragent.TabIndex = 32;
            this.useragent.Text = "-";
            // 
            // worker
            // 
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Controls.Add(this.tabPage1);
            this.metroSetTabControl1.Controls.Add(this.tabPage2);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(12, 323);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 1;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Size = new System.Drawing.Size(426, 128);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 0;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroLight";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.changeVersionTimer);
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(418, 82);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Otomatik Sürüm Değiştirme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(402, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Şu kadar saniye sonra sürüm değiştir (Masaüstü <-> Mobil)";
            // 
            // changeVersionTimer
            // 
            this.changeVersionTimer.BackColor = System.Drawing.Color.Transparent;
            this.changeVersionTimer.BackgroundColor = System.Drawing.Color.Transparent;
            this.changeVersionTimer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.changeVersionTimer.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.changeVersionTimer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.changeVersionTimer.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.changeVersionTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.changeVersionTimer.IsDerivedStyle = true;
            this.changeVersionTimer.Location = new System.Drawing.Point(3, 44);
            this.changeVersionTimer.Maximum = 1000000;
            this.changeVersionTimer.Minimum = 0;
            this.changeVersionTimer.Name = "changeVersionTimer";
            this.changeVersionTimer.Size = new System.Drawing.Size(415, 26);
            this.changeVersionTimer.Style = MetroSet_UI.Enums.Style.Light;
            this.changeVersionTimer.StyleManager = null;
            this.changeVersionTimer.SymbolsColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.changeVersionTimer.TabIndex = 26;
            this.changeVersionTimer.Text = "metroSetNumeric1";
            this.changeVersionTimer.ThemeAuthor = "Narwin";
            this.changeVersionTimer.ThemeName = "MetroLight";
            this.changeVersionTimer.Value = 60;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.onlyDesktop);
            this.tabPage2.Controls.Add(this.onlyMobile);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(418, 82);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tek Sürüm Kullanma";
            // 
            // onlyDesktop
            // 
            this.onlyDesktop.BackColor = System.Drawing.Color.Transparent;
            this.onlyDesktop.BackgroundColor = System.Drawing.Color.White;
            this.onlyDesktop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.onlyDesktop.Checked = false;
            this.onlyDesktop.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.onlyDesktop.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.onlyDesktop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onlyDesktop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.onlyDesktop.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.onlyDesktop.IsDerivedStyle = true;
            this.onlyDesktop.Location = new System.Drawing.Point(17, 48);
            this.onlyDesktop.Name = "onlyDesktop";
            this.onlyDesktop.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.onlyDesktop.Size = new System.Drawing.Size(235, 16);
            this.onlyDesktop.Style = MetroSet_UI.Enums.Style.Light;
            this.onlyDesktop.StyleManager = null;
            this.onlyDesktop.TabIndex = 1;
            this.onlyDesktop.Text = "Sadece masaüstü sürüm kullan";
            this.onlyDesktop.ThemeAuthor = "Narwin";
            this.onlyDesktop.ThemeName = "MetroLight";
            this.onlyDesktop.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.onlyDesktop_CheckedChanged);
            // 
            // onlyMobile
            // 
            this.onlyMobile.BackColor = System.Drawing.Color.Transparent;
            this.onlyMobile.BackgroundColor = System.Drawing.Color.White;
            this.onlyMobile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.onlyMobile.Checked = false;
            this.onlyMobile.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.onlyMobile.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.onlyMobile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onlyMobile.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.onlyMobile.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.onlyMobile.IsDerivedStyle = true;
            this.onlyMobile.Location = new System.Drawing.Point(17, 17);
            this.onlyMobile.Name = "onlyMobile";
            this.onlyMobile.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.onlyMobile.Size = new System.Drawing.Size(190, 16);
            this.onlyMobile.Style = MetroSet_UI.Enums.Style.Light;
            this.onlyMobile.StyleManager = null;
            this.onlyMobile.TabIndex = 0;
            this.onlyMobile.Text = "Sadece mobil sürüm kullan";
            this.onlyMobile.ThemeAuthor = "Narwin";
            this.onlyMobile.ThemeName = "MetroLight";
            this.onlyMobile.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.onlyMobile_CheckedChanged);
            // 
            // loading
            // 
            this.loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loading.Image = ((System.Drawing.Image)(resources.GetObject("loading.Image")));
            this.loading.Location = new System.Drawing.Point(222, 474);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(25, 26);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loading.TabIndex = 61;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // keywordList
            // 
            this.keywordList.BackColor = System.Drawing.Color.White;
            this.keywordList.BorderColor = System.Drawing.Color.LightGray;
            this.keywordList.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.keywordList.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.keywordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keywordList.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.keywordList.HoveredItemColor = System.Drawing.Color.DimGray;
            this.keywordList.IsDerivedStyle = true;
            this.keywordList.ItemHeight = 30;
            this.keywordList.Location = new System.Drawing.Point(13, 186);
            this.keywordList.MultiSelect = false;
            this.keywordList.Name = "keywordList";
            this.keywordList.SelectedIndex = -1;
            this.keywordList.SelectedItem = null;
            this.keywordList.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.keywordList.SelectedItemColor = System.Drawing.Color.White;
            this.keywordList.SelectedText = null;
            this.keywordList.SelectedValue = null;
            this.keywordList.ShowBorder = false;
            this.keywordList.ShowScrollBar = false;
            this.keywordList.Size = new System.Drawing.Size(427, 122);
            this.keywordList.Style = MetroSet_UI.Enums.Style.Light;
            this.keywordList.StyleManager = null;
            this.keywordList.TabIndex = 62;
            this.keywordList.ThemeAuthor = "Narwin";
            this.keywordList.ThemeName = "MetroLite";
            this.keywordList.DragDrop += new System.Windows.Forms.DragEventHandler(this.keywordList_DragDrop);
            this.keywordList.DragEnter += new System.Windows.Forms.DragEventHandler(this.keywordList_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 19);
            this.label3.TabIndex = 63;
            this.label3.Text = "Aranılacak Kelime Listesi";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addButton.Location = new System.Drawing.Point(348, 114);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(92, 29);
            this.addButton.TabIndex = 65;
            this.addButton.Text = "Ekle";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(72)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(455, 562);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.keywordList);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.metroSetTabControl1);
            this.Controls.Add(this.useragent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.status);
            this.Controls.Add(this.clickCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.metroSetDivider4);
            this.Controls.Add(this.metroSetDivider2);
            this.Controls.Add(this.metroSetDivider1);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroSetControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.metroSetTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.Panel panel1;
        private MetroSet_UI.Controls.MetroSetTextBox keyword;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider1;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider2;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider4;
        private MetroSet_UI.Controls.MetroSetDefaultButton startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label clickCount;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Timer doWork;
        private System.Windows.Forms.Timer changeUserAgent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label useragent;
        private System.ComponentModel.BackgroundWorker worker;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private MetroSet_UI.Controls.MetroSetNumeric changeVersionTimer;
        private MetroSet_UI.Controls.MetroSetCheckBox onlyDesktop;
        private MetroSet_UI.Controls.MetroSetCheckBox onlyMobile;
        private System.Windows.Forms.PictureBox loading;
        private MetroSet_UI.Controls.MetroSetListBox keywordList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
    }
}

