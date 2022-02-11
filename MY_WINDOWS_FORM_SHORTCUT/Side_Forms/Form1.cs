using System.Linq;

namespace Side_Forms
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		//-------------------------------------------------------------------------------------------------- Field, Properties, Layers

		private static MY_WINDOWS_FORM_SHORTCUT.MainForm _mainForm;
		public static MY_WINDOWS_FORM_SHORTCUT.MainForm MainForm
		{
			get
			{
				if (_mainForm == null || _mainForm.IsDisposed == true)
				{
					_mainForm =
						new MY_WINDOWS_FORM_SHORTCUT.MainForm();
				}
				return _mainForm;
			}
			set
			{
				_mainForm = value;
			}
		}

		private int _capacityRemaning;
		public int CapacityRemaning
		{
			get
			{
				return _capacityRemaning;
			}
			set
			{
				_capacityRemaning = value;
			}
		}

		public string IdForm
		{
			get; set;
		}

		public string NameForm
		{
			get; set;
		}

		public bool CheckShortcut
		{
			get; set;
		}

		public bool DeleteShortcut
		{
			get; set;
		}

		public Form1()
		{
			InitializeComponent();

			IdForm = this.Name;
			NameForm = this.Text;
		}

		//-------------------------------------------------------------------------------------------------- Events Controls

		private void Form1_Load(object sender, System.EventArgs e)
		{
			if (Infrastructure.Utility.CheckShorcut(IdForm))
			{
				addShortcutToolStripMenuItem.Visible = false;
				removeShortcutToolStripMenuItem.Visible = true;
			}
			else
			{
				addShortcutToolStripMenuItem.Visible = true;
				removeShortcutToolStripMenuItem.Visible = false;
			}
		}

		private void addShortcutToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (_capacityRemaning <= 0)
			{
				System.Windows.Forms.MessageBox.Show("Shortcut build capacity is complete");
				
			}
			else
			{
				CheckShortcut = true;
				Infrastructure.Utility.CreatShortcut(IdForm, NameForm, CheckShortcut);

				this.Close();
			}
		}

		private void removeShortcutToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			CheckShortcut = false;
			DeleteShortcut = true;

			//Infrastructure.Utility.ManiForm.RemoveShortcut(IdForm);
			this.Close();
		}


		//-------------------------------------------------------------------------------------------------- Methods




	}
}
