namespace Laputa
{
	partial class FormDebug
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.buttonStep = new System.Windows.Forms.Button();
			this.buttonContinue = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			this.buttonPause = new System.Windows.Forms.Button();
			this.checkBoxDontPause = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.richTextBox1.Location = new System.Drawing.Point( -1, 0 );
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size( 1064, 503 );
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// buttonStep
			// 
			this.buttonStep.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.buttonStep.Location = new System.Drawing.Point( 299, 541 );
			this.buttonStep.Name = "buttonStep";
			this.buttonStep.Size = new System.Drawing.Size( 75, 23 );
			this.buttonStep.TabIndex = 1;
			this.buttonStep.Text = "buttonStep";
			this.buttonStep.UseVisualStyleBackColor = true;
			// 
			// buttonContinue
			// 
			this.buttonContinue.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.buttonContinue.Location = new System.Drawing.Point( 12, 541 );
			this.buttonContinue.Name = "buttonContinue";
			this.buttonContinue.Size = new System.Drawing.Size( 97, 23 );
			this.buttonContinue.TabIndex = 3;
			this.buttonContinue.Text = "buttonContinue";
			this.buttonContinue.UseVisualStyleBackColor = true;
			// 
			// buttonStop
			// 
			this.buttonStop.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.buttonStop.Location = new System.Drawing.Point( 218, 541 );
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size( 75, 23 );
			this.buttonStop.TabIndex = 4;
			this.buttonStop.Text = "buttonStop";
			this.buttonStop.UseVisualStyleBackColor = true;
			// 
			// buttonPause
			// 
			this.buttonPause.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.buttonPause.Location = new System.Drawing.Point( 115, 541 );
			this.buttonPause.Name = "buttonPause";
			this.buttonPause.Size = new System.Drawing.Size( 97, 23 );
			this.buttonPause.TabIndex = 3;
			this.buttonPause.Text = "buttonPause";
			this.buttonPause.UseVisualStyleBackColor = true;
			// 
			// checkBoxDontPause
			// 
			this.checkBoxDontPause.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
			this.checkBoxDontPause.AutoSize = true;
			this.checkBoxDontPause.Location = new System.Drawing.Point( 13, 518 );
			this.checkBoxDontPause.Name = "checkBoxDontPause";
			this.checkBoxDontPause.Size = new System.Drawing.Size( 127, 17 );
			this.checkBoxDontPause.TabIndex = 5;
			this.checkBoxDontPause.Text = "checkBoxDontPause";
			this.checkBoxDontPause.UseVisualStyleBackColor = true;
			// 
			// FormDebug
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 1064, 576 );
			this.Controls.Add( this.checkBoxDontPause );
			this.Controls.Add( this.buttonStop );
			this.Controls.Add( this.buttonPause );
			this.Controls.Add( this.buttonContinue );
			this.Controls.Add( this.buttonStep );
			this.Controls.Add( this.richTextBox1 );
			this.Name = "FormDebug";
			this.Text = "FormDebug";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button buttonStep;
		private System.Windows.Forms.Button buttonContinue;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Button buttonPause;
		private System.Windows.Forms.CheckBox checkBoxDontPause;
	}
}