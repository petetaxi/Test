namespace GitTestProject
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
			this.DoSomethingButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// DoSomethingButton
			// 
			this.DoSomethingButton.Location = new System.Drawing.Point(79, 69);
			this.DoSomethingButton.Name = "DoSomethingButton";
			this.DoSomethingButton.Size = new System.Drawing.Size(145, 23);
			this.DoSomethingButton.TabIndex = 0;
			this.DoSomethingButton.Text = "Do Something";
			this.DoSomethingButton.UseVisualStyleBackColor = true;
			this.DoSomethingButton.Click += new System.EventHandler(this.DoSomethingButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.DoSomethingButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button DoSomethingButton;
	}
}

