namespace Laputa
{
	partial class FormWork
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
			this.treeViewWork = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// treeViewWork
			// 
			this.treeViewWork.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewWork.Location = new System.Drawing.Point( 0, 0 );
			this.treeViewWork.Name = "treeViewWork";
			this.treeViewWork.Size = new System.Drawing.Size( 940, 504 );
			this.treeViewWork.TabIndex = 0;
			this.treeViewWork.ItemDrag += new System.Windows.Forms.ItemDragEventHandler( this.treeViewWork_ItemDrag );
			this.treeViewWork.DragDrop += new System.Windows.Forms.DragEventHandler( this.treeViewWork_DragDrop );
			this.treeViewWork.DragEnter += new System.Windows.Forms.DragEventHandler( this.treeViewWork_DragEnter );
			this.treeViewWork.DragOver += new System.Windows.Forms.DragEventHandler( this.treeViewWork_DragOver );
			this.treeViewWork.DragLeave += new System.EventHandler( this.treeViewWork_DragLeave );
			this.treeViewWork.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler( this.treeViewWork_GiveFeedback );
			this.treeViewWork.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler( this.treeViewWork_QueryContinueDrag );
			// 
			// FormWork
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 940, 504 );
			this.Controls.Add( this.treeViewWork );
			this.Name = "FormWork";
			this.Text = "FormWork";
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.TreeView treeViewWork;
	}
}