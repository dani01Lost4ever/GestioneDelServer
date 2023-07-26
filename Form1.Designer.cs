namespace Spostamento_file
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonScegliOrigine = new System.Windows.Forms.Button();
            this.textBoxFolderOrigine = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogOrigine = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogDestinazione = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonDestinazione = new System.Windows.Forms.Button();
            this.textBoxDestinazione = new System.Windows.Forms.TextBox();
            this.buttonSposta = new System.Windows.Forms.Button();
            this.FileList = new System.Windows.Forms.TextBox();
            this.buttonCopia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonScegliOrigine
            // 
            this.buttonScegliOrigine.Location = new System.Drawing.Point(47, 63);
            this.buttonScegliOrigine.Name = "buttonScegliOrigine";
            this.buttonScegliOrigine.Size = new System.Drawing.Size(280, 47);
            this.buttonScegliOrigine.TabIndex = 0;
            this.buttonScegliOrigine.Text = "Scegli origine";
            this.buttonScegliOrigine.UseVisualStyleBackColor = true;
            // 
            // textBoxFolderOrigine
            // 
            this.textBoxFolderOrigine.Location = new System.Drawing.Point(359, 63);
            this.textBoxFolderOrigine.Multiline = true;
            this.textBoxFolderOrigine.Name = "textBoxFolderOrigine";
            this.textBoxFolderOrigine.Size = new System.Drawing.Size(592, 47);
            this.textBoxFolderOrigine.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // buttonDestinazione
            // 
            this.buttonDestinazione.Location = new System.Drawing.Point(47, 116);
            this.buttonDestinazione.Name = "buttonDestinazione";
            this.buttonDestinazione.Size = new System.Drawing.Size(280, 49);
            this.buttonDestinazione.TabIndex = 4;
            this.buttonDestinazione.Text = "buttonSelezionaDestinazione";
            this.buttonDestinazione.UseVisualStyleBackColor = true;
            // 
            // textBoxDestinazione
            // 
            this.textBoxDestinazione.Location = new System.Drawing.Point(359, 116);
            this.textBoxDestinazione.Multiline = true;
            this.textBoxDestinazione.Name = "textBoxDestinazione";
            this.textBoxDestinazione.Size = new System.Drawing.Size(592, 49);
            this.textBoxDestinazione.TabIndex = 5;
            // 
            // buttonSposta
            // 
            this.buttonSposta.Location = new System.Drawing.Point(47, 339);
            this.buttonSposta.Name = "buttonSposta";
            this.buttonSposta.Size = new System.Drawing.Size(904, 49);
            this.buttonSposta.TabIndex = 6;
            this.buttonSposta.Text = "buttonSpostaToDestinazione";
            this.buttonSposta.UseVisualStyleBackColor = true;
            // 
            // FileList
            // 
            this.FileList.Location = new System.Drawing.Point(47, 394);
            this.FileList.Multiline = true;
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(904, 90);
            this.FileList.TabIndex = 7;
            // 
            // buttonCopia
            // 
            this.buttonCopia.Location = new System.Drawing.Point(47, 284);
            this.buttonCopia.Name = "buttonCopia";
            this.buttonCopia.Size = new System.Drawing.Size(904, 49);
            this.buttonCopia.TabIndex = 8;
            this.buttonCopia.Text = "buttonCopiaToDestinazione";
            this.buttonCopia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 496);
            this.Controls.Add(this.buttonCopia);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.buttonSposta);
            this.Controls.Add(this.textBoxDestinazione);
            this.Controls.Add(this.buttonDestinazione);
            this.Controls.Add(this.textBoxFolderOrigine);
            this.Controls.Add(this.buttonScegliOrigine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonScegliOrigine;
        private System.Windows.Forms.TextBox textBoxFolderOrigine;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOrigine;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDestinazione;
        private System.Windows.Forms.Button buttonDestinazione;
        private System.Windows.Forms.TextBox textBoxDestinazione;
        private System.Windows.Forms.Button buttonSposta;
        private System.Windows.Forms.TextBox FileList;
        private System.Windows.Forms.Button buttonCopia;
    }
}

