namespace GADE6122_POE_PART1
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
            this.lblPlayerInfo = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.lblHitOrMiss = new System.Windows.Forms.Label();
            this.comboBoxEnemies = new System.Windows.Forms.ComboBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerInfo
            // 
            this.lblPlayerInfo.AutoSize = true;
            this.lblPlayerInfo.Location = new System.Drawing.Point(12, 9);
            this.lblPlayerInfo.Name = "lblPlayerInfo";
            this.lblPlayerInfo.Size = new System.Drawing.Size(60, 13);
            this.lblPlayerInfo.TabIndex = 0;
            this.lblPlayerInfo.Text = "Player Info:";
            this.lblPlayerInfo.Click += new System.EventHandler(this.lblPlayerInfo_Click);
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(164, 9);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(28, 13);
            this.lblMap.TabIndex = 1;
            this.lblMap.Text = "Map";
            this.lblMap.Click += new System.EventHandler(this.lblMap_Click);
            // 
            // lblHitOrMiss
            // 
            this.lblHitOrMiss.AutoSize = true;
            this.lblHitOrMiss.Location = new System.Drawing.Point(15, 131);
            this.lblHitOrMiss.Name = "lblHitOrMiss";
            this.lblHitOrMiss.Size = new System.Drawing.Size(52, 13);
            this.lblHitOrMiss.TabIndex = 2;
            this.lblHitOrMiss.Text = "HitOrMiss";
            this.lblHitOrMiss.Click += new System.EventHandler(this.lblHitOrMiss_Click);
            // 
            // comboBoxEnemies
            // 
            this.comboBoxEnemies.FormattingEnabled = true;
            this.comboBoxEnemies.Location = new System.Drawing.Point(667, 12);
            this.comboBoxEnemies.Name = "comboBoxEnemies";
            this.comboBoxEnemies.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEnemies.TabIndex = 3;
            this.comboBoxEnemies.SelectedIndexChanged += new System.EventHandler(this.comboBoxEnemies_SelectedIndexChanged);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(361, 289);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "UP";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(361, 318);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(442, 318);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = "RIGHT";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(280, 318);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "LEFT";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.comboBoxEnemies);
            this.Controls.Add(this.lblHitOrMiss);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.lblPlayerInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerInfo;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblHitOrMiss;
        private System.Windows.Forms.ComboBox comboBoxEnemies;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
    }
}

