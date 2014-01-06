namespace AddressBook
{
  partial class WantToClose
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
      this.CloseNo_button = new System.Windows.Forms.Button();
      this.CloseYes_button = new System.Windows.Forms.Button();
      this.CloseCancel_button = new System.Windows.Forms.Button();
      this.SaveBeforeQuit_label = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // CloseNo_button
      // 
      this.CloseNo_button.Location = new System.Drawing.Point(217, 72);
      this.CloseNo_button.Name = "CloseNo_button";
      this.CloseNo_button.Size = new System.Drawing.Size(74, 37);
      this.CloseNo_button.TabIndex = 7;
      this.CloseNo_button.Text = "No";
      this.CloseNo_button.UseVisualStyleBackColor = true;
      this.CloseNo_button.Click += new System.EventHandler(this.CloseNo_button_Click);
      // 
      // CloseYes_button
      // 
      this.CloseYes_button.Location = new System.Drawing.Point(417, 72);
      this.CloseYes_button.Name = "CloseYes_button";
      this.CloseYes_button.Size = new System.Drawing.Size(74, 37);
      this.CloseYes_button.TabIndex = 6;
      this.CloseYes_button.Text = "Yes";
      this.CloseYes_button.UseVisualStyleBackColor = true;
      this.CloseYes_button.Click += new System.EventHandler(this.CloseYes_button_Click);
      // 
      // CloseCancel_button
      // 
      this.CloseCancel_button.Location = new System.Drawing.Point(28, 72);
      this.CloseCancel_button.Name = "CloseCancel_button";
      this.CloseCancel_button.Size = new System.Drawing.Size(75, 37);
      this.CloseCancel_button.TabIndex = 5;
      this.CloseCancel_button.Text = "Cancel";
      this.CloseCancel_button.UseVisualStyleBackColor = true;
      this.CloseCancel_button.Click += new System.EventHandler(this.CloseCancel_button_Click);
      // 
      // SaveBeforeQuit_label
      // 
      this.SaveBeforeQuit_label.AutoSize = true;
      this.SaveBeforeQuit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SaveBeforeQuit_label.Location = new System.Drawing.Point(113, 9);
      this.SaveBeforeQuit_label.Name = "SaveBeforeQuit_label";
      this.SaveBeforeQuit_label.Size = new System.Drawing.Size(280, 20);
      this.SaveBeforeQuit_label.TabIndex = 4;
      this.SaveBeforeQuit_label.Text = "Would you like to save before quitting?";
      // 
      // WantToClose
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(519, 120);
      this.Controls.Add(this.CloseNo_button);
      this.Controls.Add(this.CloseYes_button);
      this.Controls.Add(this.CloseCancel_button);
      this.Controls.Add(this.SaveBeforeQuit_label);
      this.Name = "WantToClose";
      this.Text = "WantToClose";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button CloseNo_button;
    private System.Windows.Forms.Button CloseYes_button;
    private System.Windows.Forms.Button CloseCancel_button;
    private System.Windows.Forms.Label SaveBeforeQuit_label;
  }
}