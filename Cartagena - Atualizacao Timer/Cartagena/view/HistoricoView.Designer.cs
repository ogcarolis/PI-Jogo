namespace Cartagena.view
{
    partial class HistoricoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoricoView));
            this.panelHistorico = new System.Windows.Forms.Panel();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.tmrHistorico = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelHistorico
            // 
            this.panelHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(132)))));
            this.panelHistorico.Location = new System.Drawing.Point(27, 68);
            this.panelHistorico.Name = "panelHistorico";
            this.panelHistorico.Size = new System.Drawing.Size(309, 551);
            this.panelHistorico.TabIndex = 19;
            // 
            // lblHistorico
            // 
            this.lblHistorico.AutoSize = true;
            this.lblHistorico.BackColor = System.Drawing.Color.Transparent;
            this.lblHistorico.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.ForeColor = System.Drawing.Color.White;
            this.lblHistorico.Location = new System.Drawing.Point(79, 28);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(198, 27);
            this.lblHistorico.TabIndex = 20;
            this.lblHistorico.Text = "Histórico da partida";
            this.lblHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrHistorico
            // 
            this.tmrHistorico.Interval = 10000;
            this.tmrHistorico.Tick += new System.EventHandler(this.tmrHistorico_Tick);
            // 
            // HistoricoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cartagena.Properties.Resources.fundo_partida;
            this.ClientSize = new System.Drawing.Size(361, 667);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.panelHistorico);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistoricoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bogotá";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelHistorico;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Timer tmrHistorico;
    }
}