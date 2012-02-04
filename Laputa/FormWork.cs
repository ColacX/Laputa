using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laputa
{
	public partial class FormWork : CustomForm
	{

		public FormWork()
		{
			InitializeComponent();

			TreeNode nodeRoot = new TreeNode( "Context: Default" );
			nodeRoot.BackColor = Color.Red;
			treeViewWork.Nodes.Add( nodeRoot );
			nodeRoot.ContextMenuStrip = new ContextMenuStrip();

			NodeContext.SharedMenu = new ContextMenuStrip();
			treeViewWork.Nodes.Add( new NodeContext() );

			{
				//node menu
				var menuNode = new ToolStripMenuItem();
				menuNode.Text = "Node";
				NodeContext.SharedMenu.Items.Add( menuNode );

				{
					var menuItemRun = new ToolStripMenuItem();
					menuItemRun.Text = "RunContext";
					menuNode.DropDown.Items.Add( menuItemRun );

					var menuItemEdit = new ToolStripMenuItem();
					menuItemEdit.Text = "Edit";
					menuNode.DropDown.Items.Add( menuItemEdit );

					//separator
					menuNode.DropDown.Items.Add( "-" );

					var menuItemReload = new ToolStripMenuItem();
					menuItemReload.Text = "Reload";
					menuNode.DropDown.Items.Add( menuItemReload );

					var menuItemLoad = new ToolStripMenuItem();
					menuItemLoad.Text = "Load";
					menuNode.DropDown.Items.Add( menuItemLoad );

					var menuItemSave = new ToolStripMenuItem();
					menuItemSave.Text = "Save";
					menuNode.DropDown.Items.Add( menuItemSave );

					//separator
					menuNode.DropDown.Items.Add( "-" );

					var menuItemCut = new ToolStripMenuItem();
					menuItemCut.Text = "Cut";
					menuNode.DropDown.Items.Add( menuItemCut );

					var menuItemCopy = new ToolStripMenuItem();
					menuItemCopy.Text = "Copy";
					menuNode.DropDown.Items.Add( menuItemCopy );

					var menuItemPaste = new ToolStripMenuItem();
					menuItemPaste.Text = "Paste";
					menuNode.DropDown.Items.Add( menuItemPaste );
				}

				//variable menu
				var menuVariable = new ToolStripMenuItem();
				menuVariable.Text = "Variable";
				NodeContext.SharedMenu.Items.Add( menuVariable );

				{
					var menuItemImage = new ToolStripMenuItem();
					menuItemImage.Text = "Image";
					menuVariable.DropDown.Items.Add( menuItemImage );

					var menuItemString = new ToolStripMenuItem();
					menuItemString.Text = "String";
					menuVariable.DropDownItems.Add( menuItemString );

					var menuItemNumber = new ToolStripMenuItem();
					menuItemNumber.Text = "Number";
					menuVariable.DropDownItems.Add( menuItemNumber );

					menuItemNumber.Click += delegate
					{
						nodeRoot.Nodes.Add( "Number" );
						nodeRoot.Expand();
					};
				}

				//action menu
				var menuAction = new ToolStripMenuItem();
				menuAction.Text = "Action";
				NodeContext.SharedMenu.Items.Add( menuAction );

				{
					//program menu
					var menuProgram = new ToolStripMenuItem();
					menuProgram.Text = "Program";
					menuAction.DropDown.Items.Add( menuProgram );

					{
						var menuContext = new ToolStripMenuItem();
						menuContext.Text = "Context";
						menuProgram.DropDown.Items.Add( menuContext );

						var menuRun = new ToolStripMenuItem();
						menuRun.Text = "RunContext";
						menuProgram.DropDown.Items.Add( menuRun );

						menuProgram.DropDown.Items.Add( "-" );

						var menuIf = new ToolStripMenuItem();
						menuIf.Text = "If";
						menuProgram.DropDown.Items.Add( menuIf );

						var menuLoop = new ToolStripMenuItem();
						menuLoop.Text = "Loop";
						menuProgram.DropDown.Items.Add( menuLoop );

						var menuBreak = new ToolStripMenuItem();
						menuBreak.Text = "Break";
						menuProgram.DropDown.Items.Add( menuBreak );

						var menuContinue = new ToolStripMenuItem();
						menuContinue.Text = "Continue";
						menuProgram.DropDown.Items.Add( menuContinue );

						menuProgram.DropDown.Items.Add( "-" );

						var menuSleep = new ToolStripMenuItem();
						menuSleep.Text = "Sleep";
						menuProgram.DropDown.Items.Add( menuSleep );

						var menuPause = new ToolStripMenuItem();
						menuPause.Text = "Pause";
						menuProgram.DropDown.Items.Add( menuPause );

						menuProgram.DropDown.Items.Add( "-" );

						var menuSet = new ToolStripMenuItem();
						menuSet.Text = "Set";
						menuProgram.DropDown.Items.Add( menuSet );
					}

					//capture menu
					var menuCapture = new ToolStripMenuItem();
					menuCapture.Text = "Capture";
					menuAction.DropDown.Items.Add( menuCapture );

					{
						var menuScreen = new ToolStripMenuItem();
						menuScreen.Text = "Screen";
						menuCapture.DropDown.Items.Add( menuScreen );

						menuScreen.Click += delegate
						{
							nodeRoot.Nodes.Add( "CaptureScreen" );
							nodeRoot.Expand();
						};
					}

					//mouse menu
					var menuMouse = new ToolStripMenuItem();
					menuMouse.Text = "Mouse";
					menuAction.DropDown.Items.Add( menuMouse );

					//keyboard menu
					var menuKeyboard = new ToolStripMenuItem();
					menuKeyboard.Text = "Keyboard";
					menuAction.DropDown.Items.Add( menuKeyboard );
				}
			}
		}

		private void treeViewWork_ItemDrag( object sender, ItemDragEventArgs e )
		{
			var x = e.Item;
		}

		private void treeViewWork_DragDrop( object sender, DragEventArgs e )
		{

		}

		private void treeViewWork_DragEnter( object sender, DragEventArgs e )
		{

		}

		private void treeViewWork_DragLeave( object sender, EventArgs e )
		{

		}

		private void treeViewWork_DragOver( object sender, DragEventArgs e )
		{

		}

		private void treeViewWork_GiveFeedback( object sender, GiveFeedbackEventArgs e )
		{

		}

		private void treeViewWork_QueryContinueDrag( object sender, QueryContinueDragEventArgs e )
		{

		}
	}

	public class NodeBase : TreeNode
	{
		public string Caption;
		public string Description;

		public virtual void Edit(IWin32Window owner)
		{
			new Form().ShowDialog(owner);
		}
	}

	public class NodeContext : NodeBase
	{
		public static ContextMenuStrip SharedMenu;

		public NodeContext contextParent;
		public List<NodeVariable> listVariable;
		public List<NodeAction> listAction;
		public List<NodeContext> listContext;

		public NodeContext()
		{
			Text = "Context: " + ( Caption == null ? "Default" : Caption );
			this.ContextMenuStrip = NodeContext.SharedMenu;
		}
	}

	public class NodeAction : NodeBase
	{
		public NodeContext contextParent;

		public virtual void Run()
		{
		}
	}

	public class NodeVariable : NodeBase
	{
		public NodeContext contextParent;

		public virtual void Clear()
		{
		}

		public virtual void Reload()
		{
		}
	}

	public class RunContext : NodeAction
	{
		public override void Run()
		{
			base.Run();
		}
	}
}
