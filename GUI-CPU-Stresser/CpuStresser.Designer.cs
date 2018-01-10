namespace GUI_CPU_Stresser
{
    partial class cpustresser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cpustresser));
            this.input_threads = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.output_status = new System.Windows.Forms.Label();
            this.output_bar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.input_threads)).BeginInit();
            this.SuspendLayout();
            // 
            // input_threads
            // 
            this.input_threads.Location = new System.Drawing.Point(100, 51);
            this.input_threads.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.input_threads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.input_threads.Name = "input_threads";
            this.input_threads.Size = new System.Drawing.Size(147, 20);
            this.input_threads.TabIndex = 0;
            this.input_threads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Threads [1 - 30]";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(134, 25);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(113, 23);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(12, 25);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(113, 23);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // output_status
            // 
            this.output_status.AutoSize = true;
            this.output_status.Location = new System.Drawing.Point(12, 74);
            this.output_status.Name = "output_status";
            this.output_status.Size = new System.Drawing.Size(75, 13);
            this.output_status.TabIndex = 4;
            this.output_status.Text = "Status: stoped";
            // 
            // output_bar
            // 
            this.output_bar.Location = new System.Drawing.Point(12, 93);
            this.output_bar.Name = "output_bar";
            this.output_bar.Size = new System.Drawing.Size(235, 23);
            this.output_bar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPU Stresser by Zeeraa";
            // 
            // cpustresser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 126);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output_bar);
            this.Controls.Add(this.output_status);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_threads);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(275, 165);
            this.MinimumSize = new System.Drawing.Size(275, 165);
            this.Name = "cpustresser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU Stresser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cpustresser_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.input_threads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown input_threads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label output_status;
        private System.Windows.Forms.ProgressBar output_bar;
        private System.Windows.Forms.Label label2;
    }
}

