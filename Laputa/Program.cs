using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

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
			formWork.Load();
			FormDebug formDebug = new FormDebug();
			formDebug.Load();

			NotifyIcon notifyIcon = new NotifyIcon();
			notifyIcon.Icon = Properties.Resources.Icon1;
			notifyIcon.Visible = true;
			notifyIcon.ContextMenuStrip = new ContextMenuStrip();

			var menuItemExit = new ToolStripMenuItem();
			menuItemExit.Text = "Exit";

			menuItemExit.Click += ( o, e ) =>
			{
				try
				{
					//ask to save edits
					//ask to stop script
				
					notifyIcon.Visible = false;
					formWork.CloseLogic();
					formDebug.CloseLogic();
					Application.Exit();
				}
				catch( Exception ex )
				{
					Console.WriteLine( ex );
				}
			};

			var menuItemReset = new ToolStripMenuItem();
			menuItemReset.Text = "Reset";

			menuItemReset.Click += ( o, e ) =>
			{
				try
				{
					string[] filePaths = Directory.GetFiles( Directory.GetCurrentDirectory() + @"\..\Data" );

					foreach( string filePath in filePaths )
						File.Delete( filePath );
				}
				catch( Exception ex )
				{
					Console.WriteLine( ex );
				}
			};

			var menuItemWork = new ToolStripMenuItem();
			menuItemWork.Text = "Work";

			menuItemWork.Click += ( o, e ) =>
			{
				try
				{
					menuItemWork.Checked = !menuItemWork.Checked;
					formWork.Visible = menuItemWork.Checked;
				}
				catch( Exception ex )
				{
					Console.WriteLine( ex );
				}
			};

			var menuItemDebug = new ToolStripMenuItem();
			menuItemDebug.Text = "Debug";

			menuItemDebug.Click += ( o, e ) =>
			{
				try
				{
					menuItemDebug.Checked = !menuItemDebug.Checked;
					formDebug.Visible = menuItemDebug.Checked;
				}
				catch( Exception ex )
				{
					Console.WriteLine( ex );
				}
			};

			var releaseVersion = "Laputa 0.0.0.1";
			notifyIcon.Text = releaseVersion;

			notifyIcon.Click += ( s, a ) => 
			{
				try
				{
					var args = (MouseEventArgs)a;

					if(args.Button == MouseButtons.Right)
					{
						//show context menu
						notifyIcon.ContextMenuStrip.Items.Clear();

						menuItemWork.Checked = formWork.Visible;
						notifyIcon.ContextMenuStrip.Items.Add( menuItemWork );

						menuItemDebug.Checked = formDebug.Visible;
						notifyIcon.ContextMenuStrip.Items.Add( menuItemDebug );
					
						notifyIcon.ContextMenuStrip.Items.Add( "-" );
						notifyIcon.ContextMenuStrip.Items.Add( menuItemReset );
						notifyIcon.ContextMenuStrip.Items.Add( menuItemExit );

						MethodInfo mi = typeof( NotifyIcon ).GetMethod( "ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic );
						mi.Invoke( notifyIcon, null );
					}
					else if( args.Button == MouseButtons.Left )
					{
						//bring all forms to front;
						formDebug.Activate();
						formWork.Activate();
					}
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
