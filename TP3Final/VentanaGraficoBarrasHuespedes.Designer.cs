
namespace TP3Final
{
    partial class VentanaGraficoBarrasHuespedes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaGraficoBarrasHuespedes));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chartPasajeros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(12, 383);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(375, 32);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // chartPasajeros
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPasajeros.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPasajeros.Legends.Add(legend1);
            this.chartPasajeros.Location = new System.Drawing.Point(12, 12);
            this.chartPasajeros.Name = "chartPasajeros";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Pasajeros";
            this.chartPasajeros.Series.Add(series1);
            this.chartPasajeros.Size = new System.Drawing.Size(375, 364);
            this.chartPasajeros.TabIndex = 2;
            this.chartPasajeros.Text = "chart1";
            this.chartPasajeros.Click += new System.EventHandler(this.chartPasajeros_Click);
            // 
            // VentanaGraficoBarrasHuespedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 421);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chartPasajeros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaGraficoBarrasHuespedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaGraficoBarrasHuespedes";
            ((System.ComponentModel.ISupportInitialize)(this.chartPasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartPasajeros;
    }
}