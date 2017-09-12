namespace OdorDetector
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.chartSensor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPorta = new System.Windows.Forms.NumericUpDown();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.updateChart = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.treinamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCriarRede = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCarregarRede = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalvarRede = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPontoSalvos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberMax = new System.Windows.Forms.NumericUpDown();
            this.numberMin = new System.Windows.Forms.NumericUpDown();
            this.cmbTiposGas = new System.Windows.Forms.ComboBox();
            this.btnSalvarTreinamento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPointCount = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPeaktoPeak = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSettlingTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMin)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSensor
            // 
            this.chartSensor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.Interval = 1D;
            chartArea2.AxisX.MajorTickMark.Interval = 30D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.MinorTickMark.Interval = 50D;
            chartArea2.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.Title = "Time (s)";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Interval = 1000D;
            chartArea2.AxisY.MajorGrid.Interval = 500D;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Interval = 0.2D;
            chartArea2.AxisY.Maximum = 5000D;
            chartArea2.AxisY.Title = "Sensor output (mV)";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.chartSensor.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSensor.Legends.Add(legend2);
            this.chartSensor.Location = new System.Drawing.Point(11, 34);
            this.chartSensor.Margin = new System.Windows.Forms.Padding(2);
            this.chartSensor.Name = "chartSensor";
            this.chartSensor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Amonia, Benzeno e Alcool";
            series5.Points.Add(dataPoint5);
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.Name = "Alcool";
            series6.Points.Add(dataPoint6);
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.Gold;
            series7.Legend = "Legend1";
            series7.Name = "Hidrogenio";
            series7.Points.Add(dataPoint7);
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series8.Legend = "Legend1";
            series8.Name = "Gas Carbonico";
            series8.Points.Add(dataPoint8);
            this.chartSensor.Series.Add(series5);
            this.chartSensor.Series.Add(series6);
            this.chartSensor.Series.Add(series7);
            this.chartSensor.Series.Add(series8);
            this.chartSensor.Size = new System.Drawing.Size(935, 604);
            this.chartSensor.TabIndex = 0;
            this.chartSensor.Text = "Sensor";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPorta);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Location = new System.Drawing.Point(11, 666);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(159, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(91, 24);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(39, 20);
            this.txtPorta.TabIndex = 6;
            this.txtPorta.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(26, 59);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(104, 29);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Ativar Sensores";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Porta serial:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(27, 108);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(104, 27);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Identificar Aroma";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // updateChart
            // 
            this.updateChart.Interval = 500;
            this.updateChart.Tick += new System.EventHandler(this.updateChart_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treinamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // treinamentoToolStripMenuItem
            // 
            this.treinamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCriarRede,
            this.btnCarregarRede,
            this.btnSalvarRede});
            this.treinamentoToolStripMenuItem.Name = "treinamentoToolStripMenuItem";
            this.treinamentoToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.treinamentoToolStripMenuItem.Text = "Rede";
            // 
            // btnCriarRede
            // 
            this.btnCriarRede.Name = "btnCriarRede";
            this.btnCriarRede.Size = new System.Drawing.Size(119, 22);
            this.btnCriarRede.Text = "Criar";
            this.btnCriarRede.Click += new System.EventHandler(this.btnCriarRede_Click);
            // 
            // btnCarregarRede
            // 
            this.btnCarregarRede.Name = "btnCarregarRede";
            this.btnCarregarRede.Size = new System.Drawing.Size(119, 22);
            this.btnCarregarRede.Text = "Carregar";
            this.btnCarregarRede.Click += new System.EventHandler(this.btnCarregarRede_Click_1);
            // 
            // btnSalvarRede
            // 
            this.btnSalvarRede.Name = "btnSalvarRede";
            this.btnSalvarRede.Size = new System.Drawing.Size(119, 22);
            this.btnSalvarRede.Text = "Salvar";
            this.btnSalvarRede.Click += new System.EventHandler(this.btnSalvarRede_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblPontoSalvos);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numberMax);
            this.groupBox2.Controls.Add(this.numberMin);
            this.groupBox2.Controls.Add(this.cmbTiposGas);
            this.groupBox2.Controls.Add(this.btnSalvarTreinamento);
            this.groupBox2.Location = new System.Drawing.Point(183, 666);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(293, 157);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Treinamento";
            // 
            // lblPontoSalvos
            // 
            this.lblPontoSalvos.AutoSize = true;
            this.lblPontoSalvos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontoSalvos.Location = new System.Drawing.Point(237, 17);
            this.lblPontoSalvos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPontoSalvos.Name = "lblPontoSalvos";
            this.lblPontoSalvos.Size = new System.Drawing.Size(26, 17);
            this.lblPontoSalvos.TabIndex = 14;
            this.lblPontoSalvos.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pontos salvos: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Até: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "De: ";
            // 
            // numberMax
            // 
            this.numberMax.Location = new System.Drawing.Point(30, 116);
            this.numberMax.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numberMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberMax.Name = "numberMax";
            this.numberMax.Size = new System.Drawing.Size(102, 20);
            this.numberMax.TabIndex = 5;
            this.numberMax.Value = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.numberMax.ValueChanged += new System.EventHandler(this.numberMax_ValueChanged);
            // 
            // numberMin
            // 
            this.numberMin.Location = new System.Drawing.Point(29, 71);
            this.numberMin.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numberMin.Name = "numberMin";
            this.numberMin.Size = new System.Drawing.Size(104, 20);
            this.numberMin.TabIndex = 4;
            this.numberMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberMin.ValueChanged += new System.EventHandler(this.numberMin_ValueChanged);
            // 
            // cmbTiposGas
            // 
            this.cmbTiposGas.FormattingEnabled = true;
            this.cmbTiposGas.Location = new System.Drawing.Point(28, 25);
            this.cmbTiposGas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTiposGas.Name = "cmbTiposGas";
            this.cmbTiposGas.Size = new System.Drawing.Size(105, 21);
            this.cmbTiposGas.TabIndex = 3;
            // 
            // btnSalvarTreinamento
            // 
            this.btnSalvarTreinamento.Location = new System.Drawing.Point(159, 92);
            this.btnSalvarTreinamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarTreinamento.Name = "btnSalvarTreinamento";
            this.btnSalvarTreinamento.Size = new System.Drawing.Size(104, 44);
            this.btnSalvarTreinamento.TabIndex = 2;
            this.btnSalvarTreinamento.Text = "Salvar";
            this.btnSalvarTreinamento.UseVisualStyleBackColor = true;
            this.btnSalvarTreinamento.Click += new System.EventHandler(this.btnSalvarTreinamento_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pontos capturados: ";
            // 
            // lblPointCount
            // 
            this.lblPointCount.AutoSize = true;
            this.lblPointCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointCount.Location = new System.Drawing.Point(121, 23);
            this.lblPointCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPointCount.Name = "lblPointCount";
            this.lblPointCount.Size = new System.Drawing.Size(17, 17);
            this.lblPointCount.TabIndex = 10;
            this.lblPointCount.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblPeaktoPeak);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblMax);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblSettlingTime);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblPointCount);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(492, 666);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(454, 157);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Características";
            // 
            // lblPeaktoPeak
            // 
            this.lblPeaktoPeak.AutoSize = true;
            this.lblPeaktoPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeaktoPeak.Location = new System.Drawing.Point(255, 97);
            this.lblPeaktoPeak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeaktoPeak.Name = "lblPeaktoPeak";
            this.lblPeaktoPeak.Size = new System.Drawing.Size(17, 17);
            this.lblPeaktoPeak.TabIndex = 16;
            this.lblPeaktoPeak.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(185, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Pico a pico";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(254, 24);
            this.lblMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(17, 17);
            this.lblMax.TabIndex = 14;
            this.lblMax.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Max pico:";
            // 
            // lblSettlingTime
            // 
            this.lblSettlingTime.AutoSize = true;
            this.lblSettlingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettlingTime.Location = new System.Drawing.Point(99, 92);
            this.lblSettlingTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSettlingTime.Name = "lblSettlingTime";
            this.lblSettlingTime.Size = new System.Drawing.Size(17, 17);
            this.lblSettlingTime.TabIndex = 12;
            this.lblSettlingTime.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tempo de \r\nacomodação:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(965, 834);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartSensor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odor Detection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMin)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer updateChart;
        private System.Windows.Forms.NumericUpDown txtPorta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem treinamentoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTiposGas;
        private System.Windows.Forms.Button btnSalvarTreinamento;
        private System.Windows.Forms.ToolStripMenuItem btnCriarRede;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPointCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberMax;
        private System.Windows.Forms.NumericUpDown numberMin;
        private System.Windows.Forms.Label lblPontoSalvos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem btnCarregarRede;
        private System.Windows.Forms.ToolStripMenuItem btnSalvarRede;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPeaktoPeak;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSettlingTime;
        private System.Windows.Forms.Label label6;
    }
}

