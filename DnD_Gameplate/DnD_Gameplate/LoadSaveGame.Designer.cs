namespace DnD_Gameplate
{
    partial class LoadSaveGame
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
            this.lbl_Eingabe = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Bestätigen = new System.Windows.Forms.Button();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Eingabe
            // 
            this.lbl_Eingabe.AutoSize = true;
            this.lbl_Eingabe.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Eingabe.Location = new System.Drawing.Point(12, 9);
            this.lbl_Eingabe.Name = "lbl_Eingabe";
            this.lbl_Eingabe.Size = new System.Drawing.Size(386, 30);
            this.lbl_Eingabe.TabIndex = 0;
            this.lbl_Eingabe.Text = "Bitte Namen des Charakters eingeben";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(17, 42);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(377, 28);
            this.tb_Name.TabIndex = 1;
            // 
            // btn_Bestätigen
            // 
            this.btn_Bestätigen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Bestätigen.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bestätigen.Location = new System.Drawing.Point(17, 76);
            this.btn_Bestätigen.Name = "btn_Bestätigen";
            this.btn_Bestätigen.Size = new System.Drawing.Size(111, 37);
            this.btn_Bestätigen.TabIndex = 2;
            this.btn_Bestätigen.Text = "Bestätigen";
            this.btn_Bestätigen.UseVisualStyleBackColor = true;
            this.btn_Bestätigen.Click += new System.EventHandler(this.btn_Bestätigen_Click);
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Abbrechen.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abbrechen.Location = new System.Drawing.Point(283, 76);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(111, 37);
            this.btn_Abbrechen.TabIndex = 3;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            // 
            // LoadSaveGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(409, 126);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_Bestätigen);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Eingabe);
            this.Name = "LoadSaveGame";
            this.Text = "LoadSaveGame";
            this.Load += new System.EventHandler(this.LoadSaveGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Eingabe;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Bestätigen;
        private System.Windows.Forms.Button btn_Abbrechen;
    }
}