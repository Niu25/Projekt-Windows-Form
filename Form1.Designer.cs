namespace Projekt_Windows_Form
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.hinzufuegen = new System.Windows.Forms.Button();
            this.zuruecksetzen = new System.Windows.Forms.Button();
            this.vorname = new System.Windows.Forms.TextBox();
            this.nachname = new System.Windows.Forms.TextBox();
            this.SchuleSeit = new System.Windows.Forms.DateTimePicker();
            this.Schulname = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintergrundFarbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schriftartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hinzufuegen
            // 
            this.hinzufuegen.Location = new System.Drawing.Point(249, 348);
            this.hinzufuegen.Name = "hinzufuegen";
            this.hinzufuegen.Size = new System.Drawing.Size(98, 51);
            this.hinzufuegen.TabIndex = 0;
            this.hinzufuegen.Text = "hinzufügen";
            this.hinzufuegen.UseVisualStyleBackColor = true;
            // 
            // zuruecksetzen
            // 
            this.zuruecksetzen.Location = new System.Drawing.Point(421, 348);
            this.zuruecksetzen.Name = "zuruecksetzen";
            this.zuruecksetzen.Size = new System.Drawing.Size(98, 51);
            this.zuruecksetzen.TabIndex = 1;
            this.zuruecksetzen.Text = "zurücksetzen";
            this.zuruecksetzen.UseVisualStyleBackColor = true;
            // 
            // vorname
            // 
            this.vorname.Location = new System.Drawing.Point(23, 43);
            this.vorname.Name = "vorname";
            this.vorname.Size = new System.Drawing.Size(128, 20);
            this.vorname.TabIndex = 2;
            // 
            // nachname
            // 
            this.nachname.Location = new System.Drawing.Point(333, 24);
            this.nachname.Name = "nachname";
            this.nachname.Size = new System.Drawing.Size(128, 20);
            this.nachname.TabIndex = 3;
            // 
            // SchuleSeit
            // 
            this.SchuleSeit.Location = new System.Drawing.Point(23, 79);
            this.SchuleSeit.Name = "SchuleSeit";
            this.SchuleSeit.Size = new System.Drawing.Size(134, 20);
            this.SchuleSeit.TabIndex = 4;
            // 
            // Schulname
            // 
            this.Schulname.FormattingEnabled = true;
            this.Schulname.Location = new System.Drawing.Point(23, 120);
            this.Schulname.Name = "Schulname";
            this.Schulname.Size = new System.Drawing.Size(170, 21);
            this.Schulname.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(28, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 144);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(435, 201);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(273, 109);
            this.checkedListBox1.TabIndex = 7;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(614, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(124, 95);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datenToolStripMenuItem
            // 
            this.datenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hintergrundFarbeToolStripMenuItem,
            this.schriftartToolStripMenuItem,
            this.speichernToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.datenToolStripMenuItem.Name = "datenToolStripMenuItem";
            this.datenToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.datenToolStripMenuItem.Text = "Daten";
            // 
            // hintergrundFarbeToolStripMenuItem
            // 
            this.hintergrundFarbeToolStripMenuItem.Name = "hintergrundFarbeToolStripMenuItem";
            this.hintergrundFarbeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hintergrundFarbeToolStripMenuItem.Text = "Hintergrund&Farbe";
            // 
            // schriftartToolStripMenuItem
            // 
            this.schriftartToolStripMenuItem.Name = "schriftartToolStripMenuItem";
            this.schriftartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.schriftartToolStripMenuItem.Text = "Schriftart";
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speichernToolStripMenuItem.Text = "&Speichern";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Schulname);
            this.Controls.Add(this.SchuleSeit);
            this.Controls.Add(this.nachname);
            this.Controls.Add(this.vorname);
            this.Controls.Add(this.zuruecksetzen);
            this.Controls.Add(this.hinzufuegen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hinzufuegen;
        private System.Windows.Forms.Button zuruecksetzen;
        private System.Windows.Forms.TextBox vorname;
        private System.Windows.Forms.TextBox nachname;
        private System.Windows.Forms.DateTimePicker SchuleSeit;
        private System.Windows.Forms.ComboBox Schulname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hintergrundFarbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schriftartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

