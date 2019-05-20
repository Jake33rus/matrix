namespace Matrix
{
    partial class MyForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.матрицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.надЭлементамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.минимальныйЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максимальныйЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.надМатрицейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.определительМатрицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.транспонированиеМатрицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обратнаяМатрицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.надМатрицамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.суммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.умножениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.теоретическийМатериалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolButton = new System.Windows.Forms.ToolStripButton();
            this.printToolButton = new System.Windows.Forms.ToolStripButton();
            this.minToolButton = new System.Windows.Forms.ToolStripButton();
            this.maxToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.матрицаToolStripMenuItem,
            this.операцииToolStripMenuItem,
            this.расчетToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.теоретическийМатериалToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // матрицаToolStripMenuItem
            // 
            this.матрицаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.матрицаToolStripMenuItem.Name = "матрицаToolStripMenuItem";
            this.матрицаToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.матрицаToolStripMenuItem.Text = "Матрица";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.надЭлементамиToolStripMenuItem,
            this.надМатрицейToolStripMenuItem,
            this.надМатрицамиToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // надЭлементамиToolStripMenuItem
            // 
            this.надЭлементамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.минимальныйЭлементToolStripMenuItem,
            this.максимальныйЭлементToolStripMenuItem});
            this.надЭлементамиToolStripMenuItem.Name = "надЭлементамиToolStripMenuItem";
            this.надЭлементамиToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.надЭлементамиToolStripMenuItem.Text = "Над элементами";
            // 
            // минимальныйЭлементToolStripMenuItem
            // 
            this.минимальныйЭлементToolStripMenuItem.Name = "минимальныйЭлементToolStripMenuItem";
            this.минимальныйЭлементToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.минимальныйЭлементToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.минимальныйЭлементToolStripMenuItem.Text = "Минимальный элемент";
            this.минимальныйЭлементToolStripMenuItem.Click += new System.EventHandler(this.минимальныйЭлементToolStripMenuItem_Click);
            // 
            // максимальныйЭлементToolStripMenuItem
            // 
            this.максимальныйЭлементToolStripMenuItem.Name = "максимальныйЭлементToolStripMenuItem";
            this.максимальныйЭлементToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.максимальныйЭлементToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.максимальныйЭлементToolStripMenuItem.Text = "Максимальный элемент";
            this.максимальныйЭлементToolStripMenuItem.Click += new System.EventHandler(this.максимальныйЭлементToolStripMenuItem_Click);
            // 
            // надМатрицейToolStripMenuItem
            // 
            this.надМатрицейToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.определительМатрицыToolStripMenuItem,
            this.транспонированиеМатрицыToolStripMenuItem,
            this.обратнаяМатрицаToolStripMenuItem});
            this.надМатрицейToolStripMenuItem.Name = "надМатрицейToolStripMenuItem";
            this.надМатрицейToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.надМатрицейToolStripMenuItem.Text = "Над матрицей";
            // 
            // определительМатрицыToolStripMenuItem
            // 
            this.определительМатрицыToolStripMenuItem.Name = "определительМатрицыToolStripMenuItem";
            this.определительМатрицыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.определительМатрицыToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.определительМатрицыToolStripMenuItem.Text = "Определитель матрицы";
            this.определительМатрицыToolStripMenuItem.Click += new System.EventHandler(this.определительМатрицыToolStripMenuItem_Click);
            // 
            // транспонированиеМатрицыToolStripMenuItem
            // 
            this.транспонированиеМатрицыToolStripMenuItem.Name = "транспонированиеМатрицыToolStripMenuItem";
            this.транспонированиеМатрицыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.транспонированиеМатрицыToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.транспонированиеМатрицыToolStripMenuItem.Text = "Транспонирование матрицы";
            this.транспонированиеМатрицыToolStripMenuItem.Click += new System.EventHandler(this.транспонированиеМатрицыToolStripMenuItem_Click);
            // 
            // обратнаяМатрицаToolStripMenuItem
            // 
            this.обратнаяМатрицаToolStripMenuItem.Name = "обратнаяМатрицаToolStripMenuItem";
            this.обратнаяМатрицаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.обратнаяМатрицаToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.обратнаяМатрицаToolStripMenuItem.Text = "Обратная матрица";
            this.обратнаяМатрицаToolStripMenuItem.Click += new System.EventHandler(this.обратнаяМатрицаToolStripMenuItem_Click);
            // 
            // надМатрицамиToolStripMenuItem
            // 
            this.надМатрицамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.суммаToolStripMenuItem,
            this.умножениеToolStripMenuItem});
            this.надМатрицамиToolStripMenuItem.Name = "надМатрицамиToolStripMenuItem";
            this.надМатрицамиToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.надМатрицамиToolStripMenuItem.Text = "Над матрицами";
            // 
            // суммаToolStripMenuItem
            // 
            this.суммаToolStripMenuItem.Name = "суммаToolStripMenuItem";
            this.суммаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.суммаToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.суммаToolStripMenuItem.Text = "Сумма";
            this.суммаToolStripMenuItem.Click += new System.EventHandler(this.суммаToolStripMenuItem_Click);
            // 
            // умножениеToolStripMenuItem
            // 
            this.умножениеToolStripMenuItem.Name = "умножениеToolStripMenuItem";
            this.умножениеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.умножениеToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.умножениеToolStripMenuItem.Text = "Умножение";
            this.умножениеToolStripMenuItem.Click += new System.EventHandler(this.умножениеToolStripMenuItem_Click);
            // 
            // расчетToolStripMenuItem
            // 
            this.расчетToolStripMenuItem.Name = "расчетToolStripMenuItem";
            this.расчетToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.расчетToolStripMenuItem.Text = "Расчет";
            this.расчетToolStripMenuItem.Click += new System.EventHandler(this.расчетToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.справкаToolStripMenuItem1});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.справкаToolStripMenuItem1.Text = "Справка";
            // 
            // теоретическийМатериалToolStripMenuItem
            // 
            this.теоретическийМатериалToolStripMenuItem.Name = "теоретическийМатериалToolStripMenuItem";
            this.теоретическийМатериалToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.теоретическийМатериалToolStripMenuItem.Text = "Теоретический материал";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenButton,
            this.saveToolButton,
            this.printToolButton,
            this.minToolButton,
            this.maxToolButton,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripButton12});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 67);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenButton
            // 
            this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenButton.Image")));
            this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(64, 64);
            this.OpenButton.Text = "Открыть";
            this.OpenButton.ToolTipText = "Открыть";
            // 
            // saveToolButton
            // 
            this.saveToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolButton.Image")));
            this.saveToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolButton.Name = "saveToolButton";
            this.saveToolButton.Size = new System.Drawing.Size(64, 64);
            this.saveToolButton.Text = "Сохранить";
            // 
            // printToolButton
            // 
            this.printToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolButton.Image")));
            this.printToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolButton.Name = "printToolButton";
            this.printToolButton.Size = new System.Drawing.Size(64, 64);
            this.printToolButton.Tag = "Печать";
            this.printToolButton.Text = "Печать";
            // 
            // minToolButton
            // 
            this.minToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.minToolButton.Image = ((System.Drawing.Image)(resources.GetObject("minToolButton.Image")));
            this.minToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.minToolButton.Name = "minToolButton";
            this.minToolButton.Size = new System.Drawing.Size(64, 64);
            this.minToolButton.Tag = "Минимальный элемент матрицы А";
            this.minToolButton.Text = "Минимальный элемент матрицы А";
            this.minToolButton.Click += new System.EventHandler(this.минимальныйЭлементToolStripMenuItem_Click);
            // 
            // maxToolButton
            // 
            this.maxToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.maxToolButton.Image = ((System.Drawing.Image)(resources.GetObject("maxToolButton.Image")));
            this.maxToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.maxToolButton.Name = "maxToolButton";
            this.maxToolButton.Size = new System.Drawing.Size(64, 64);
            this.maxToolButton.Text = "Максимальный элемент матрицы А";
            this.maxToolButton.ToolTipText = "Максимальный элемент матрицы А";
            this.maxToolButton.Click += new System.EventHandler(this.максимальныйЭлементToolStripMenuItem_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.определительМатрицыToolStripMenuItem_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.транспонированиеМатрицыToolStripMenuItem_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.Click += new System.EventHandler(this.обратнаяМатрицаToolStripMenuItem_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton9.Text = "toolStripButton9";
            this.toolStripButton9.Click += new System.EventHandler(this.суммаToolStripMenuItem_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton10.Text = "toolStripButton10";
            this.toolStripButton10.Click += new System.EventHandler(this.умножениеToolStripMenuItem_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton11.Text = "toolStripButton11";
            this.toolStripButton11.Click += new System.EventHandler(this.расчетToolStripMenuItem_Click);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(64, 64);
            this.toolStripButton12.Text = "toolStripButton12";
            this.toolStripButton12.Click += new System.EventHandler(this.toolStripButton12_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(54, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(210, 210);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(337, 128);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(210, 210);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.ColumnHeadersVisible = false;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(592, 128);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(210, 210);
            this.dataGridView3.TabIndex = 7;
            this.dataGridView3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(818, 392);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyForm";
            this.Text = "ЧВМ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem матрицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem надЭлементамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem минимальныйЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem максимальныйЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem надМатрицейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem определительМатрицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem транспонированиеМатрицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обратнаяМатрицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem надМатрицамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem суммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem умножениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem теоретическийМатериалToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenButton;
        private System.Windows.Forms.ToolStripButton saveToolButton;
        private System.Windows.Forms.ToolStripButton printToolButton;
        private System.Windows.Forms.ToolStripButton minToolButton;
        private System.Windows.Forms.ToolStripButton maxToolButton;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label4;
    }
}

