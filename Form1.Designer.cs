namespace TutorialPractice
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
            this.CalculateRoot = new System.Windows.Forms.Button();
            this.aValue = new System.Windows.Forms.TextBox();
            this.aLabel = new System.Windows.Forms.Label();
            this.bValue = new System.Windows.Forms.TextBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.cValue = new System.Windows.Forms.TextBox();
            this.cLabel = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.instruct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculateRoot
            // 
            this.CalculateRoot.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CalculateRoot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CalculateRoot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CalculateRoot.Location = new System.Drawing.Point(195, 267);
            this.CalculateRoot.Name = "CalculateRoot";
            this.CalculateRoot.Size = new System.Drawing.Size(174, 51);
            this.CalculateRoot.TabIndex = 0;
            this.CalculateRoot.Text = "Calculate Root";
            this.CalculateRoot.UseVisualStyleBackColor = false;
            this.CalculateRoot.Click += new System.EventHandler(this.CalculateRoot_Click);
            // 
            // aValue
            // 
            this.aValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aValue.Location = new System.Drawing.Point(108, 96);
            this.aValue.Name = "aValue";
            this.aValue.Size = new System.Drawing.Size(101, 27);
            this.aValue.TabIndex = 1;
            this.aValue.TextChanged += new System.EventHandler(this.aValue_TextChanged);
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(90, 110);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(15, 16);
            this.aLabel.TabIndex = 2;
            this.aLabel.Text = "a";
            this.aLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // bValue
            // 
            this.bValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bValue.Location = new System.Drawing.Point(245, 97);
            this.bValue.Name = "bValue";
            this.bValue.Size = new System.Drawing.Size(101, 27);
            this.bValue.TabIndex = 3;
            this.bValue.TextChanged += new System.EventHandler(this.bValue_TextChanged);
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(228, 111);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(15, 16);
            this.bLabel.TabIndex = 4;
            this.bLabel.Text = "b";
            // 
            // cValue
            // 
            this.cValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cValue.Location = new System.Drawing.Point(372, 96);
            this.cValue.Name = "cValue";
            this.cValue.Size = new System.Drawing.Size(101, 27);
            this.cValue.TabIndex = 5;
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(355, 110);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(14, 16);
            this.cLabel.TabIndex = 6;
            this.cLabel.Text = "c";
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(93, 181);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(391, 27);
            this.output.TabIndex = 7;
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // instruct
            // 
            this.instruct.AutoSize = true;
            this.instruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruct.Location = new System.Drawing.Point(42, 23);
            this.instruct.Name = "instruct";
            this.instruct.Size = new System.Drawing.Size(603, 25);
            this.instruct.TabIndex = 8;
            this.instruct.Text = "Please enter value a, b and c of from your quadratic equation:";
            this.instruct.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 351);
            this.Controls.Add(this.instruct);
            this.Controls.Add(this.output);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.cValue);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.bValue);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.aValue);
            this.Controls.Add(this.CalculateRoot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateRoot;
        private System.Windows.Forms.TextBox aValue;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.TextBox bValue;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.TextBox cValue;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label instruct;
    }
}

