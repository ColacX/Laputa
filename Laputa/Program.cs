using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;

namespace Laputa
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );

			FormWork formWork = new FormWork();
			FormDebug formDebug = new FormDebug();

			NotifyIcon notifyIcon = new NotifyIcon();
			notifyIcon.Icon = Properties.Resources.Icon1;
			notifyIcon.Visible = true;
			notifyIcon.ContextMenuStrip = new ContextMenuStrip();

			var menuItemExit = new ToolStripMenuItem();
			menuItemExit.Text = "Exit";

			menuItemExit.Click += ( o, e ) =>
			{
				//ask to save edits
				//ask to stop script
				
				notifyIcon.Visible = false;
				formWork.ForcedClose();
				formDebug.ForcedClose();
				Application.Exit();
			};

			var menuItemWork = new ToolStripMenuItem();
			menuItemWork.Text = "Work";

			menuItemWork.Click += ( o, e ) =>
			{
				menuItemWork.Checked = !menuItemWork.Checked;
				formWork.Visible = menuItemWork.Checked;
			};

			var menuItemDebug = new ToolStripMenuItem();
			menuItemDebug.Text = "Debug";

			menuItemDebug.Click += ( o, e ) =>
			{
				menuItemDebug.Checked = !menuItemDebug.Checked;
				formDebug.Visible = menuItemDebug.Checked;
			};

			notifyIcon.Click += ( s, a ) => 
			{
				try
				{
					notifyIcon.ContextMenuStrip.Items.Clear();

					menuItemWork.Checked = formWork.Visible;
					notifyIcon.ContextMenuStrip.Items.Add( menuItemWork );

					menuItemDebug.Checked = formDebug.Visible;
					notifyIcon.ContextMenuStrip.Items.Add( menuItemDebug );
					
					notifyIcon.ContextMenuStrip.Items.Add( "-" );
					notifyIcon.ContextMenuStrip.Items.Add( menuItemExit );

					MethodInfo mi = typeof( NotifyIcon ).GetMethod( "ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic );
					mi.Invoke( notifyIcon, null );
				}
				catch( Exception ex )
				{
					Console.WriteLine( ex );
				}
			};

			Application.Run();
		}
	}
}
