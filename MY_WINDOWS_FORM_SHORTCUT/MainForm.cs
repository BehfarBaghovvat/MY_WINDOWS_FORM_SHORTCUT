using System.Linq;

namespace MY_WINDOWS_FORM_SHORTCUT
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		//-------------------------------------------------------------------------------------------------- Field, Properties, Layers

		System.Windows.Forms.Button button = null;

		private string _idButton = null;

		//-------------------------------------------------------------------------------------------------- Constructure

		public MainForm()
		{
			InitializeComponent();
		}

		//-------------------------------------------------------------------------------------------------- Events Controls

		private void Form1_Load(object sender, System.EventArgs e)
		{
			GetListShortcuts();
		}

		private void form1ToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.ShowForm1(GetCapacityShortcut());
			

			if (Infrastructure.Utility.Form1.CheckShortcut)
			{
				CreatShortCut(Infrastructure.Utility.Form1.IdForm, Infrastructure.Utility.Form1.NameForm);
			}
			else
			{
				if (Infrastructure.Utility.Form1.DeleteShortcut)
				{
					Infrastructure.Utility.ManiForm.RemoveShortcut(Infrastructure.Utility.Form1.IdForm);
				}
				return;
			}
		}

		private void form2ToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.ShowForm2(GetCapacityShortcut());

			if (Infrastructure.Utility.Form2.CheckShortcut)
			{
				CreatShortCut(Infrastructure.Utility.Form2.IdForm, Infrastructure.Utility.Form2.NameForm);
			}
			else
			{
				return;
			}
		}

		private void form3ToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.ShowForm3(GetCapacityShortcut());

			if (Infrastructure.Utility.Form3.CheckShortcut)
			{
				CreatShortCut(Infrastructure.Utility.Form3.IdForm, Infrastructure.Utility.Form3.NameForm);
			}
			else
			{
				return;
			}
		}

		private void form4ToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.ShowForm4(GetCapacityShortcut());

			if (Infrastructure.Utility.Form4.CheckShortcut)
			{
				CreatShortCut(Infrastructure.Utility.Form4.IdForm, Infrastructure.Utility.Form4.NameForm);
			}
			else
			{
				return;
			}
		}

		private void form5ToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.ShowForm5(GetCapacityShortcut());

			if (Infrastructure.Utility.Form5.CheckShortcut)
			{
				CreatShortCut(Infrastructure.Utility.Form5.IdForm, Infrastructure.Utility.Form5.NameForm);
			}
			else
			{
				return;
			}
		}

		private void removeShortcutToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			RemoveShortcut(_idButton);
			
		}



		//-------------------------------------------------------------------------------------------------- Methods

		/// <summary>
		/// Create shortcuts for forms that need quick access.
		/// </summary>
		/// <param name="idForm"></param>
		/// <param name="nameForm"></param>
		public void CreatShortCut(string idForm, string nameForm)
		{
			if (string.IsNullOrWhiteSpace(nameForm))
			{
				return;
			}
			else
			{
				button = 
					new System.Windows.Forms.Button();

				button.Name = $"{idForm}Button";
				button.Text = nameForm;
				button.Size = new System.Drawing.Size(100, 30);
				button.TabIndex = 0;
				button.UseVisualStyleBackColor = true;
				button.ContextMenuStrip = contextMenuStrip;
				button.Click += Button_Click;
				button.MouseEnter += Button_MouseEnter;
				
				shortcutPanel.Controls.Add(button);
				
			}
		}

		private void Button_MouseEnter(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;

			_idButton = button.Name;
		}

		private void Button_Click(object sender, System.EventArgs e)
		{
			try
			{
				System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;

				string typeName = 
					button.Name.Replace("Button", string.Empty).Trim();

				var form =
					(System.Windows.Forms.Form)System.Activator.CreateInstance(System.Type.GetType("Side_Forms." + typeName));

				form.ShowDialog();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show($"{ex.Message}");
			}
		}

		/// <summary>
		/// Returns a list of created shortcuts.
		/// </summary>
		public void GetListShortcuts()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.ShortcutForms> listShortcutForms = null;

				listShortcutForms =
					dataBaseContext.ShortcutForms
					.ToList();

				if (listShortcutForms == null)
				{
					return;
				}
				else
				{

					foreach (var item in listShortcutForms)
					{
						CreatShortCut(item.ID_Form, item.Name_Form);
					}
				}
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show($"{ex.Message}");
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}

		/// <summary>
		/// Returns the amount of capacity to create shortcuts for us.
		/// </summary>
		/// <returns>int value</returns>
		public int GetCapacityShortcut()
		{
			int capacity = 0;
			int totalCapacity = 0;

			totalCapacity = this.Width / 100;

			capacity = totalCapacity - shortcutPanel.Controls.Count;

			return capacity;
		}

		/// <summary>
		/// Remove the shortcut made from the page.
		/// </summary>
		/// <param name="idForm"></param>
		public void RemoveShortcut(string idForm)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.ShortcutForms shortcutForms =
					dataBaseContext.ShortcutForms
					.Where(current => string.Compare(current.ID_Form, idForm.Replace("Button",string.Empty).Trim()) == 0)
					.FirstOrDefault();

				if (shortcutForms == null)
				{
					System.Windows.Forms.MessageBox.Show("There are no shortcuts on the page.");
					return;
				}
				else
				{
					string key = $"{idForm}";

					shortcutPanel.Controls[key].Dispose();

					dataBaseContext.ShortcutForms.Remove(shortcutForms);
					dataBaseContext.SaveChanges();

					System.Windows.Forms.MessageBox.Show("Remove Shortcut.");
				}

			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show($"{ex.Message}");
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}


















		

		
	}
}
