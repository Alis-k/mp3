namespace Reproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Cargar = new System.Windows.Forms.Button();
            this.Reproducir = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.labelRUTA = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(12, 355);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(138, 37);
            this.Cargar.TabIndex = 1;
            this.Cargar.Text = "Cargar";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // Reproducir
            // 
            this.Reproducir.Location = new System.Drawing.Point(156, 355);
            this.Reproducir.Name = "Reproducir";
            this.Reproducir.Size = new System.Drawing.Size(138, 37);
            this.Reproducir.TabIndex = 2;
            this.Reproducir.Text = "Reproducir";
            this.Reproducir.UseVisualStyleBackColor = true;
            this.Reproducir.Click += new System.EventHandler(this.Reproducir_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(300, 355);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(138, 37);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(444, 355);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(138, 37);
            this.Pause.TabIndex = 4;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // labelRUTA
            // 
            this.labelRUTA.AutoSize = true;
            this.labelRUTA.Location = new System.Drawing.Point(27, 395);
            this.labelRUTA.Name = "labelRUTA";
            this.labelRUTA.Size = new System.Drawing.Size(30, 13);
            this.labelRUTA.TabIndex = 5;
            this.labelRUTA.Text = "Ruta";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(2, 13);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(592, 336);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 414);
            this.Controls.Add(this.labelRUTA);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Reproducir);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "video y mp3";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Button Reproducir;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Label labelRUTA;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

