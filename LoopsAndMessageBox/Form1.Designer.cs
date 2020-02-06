namespace LoopsAndMessageBox
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
      this.btnDo = new System.Windows.Forms.Button();
      this.btnWhile = new System.Windows.Forms.Button();
      this.btnFor = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnDo
      // 
      this.btnDo.Location = new System.Drawing.Point(226, 64);
      this.btnDo.Name = "btnDo";
      this.btnDo.Size = new System.Drawing.Size(126, 38);
      this.btnDo.TabIndex = 0;
      this.btnDo.Text = "Do";
      this.btnDo.UseVisualStyleBackColor = true;
      this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
      // 
      // btnWhile
      // 
      this.btnWhile.Location = new System.Drawing.Point(57, 64);
      this.btnWhile.Name = "btnWhile";
      this.btnWhile.Size = new System.Drawing.Size(126, 38);
      this.btnWhile.TabIndex = 1;
      this.btnWhile.Text = "While";
      this.btnWhile.UseVisualStyleBackColor = true;
      this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
      // 
      // btnFor
      // 
      this.btnFor.Location = new System.Drawing.Point(396, 64);
      this.btnFor.Name = "btnFor";
      this.btnFor.Size = new System.Drawing.Size(126, 38);
      this.btnFor.TabIndex = 2;
      this.btnFor.Text = "For";
      this.btnFor.UseVisualStyleBackColor = true;
      this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(590, 159);
      this.Controls.Add(this.btnFor);
      this.Controls.Add(this.btnWhile);
      this.Controls.Add(this.btnDo);
      this.Name = "Form1";
      this.Text = "Lööps";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnDo;
    private System.Windows.Forms.Button btnWhile;
    private System.Windows.Forms.Button btnFor;
  }
}

