using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;

namespace Laputa
{
	public class CustomForm : Form
	{
		private bool IsHideInstead = true;

		public struct InstanceSetting
		{
			public Rectangle DesktopBounds;
			public FormWindowState WindowState;
			public bool Visible;
		};

		private InstanceSetting instanceSetting;

		public CustomForm()
		{
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.FormWork_FormClosing );
		}

		private void FormWork_FormClosing( object sender, FormClosingEventArgs e )
		{
			try
			{
				if( !IsHideInstead )
					return;

				e.Cancel = true;
				Hide();
			}
			catch( Exception ex )
			{
				Console.WriteLine( ex );
			}
		}

		public void CloseLogic()
		{
			Save();
		
			IsHideInstead = false;
			Close();
		}

		public void Save()
		{
			try
			{
				instanceSetting.DesktopBounds = this.DesktopBounds;
				instanceSetting.WindowState = this.WindowState == FormWindowState.Minimized ? FormWindowState.Normal : this.WindowState;
				instanceSetting.Visible = this.Visible;

				XmlSerializer serializer = new XmlSerializer( typeof( InstanceSetting ) );
				TextWriter textWriter = new StreamWriter( Directory.GetCurrentDirectory() + @"\..\Data\" + this.GetType() + "InstanceSetting.xml" );
				serializer.Serialize( textWriter, instanceSetting );
				textWriter.Close();
			}
			catch( Exception ex )
			{
				MessageBox.Show( this, ex.ToString() );
			}
		}

		public void Load()
		{
			try
			{
				XmlSerializer serializer = new XmlSerializer( typeof( InstanceSetting ) );
				TextReader textReader = new StreamReader( Directory.GetCurrentDirectory() + @"\..\Data\" + this.GetType() + "InstanceSetting.xml" );
				instanceSetting = ( InstanceSetting )serializer.Deserialize( textReader );
				textReader.Close();

				this.StartPosition = FormStartPosition.Manual;
				this.DesktopBounds = instanceSetting.DesktopBounds;

				this.WindowState = instanceSetting.WindowState;
				this.Visible = instanceSetting.Visible;
			}
			catch( Exception ex )
			{
				MessageBox.Show( this, ex.ToString() );
			}
		}
	}
}
