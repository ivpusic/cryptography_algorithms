namespace cryptographyProject
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSazetak = new System.Windows.Forms.TextBox();
            this.txtSazetakFile = new System.Windows.Forms.TextBox();
            this.btnCalcHash = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnOpeDat = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSymDecrypt = new System.Windows.Forms.Button();
            this.btnSynCrypt = new System.Windows.Forms.Button();
            this.txtFile_second_tab = new System.Windows.Forms.TextBox();
            this.btnOpnDat = new System.Windows.Forms.Button();
            this.genSymKey = new System.Windows.Forms.Button();
            this.btnGenAsnycKeys = new System.Windows.Forms.Button();
            this.btnDigSign = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnAsyncDecrypt = new System.Windows.Forms.Button();
            this.btnAsyncCrypt = new System.Windows.Forms.Button();
            this.btnDigSignVerify = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenDat = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "SHA1 Sažetak";
            // 
            // txtSazetak
            // 
            this.txtSazetak.Location = new System.Drawing.Point(173, 127);
            this.txtSazetak.Name = "txtSazetak";
            this.txtSazetak.ReadOnly = true;
            this.txtSazetak.Size = new System.Drawing.Size(278, 20);
            this.txtSazetak.TabIndex = 6;
            // 
            // txtSazetakFile
            // 
            this.txtSazetakFile.Location = new System.Drawing.Point(166, 21);
            this.txtSazetakFile.Name = "txtSazetakFile";
            this.txtSazetakFile.Size = new System.Drawing.Size(278, 20);
            this.txtSazetakFile.TabIndex = 5;
            // 
            // btnCalcHash
            // 
            this.btnCalcHash.Location = new System.Drawing.Point(20, 111);
            this.btnCalcHash.Name = "btnCalcHash";
            this.btnCalcHash.Size = new System.Drawing.Size(140, 50);
            this.btnCalcHash.TabIndex = 3;
            this.btnCalcHash.Text = "Izračunaj sažetak";
            this.btnCalcHash.UseVisualStyleBackColor = true;
            this.btnCalcHash.Click += new System.EventHandler(this.btnCalcHash_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtSazetak);
            this.tabPage3.Controls.Add(this.txtSazetakFile);
            this.tabPage3.Controls.Add(this.btnOpeDat);
            this.tabPage3.Controls.Add(this.btnCalcHash);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(573, 252);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sažetak";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnOpeDat
            // 
            this.btnOpeDat.Location = new System.Drawing.Point(20, 15);
            this.btnOpeDat.Name = "btnOpeDat";
            this.btnOpeDat.Size = new System.Drawing.Size(140, 30);
            this.btnOpeDat.TabIndex = 4;
            this.btnOpeDat.Text = "Učitaj datoteku";
            this.btnOpeDat.UseVisualStyleBackColor = true;
            this.btnOpeDat.Click += new System.EventHandler(this.btnOpeDat_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnSymDecrypt);
            this.tabPage2.Controls.Add(this.btnSynCrypt);
            this.tabPage2.Controls.Add(this.txtFile_second_tab);
            this.tabPage2.Controls.Add(this.btnOpnDat);
            this.tabPage2.Controls.Add(this.genSymKey);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(573, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simetrično kriptiranje";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(103, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Simetrično kriptiranje";
            // 
            // btnSymDecrypt
            // 
            this.btnSymDecrypt.Location = new System.Drawing.Point(107, 154);
            this.btnSymDecrypt.Name = "btnSymDecrypt";
            this.btnSymDecrypt.Size = new System.Drawing.Size(140, 50);
            this.btnSymDecrypt.TabIndex = 6;
            this.btnSymDecrypt.Text = "Dekriptiraj";
            this.btnSymDecrypt.UseVisualStyleBackColor = true;
            this.btnSymDecrypt.Click += new System.EventHandler(this.btnSymDecrypt_Click);
            // 
            // btnSynCrypt
            // 
            this.btnSynCrypt.Location = new System.Drawing.Point(107, 98);
            this.btnSynCrypt.Name = "btnSynCrypt";
            this.btnSynCrypt.Size = new System.Drawing.Size(140, 50);
            this.btnSynCrypt.TabIndex = 5;
            this.btnSynCrypt.Text = "Kriptiraj";
            this.btnSynCrypt.UseVisualStyleBackColor = true;
            this.btnSynCrypt.Click += new System.EventHandler(this.btnSynCrypt_Click);
            // 
            // txtFile_second_tab
            // 
            this.txtFile_second_tab.Location = new System.Drawing.Point(166, 21);
            this.txtFile_second_tab.Name = "txtFile_second_tab";
            this.txtFile_second_tab.Size = new System.Drawing.Size(280, 20);
            this.txtFile_second_tab.TabIndex = 2;
            // 
            // btnOpnDat
            // 
            this.btnOpnDat.Location = new System.Drawing.Point(20, 15);
            this.btnOpnDat.Name = "btnOpnDat";
            this.btnOpnDat.Size = new System.Drawing.Size(140, 30);
            this.btnOpnDat.TabIndex = 1;
            this.btnOpnDat.Text = "Učitaj datoteku";
            this.btnOpnDat.UseVisualStyleBackColor = true;
            this.btnOpnDat.Click += new System.EventHandler(this.btnOpnDat_Click);
            // 
            // genSymKey
            // 
            this.genSymKey.Location = new System.Drawing.Point(282, 125);
            this.genSymKey.Name = "genSymKey";
            this.genSymKey.Size = new System.Drawing.Size(180, 50);
            this.genSymKey.TabIndex = 0;
            this.genSymKey.Text = "Genriraj tajni ključ";
            this.genSymKey.UseVisualStyleBackColor = true;
            this.genSymKey.Click += new System.EventHandler(this.genSymKey_Click);
            // 
            // btnGenAsnycKeys
            // 
            this.btnGenAsnycKeys.Location = new System.Drawing.Point(188, 137);
            this.btnGenAsnycKeys.Name = "btnGenAsnycKeys";
            this.btnGenAsnycKeys.Size = new System.Drawing.Size(180, 50);
            this.btnGenAsnycKeys.TabIndex = 0;
            this.btnGenAsnycKeys.Text = "Generiraj par ključeva";
            this.btnGenAsnycKeys.UseVisualStyleBackColor = true;
            this.btnGenAsnycKeys.Click += new System.EventHandler(this.btnGenAsnycKeys_Click);
            // 
            // btnDigSign
            // 
            this.btnDigSign.Location = new System.Drawing.Point(21, 109);
            this.btnDigSign.Name = "btnDigSign";
            this.btnDigSign.Size = new System.Drawing.Size(140, 50);
            this.btnDigSign.TabIndex = 3;
            this.btnDigSign.Text = "Digitalni potpis";
            this.btnDigSign.UseVisualStyleBackColor = true;
            this.btnDigSign.Click += new System.EventHandler(this.btnDigSign_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(166, 21);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(280, 20);
            this.txtFile.TabIndex = 2;
            // 
            // btnAsyncDecrypt
            // 
            this.btnAsyncDecrypt.Location = new System.Drawing.Point(394, 165);
            this.btnAsyncDecrypt.Name = "btnAsyncDecrypt";
            this.btnAsyncDecrypt.Size = new System.Drawing.Size(140, 50);
            this.btnAsyncDecrypt.TabIndex = 6;
            this.btnAsyncDecrypt.Text = "Dekriptiraj";
            this.btnAsyncDecrypt.UseVisualStyleBackColor = true;
            this.btnAsyncDecrypt.Click += new System.EventHandler(this.btnAsyncDecrypt_Click);
            // 
            // btnAsyncCrypt
            // 
            this.btnAsyncCrypt.Location = new System.Drawing.Point(394, 109);
            this.btnAsyncCrypt.Name = "btnAsyncCrypt";
            this.btnAsyncCrypt.Size = new System.Drawing.Size(140, 50);
            this.btnAsyncCrypt.TabIndex = 5;
            this.btnAsyncCrypt.Text = "Kriptiraj";
            this.btnAsyncCrypt.UseVisualStyleBackColor = true;
            this.btnAsyncCrypt.Click += new System.EventHandler(this.btnAsyncCrypt_Click);
            // 
            // btnDigSignVerify
            // 
            this.btnDigSignVerify.Location = new System.Drawing.Point(21, 165);
            this.btnDigSignVerify.Name = "btnDigSignVerify";
            this.btnDigSignVerify.Size = new System.Drawing.Size(140, 50);
            this.btnDigSignVerify.TabIndex = 4;
            this.btnDigSignVerify.Text = "Provjera potpisa";
            this.btnDigSignVerify.UseVisualStyleBackColor = true;
            this.btnDigSignVerify.Click += new System.EventHandler(this.btnDigSignVerify_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 278);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnAsyncDecrypt);
            this.tabPage1.Controls.Add(this.btnAsyncCrypt);
            this.tabPage1.Controls.Add(this.btnDigSignVerify);
            this.tabPage1.Controls.Add(this.btnDigSign);
            this.tabPage1.Controls.Add(this.txtFile);
            this.tabPage1.Controls.Add(this.btnOpenDat);
            this.tabPage1.Controls.Add(this.btnGenAsnycKeys);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(573, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Digitalni potpis i asimetrično kriptiranje";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(390, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Asimetrično kriptiranje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Digitalni potpis";
            // 
            // btnOpenDat
            // 
            this.btnOpenDat.Location = new System.Drawing.Point(20, 15);
            this.btnOpenDat.Name = "btnOpenDat";
            this.btnOpenDat.Size = new System.Drawing.Size(140, 30);
            this.btnOpenDat.TabIndex = 1;
            this.btnOpenDat.Text = "Učitaj datoteku";
            this.btnOpenDat.UseVisualStyleBackColor = true;
            this.btnOpenDat.Click += new System.EventHandler(this.btnOpenDat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 273);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operacijski sustavi";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSazetak;
        private System.Windows.Forms.TextBox txtSazetakFile;
        private System.Windows.Forms.Button btnCalcHash;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnOpeDat;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSymDecrypt;
        private System.Windows.Forms.Button btnSynCrypt;
        private System.Windows.Forms.TextBox txtFile_second_tab;
        private System.Windows.Forms.Button genSymKey;
        private System.Windows.Forms.Button btnGenAsnycKeys;
        private System.Windows.Forms.Button btnDigSign;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnAsyncDecrypt;
        private System.Windows.Forms.Button btnAsyncCrypt;
        private System.Windows.Forms.Button btnDigSignVerify;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnOpenDat;
        private System.Windows.Forms.Button btnOpnDat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

