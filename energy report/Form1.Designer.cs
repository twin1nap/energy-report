namespace energy_report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageStroom = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxViewTypeStroom = new System.Windows.Forms.ComboBox();
            this.chartStroom = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageGas = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxViewTypeGas = new System.Windows.Forms.ComboBox();
            this.chartGas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPageStroom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStroom)).BeginInit();
            this.tabPageGas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageStroom);
            this.tabControl1.Controls.Add(this.tabPageGas);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageStroom
            // 
            this.tabPageStroom.Controls.Add(this.label1);
            this.tabPageStroom.Controls.Add(this.comboBoxViewTypeStroom);
            this.tabPageStroom.Controls.Add(this.chartStroom);
            this.tabPageStroom.Location = new System.Drawing.Point(4, 25);
            this.tabPageStroom.Name = "tabPageStroom";
            this.tabPageStroom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStroom.Size = new System.Drawing.Size(774, 404);
            this.tabPageStroom.TabIndex = 0;
            this.tabPageStroom.Text = "Stroom";
            this.tabPageStroom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "weergave";
            // 
            // comboBoxViewTypeStroom
            // 
            this.comboBoxViewTypeStroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewTypeStroom.FormattingEnabled = true;
            this.comboBoxViewTypeStroom.Items.AddRange(new object[] {
            "jaar",
            "maand"});
            this.comboBoxViewTypeStroom.Location = new System.Drawing.Point(6, 6);
            this.comboBoxViewTypeStroom.Name = "comboBoxViewTypeStroom";
            this.comboBoxViewTypeStroom.Size = new System.Drawing.Size(121, 24);
            this.comboBoxViewTypeStroom.TabIndex = 1;
            this.comboBoxViewTypeStroom.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // chartStroom
            // 
            this.chartStroom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisY.Interval = 2D;
            chartArea1.Name = "ChartArea1";
            this.chartStroom.ChartAreas.Add(chartArea1);
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.Name = "Legend1";
            legend1.Title = "legenda:";
            this.chartStroom.Legends.Add(legend1);
            this.chartStroom.Location = new System.Drawing.Point(6, 47);
            this.chartStroom.Name = "chartStroom";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.LabelToolTip = "\\n";
            series1.Legend = "Legend1";
            series1.MarkerSize = 7;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Stroom verbruik";
            series1.ToolTip = "#VALX\\n#VALY kwh";
            this.chartStroom.Series.Add(series1);
            this.chartStroom.Size = new System.Drawing.Size(685, 334);
            this.chartStroom.TabIndex = 0;
            this.chartStroom.Text = "chart1";
            // 
            // tabPageGas
            // 
            this.tabPageGas.Controls.Add(this.label2);
            this.tabPageGas.Controls.Add(this.comboBoxViewTypeGas);
            this.tabPageGas.Controls.Add(this.chartGas);
            this.tabPageGas.Location = new System.Drawing.Point(4, 25);
            this.tabPageGas.Name = "tabPageGas";
            this.tabPageGas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGas.Size = new System.Drawing.Size(774, 404);
            this.tabPageGas.TabIndex = 1;
            this.tabPageGas.Text = "Gas";
            this.tabPageGas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "weergave";
            // 
            // comboBoxViewTypeGas
            // 
            this.comboBoxViewTypeGas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewTypeGas.FormattingEnabled = true;
            this.comboBoxViewTypeGas.Items.AddRange(new object[] {
            "jaar",
            "maand"});
            this.comboBoxViewTypeGas.Location = new System.Drawing.Point(11, 11);
            this.comboBoxViewTypeGas.Name = "comboBoxViewTypeGas";
            this.comboBoxViewTypeGas.Size = new System.Drawing.Size(121, 24);
            this.comboBoxViewTypeGas.TabIndex = 4;
            this.comboBoxViewTypeGas.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // chartGas
            // 
            this.chartGas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Interval = 3D;
            chartArea2.AxisY.Interval = 2D;
            chartArea2.Name = "ChartArea1";
            this.chartGas.ChartAreas.Add(chartArea2);
            legend2.BorderColor = System.Drawing.Color.Black;
            legend2.Name = "Legend1";
            legend2.Title = "legenda:";
            this.chartGas.Legends.Add(legend2);
            this.chartGas.Location = new System.Drawing.Point(11, 52);
            this.chartGas.Name = "chartGas";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelToolTip = "\\n";
            series2.Legend = "Legend1";
            series2.MarkerSize = 7;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Gas verbruik";
            series2.ToolTip = "#VALX\\n#VALY kwh";
            this.chartGas.Series.Add(series2);
            this.chartGas.Size = new System.Drawing.Size(685, 334);
            this.chartGas.TabIndex = 3;
            this.chartGas.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageStroom.ResumeLayout(false);
            this.tabPageStroom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStroom)).EndInit();
            this.tabPageGas.ResumeLayout(false);
            this.tabPageGas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageStroom;
        private System.Windows.Forms.TabPage tabPageGas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxViewTypeStroom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxViewTypeGas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGas;
    }
}

