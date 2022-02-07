
namespace Wordle
{
    partial class Wordle
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCases = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpLettres = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grpCases
            // 
            this.grpCases.Location = new System.Drawing.Point(25, 61);
            this.grpCases.Name = "grpCases";
            this.grpCases.Size = new System.Drawing.Size(344, 410);
            this.grpCases.TabIndex = 0;
            this.grpCases.TabStop = false;
            // 
            // grpLettres
            // 
            this.grpLettres.Location = new System.Drawing.Point(25, 486);
            this.grpLettres.Name = "grpLettres";
            this.grpLettres.Size = new System.Drawing.Size(344, 297);
            this.grpLettres.TabIndex = 0;
            this.grpLettres.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "WORDLE";
            // 
            // Wordle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 795);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpLettres);
            this.Controls.Add(this.grpCases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Wordle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wordle";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Wordle_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCases;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpLettres;
        private System.Windows.Forms.Label label1;
    }
}

