namespace PilotSafeGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.FieldSize = new System.Windows.Forms.NumericUpDown();
            this.sizeParamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FieldSize)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartButton.Location = new System.Drawing.Point(2, 36);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(130, 26);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartClickHandler);
            // 
            // FieldSize
            // 
            this.FieldSize.Location = new System.Drawing.Point(88, 7);
            this.FieldSize.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.FieldSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.FieldSize.Name = "FieldSize";
            this.FieldSize.Size = new System.Drawing.Size(44, 23);
            this.FieldSize.TabIndex = 1;
            this.FieldSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // sizeParamLabel
            // 
            this.sizeParamLabel.AutoSize = true;
            this.sizeParamLabel.Location = new System.Drawing.Point(2, 9);
            this.sizeParamLabel.Name = "sizeParamLabel";
            this.sizeParamLabel.Size = new System.Drawing.Size(80, 15);
            this.sizeParamLabel.TabIndex = 2;
            this.sizeParamLabel.Text = "Размер сетки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sizeParamLabel);
            this.Controls.Add(this.FieldSize);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FieldSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartButton;
        private NumericUpDown FieldSize;
        private Label sizeParamLabel;
    }
}