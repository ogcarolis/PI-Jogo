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
            this.tmrHistorico = new System.Windows.Forms.Timer(this.components);
            this.lbHistorico = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tmrHistorico
            // 
            this.tmrHistorico.Interval = 12000;
            this.tmrHistorico.Tick += new System.EventHandler(this.tmrHistorico_Tick);
            // 
            // lbHistorico
            // 
            this.lbHistorico.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistorico.FormattingEnabled = true;
            this.lbHistorico.ItemHeight = 16;
            this.lbHistorico.Location = new System.Drawing.Point(1, 132);
            this.lbHistorico.Name = "lbHistorico";
            this.lbHistorico.Size = new System.Drawing.Size(351, 500);
            this.lbHistorico.TabIndex = 0;
            // 
            // HistoricoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(352, 646);
            this.Controls.Add(this.lbHistorico);
            this.Name = "HistoricoView";
            this.Text = "HistoricoView";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrHistorico;
        private System.Windows.Forms.ListBox lbHistorico;
    }
}