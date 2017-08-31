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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTiposGas = new System.Windows.Forms.ComboBox();
            this.btnSalvarTreinamento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPointCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSensor
            // 
            this.chartSensor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.Interval = 60D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.MajorTickMark.Interval = 30D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorTickMark.Interval = 50D;
            chartArea1.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.Title = "Time (s)";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Interval = 1000D;
            chartArea1.AxisY.MajorGrid.Interval = 500D;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Interval = 0.2D;
            chartArea1.AxisY.Maximum = 5000D;
            chartArea1.AxisY.Title = "Sensor output (mV)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chartSensor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSensor.Legends.Add(legend1);
            this.chartSensor.Location = new System.Drawing.Point(171, 31);
            this.chartSensor.Margin = new System.Windows.Forms.Padding(2);
            this.chartSensor.Name = "chartSensor";
            this.chartSensor.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "sensor1";
            series1.Points.Add(dataPoint1);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "sensor2";
            series2.Points.Add(dataPoint2);
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Gold;
            series3.Legend = "Legend1";
            series3.Name = "sensor3";
            series3.Points.Add(dataPoint3);
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.Name = "sensor4";
            series4.Points.Add(dataPoint4);
            this.chartSensor.Series.Add(series1);
            this.chartSensor.Series.Add(series2);
            this.chartSensor.Series.Add(series3);
            this.chartSensor.Series.Add(series4);
            this.chartSensor.Size = new System.Drawing.Size(908, 384);
            this.chartSensor.TabIndex = 0;
            this.chartSensor.Text = "Sensor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPorta);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Location = new System.Drawing.Point(20, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(130, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(76, 24);
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
            this.btnConectar.Location = new System.Drawing.Point(12, 53);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(104, 25);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Ativar Sensores";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Porta serial:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 89);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(104, 21);
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
            this.menuStrip1.Size = new System.Drawing.Size(1092, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // treinamentoToolStripMenuItem
            // 
            this.treinamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCriarRede});
            this.treinamentoToolStripMenuItem.Name = "treinamentoToolStripMenuItem";
            this.treinamentoToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.treinamentoToolStripMenuItem.Text = "Rede";
            // 
            // btnCriarRede
            // 
            this.btnCriarRede.Name = "btnCriarRede";
            this.btnCriarRede.Size = new System.Drawing.Size(99, 22);
            this.btnCriarRede.Text = "Criar";
            this.btnCriarRede.Click += new System.EventHandler(this.btnCriarRede_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTiposGas);
            this.groupBox2.Controls.Add(this.btnSalvarTreinamento);
            this.groupBox2.Location = new System.Drawing.Point(20, 161);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(130, 77);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Treinamento";
            // 
            // cmbTiposGas
            // 
            this.cmbTiposGas.FormattingEnabled = true;
            this.cmbTiposGas.Location = new System.Drawing.Point(12, 16);
            this.cmbTiposGas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTiposGas.Name = "cmbTiposGas";
            this.cmbTiposGas.Size = new System.Drawing.Size(105, 21);
            this.cmbTiposGas.TabIndex = 3;
            // 
            // btnSalvarTreinamento
            // 
            this.btnSalvarTreinamento.Location = new System.Drawing.Point(12, 40);
            this.btnSalvarTreinamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvarTreinamento.Name = "btnSalvarTreinamento";
            this.btnSalvarTreinamento.Size = new System.Drawing.Size(104, 21);
            this.btnSalvarTreinamento.TabIndex = 2;
            this.btnSalvarTreinamento.Text = "Salvar";
            this.btnSalvarTreinamento.UseVisualStyleBackColor = true;
            this.btnSalvarTreinamento.Click += new System.EventHandler(this.btnSalvarTreinamento_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 397);
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
            this.lblPointCount.Location = new System.Drawing.Point(116, 397);
            this.lblPointCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPointCount.Name = "lblPointCount";
            this.lblPointCount.Size = new System.Drawing.Size(17, 17);
            this.lblPointCount.TabIndex = 10;
            this.lblPointCount.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 430);
            this.Controls.Add(this.lblPointCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartSensor);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
    }
}

