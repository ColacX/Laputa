using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laputa
{
	public class CustomForm : Form
	{
		private bool IsHideInstead = true;

		public CustomForm()
		{
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.FormWork_FormClosing );
		}

		private void FormWork_FormClosing( object sender, FormClosingEventArgs e )
		{
			if( !IsHideInstead )
				return;

			e.Cancel = true;
			Hide();
		}

		public void ForcedClose()
		{
			IsHideInstead = false;
			Close();
		}
	}
}
