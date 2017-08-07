namespace OdorDetector
{
    partial class Form1
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPorta = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSensor1 = new System.Windows.Forms.Label();
            this.updateChart = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSensor5 = new System.Windows.Forms.Label();
            this.lblSensor4 = new System.Windows.Forms.Label();
            this.lblSensor3 = new System.Windows.Forms.Label();
            this.lblSensor2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.treinamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCarregarRede = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCriarRede = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalvarNovaRede = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTiposGas = new System.Windows.Forms.ComboBox();
            this.btnSalvarTreinamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSensor
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.Interval = 60D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.MajorTickMark.Interval = 30D;
            chartArea1.AxisX.Maximum = 300D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorTickMark.Interval = 50D;
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
            chartArea1.Name = "ChartArea1";
            this.chartSensor.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSensor.Legends.Add(legend1);
            this.chartSensor.Location = new System.Drawing.Point(228, 38);
            this.chartSensor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.chartSensor.Size = new System.Drawing.Size(1211, 473);
            this.chartSensor.TabIndex = 0;
            this.chartSensor.Text = "Sensor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Location = new System.Drawing.Point(27, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(173, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opções";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(16, 27);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(139, 31);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Ativar Sensores";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(16, 64);
            this.btnTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(139, 26);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Identificar Aroma";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPorta);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(27, 153);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(173, 70);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Conexão";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(97, 33);
            this.txtPorta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(52, 22);
            this.txtPorta.TabIndex = 6;
            this.txtPorta.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Porta serial:";
            // 
            // lblSensor1
            // 
            this.lblSensor1.AutoSize = true;
            this.lblSensor1.Location = new System.Drawing.Point(4, 31);
            this.lblSensor1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSensor1.Name = "lblSensor1";
            this.lblSensor1.Size = new System.Drawing.Size(81, 17);
            this.lblSensor1.TabIndex = 5;
            this.lblSensor1.Text = "Sem Dados";
            // 
            // updateChart
            // 
            this.updateChart.Interval = 500;
            this.updateChart.Tick += new System.EventHandler(this.updateChart_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblSensor5, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSensor4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSensor3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSensor2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSensor1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(228, 517);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.68293F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.31707F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1211, 73);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblSensor5
            // 
            this.lblSensor5.AutoSize = true;
            this.lblSensor5.Location = new System.Drawing.Point(972, 31);
            this.lblSensor5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSensor5.Name = "lblSensor5";
            this.lblSensor5.Size = new System.Drawing.Size(81, 17);
            this.lblSensor5.TabIndex = 15;
            this.lblSensor5.Text = "Sem Dados";
            // 
            // lblSensor4
            // 
            this.lblSensor4.AutoSize = true;
            this.lblSensor4.Location = new System.Drawing.Point(730, 31);
            this.lblSensor4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSensor4.Name = "lblSensor4";
            this.lblSensor4.Size = new System.Drawing.Size(81, 17);
            this.lblSensor4.TabIndex = 14;
            this.lblSensor4.Text = "Sem Dados";
            // 
            // lblSensor3
            // 
            this.lblSensor3.AutoSize = true;
            this.lblSensor3.Location = new System.Drawing.Point(488, 31);
            this.lblSensor3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSensor3.Name = "lblSensor3";
            this.lblSensor3.Size = new System.Drawing.Size(79, 17);
            this.lblSensor3.TabIndex = 13;
            this.lblSensor3.Text = "Sem dados";
            // 
            // lblSensor2
            // 
            this.lblSensor2.AutoSize = true;
            this.lblSensor2.Location = new System.Drawing.Point(246, 31);
            this.lblSensor2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSensor2.Name = "lblSensor2";
            this.lblSensor2.Size = new System.Drawing.Size(81, 17);
            this.lblSensor2.TabIndex = 12;
            this.lblSensor2.Text = "Sem Dados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(972, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sensor 5:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(730, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sensor 4:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(488, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sensor 3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sensor 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sensor 1:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treinamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1456, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // treinamentoToolStripMenuItem
            // 
            this.treinamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCarregarRede,
            this.btnCriarRede,
            this.btnSalvarNovaRede});
            this.treinamentoToolStripMenuItem.Name = "treinamentoToolStripMenuItem";
            this.treinamentoToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.treinamentoToolStripMenuItem.Text = "Rede";
            // 
            // btnCarregarRede
            // 
            this.btnCarregarRede.Name = "btnCarregarRede";
            this.btnCarregarRede.Size = new System.Drawing.Size(141, 26);
            this.btnCarregarRede.Text = "Carregar";
            this.btnCarregarRede.Click += new System.EventHandler(this.btnCarregarRede_Click);
            // 
            // btnCriarRede
            // 
            this.btnCriarRede.Name = "btnCriarRede";
            this.btnCriarRede.Size = new System.Drawing.Size(141, 26);
            this.btnCriarRede.Text = "Criar";
            this.btnCriarRede.Click += new System.EventHandler(this.btnCriarRede_Click);
            // 
            // btnSalvarNovaRede
            // 
            this.btnSalvarNovaRede.Name = "btnSalvarNovaRede";
            this.btnSalvarNovaRede.Size = new System.Drawing.Size(141, 26);
            this.btnSalvarNovaRede.Text = "Salvar";
            this.btnSalvarNovaRede.Click += new System.EventHandler(this.btnSalvarRede_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.OverwritePrompt = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTiposGas);
            this.groupBox2.Controls.Add(this.btnSalvarTreinamento);
            this.groupBox2.Location = new System.Drawing.Point(27, 229);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(173, 95);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Treinamento";
            // 
            // cmbTiposGas
            // 
            this.cmbTiposGas.FormattingEnabled = true;
            this.cmbTiposGas.Location = new System.Drawing.Point(16, 20);
            this.cmbTiposGas.Name = "cmbTiposGas";
            this.cmbTiposGas.Size = new System.Drawing.Size(139, 24);
            this.cmbTiposGas.TabIndex = 3;
            // 
            // btnSalvarTreinamento
            // 
            this.btnSalvarTreinamento.Location = new System.Drawing.Point(16, 49);
            this.btnSalvarTreinamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvarTreinamento.Name = "btnSalvarTreinamento";
            this.btnSalvarTreinamento.Size = new System.Drawing.Size(139, 26);
            this.btnSalvarTreinamento.TabIndex = 2;
            this.btnSalvarTreinamento.Text = "Salvar";
            this.btnSalvarTreinamento.UseVisualStyleBackColor = true;
            this.btnSalvarTreinamento.Click += new System.EventHandler(this.btnSalvarTreinamento_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartSensor);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odor Detection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSensor1;
        private System.Windows.Forms.Timer updateChart;
        private System.Windows.Forms.NumericUpDown txtPorta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSensor5;
        private System.Windows.Forms.Label lblSensor4;
        private System.Windows.Forms.Label lblSensor3;
        private System.Windows.Forms.Label lblSensor2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem treinamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCarregarRede;
        private System.Windows.Forms.ToolStripMenuItem btnSalvarNovaRede;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTiposGas;
        private System.Windows.Forms.Button btnSalvarTreinamento;
        private System.Windows.Forms.ToolStripMenuItem btnCriarRede;
    }
}

