using System.Linq;

namespace Infrastructure
{
	public class Utility
	{
		//-------------------------------------------------------------------------------------------------- Field, Properties, Layers

		private static MY_WINDOWS_FORM_SHORTCUT.MainForm _maniForm;
		public static MY_WINDOWS_FORM_SHORTCUT.MainForm ManiForm
		{
			get
			{
				if (_maniForm == null || _maniForm.IsDisposed == true)
				{
					_maniForm =
						new MY_WINDOWS_FORM_SHORTCUT.MainForm();
				}
				return _maniForm;
			}
			set
			{
				_maniForm = value;
			}
		}


		private static Side_Forms.Form1 _myForm1;
		public static Side_Forms.Form1 Form1
		{
			get
			{
				if (_myForm1 == null || _myForm1.IsDisposed == true)
				{
					_myForm1 =
						new Side_Forms.Form1();
				}
				return _myForm1;
			}
			set
			{
				_myForm1 = value;
			}
		}

		private static Side_Forms.Form2 _myForm2;
		public static Side_Forms.Form2 Form2
		{
			get
			{
				if (_myForm2 == null || _myForm2.IsDisposed == true)
				{
					_myForm2 =
						new Side_Forms.Form2();
				}
				return _myForm2;
			}
			set
			{
				_myForm2 = value;
			}
		}

		private static Side_Forms.Form3 _myForm3;
		public static Side_Forms.Form3 Form3
		{
			get
			{
				if (_myForm3 == null || _myForm3.IsDisposed == true)
				{
					_myForm3 =
						new Side_Forms.Form3();
				}
				return _myForm3;
			}
			set
			{
				_myForm3 = value;
			}
		}

		private static Side_Forms.Form4 _myForm4;
		public static Side_Forms.Form4 Form4
		{
			get
			{
				if (_myForm4 == null || _myForm4.IsDisposed == true)
				{
					_myForm4 =
						new Side_Forms.Form4();
				}
				return _myForm4;
			}
			set
			{
				_myForm4 = value;
			}
		}

		private static Side_Forms.Form5 _myForm5;
		public static Side_Forms.Form5 Form5
		{
			get
			{
				if (_myForm5 == null || _myForm5.IsDisposed == true)
				{
					_myForm5 =
						new Side_Forms.Form5();
				}
				return _myForm5;
			}
			set
			{
				_myForm5 = value;
			}
		}





		//-------------------------------------------------------------------------------------------------- Constructure
		public Utility()
		{

		}


		//-------------------------------------------------------------------------------------------------- Methods


		/// <summary>
		/// Returns the status of creating a shortcut for a form.
		/// </summary>
		/// <param name="idForm"></param>
		/// <returns>true Or false</returns>
		public static bool CheckShorcut(string idForm)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.ShortcutForms shortcutForms =
					dataBaseContext.ShortcutForms
					.Where(current => string.Compare(current.ID_Form, idForm) == 0)
					.FirstOrDefault();

				if (shortcutForms != null)
				{
					return shortcutForms.CheckShortcut;
				}
				else
				{
					return false;
				}
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show($"{ex.Message}");
				return false;
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
		/// Add to list tabel 'Shortcut Form' for create shorcut. 
		/// </summary>
		/// <param name="idForm"></param>
		/// <param name="nameForm"></param>
		public static void CreatShortcut(string idForm, string nameForm, bool checkShortcut)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.ShortcutForms shortcutForms =
					dataBaseContext.ShortcutForms
					.Where(current => string.Compare(current.ID_Form, idForm) == 0)
					.FirstOrDefault();

				if (shortcutForms == null)
				{
					shortcutForms =
						new Models.ShortcutForms()
						{
							ID_Form = idForm,
							Name_Form = nameForm,
							CheckShortcut = checkShortcut,
						};

					dataBaseContext.ShortcutForms.Add(shortcutForms);
					dataBaseContext.SaveChanges();

					System.Windows.Forms.MessageBox.Show($"Shortcut created.");
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
		/// Save current form to table ListForm.
		/// </summary>
		/// <param name="idForm"></param>
		/// <param name="nameForm"></param>
		public static void SaveFormToList(string idForm, string nameForm)
		{
			#region Validation
			if (string.IsNullOrWhiteSpace(nameForm))
			{
				System.Windows.Forms.MessageBox.Show("Please enter name for 'Name Form'");
				return;
			}
			#endregion /Validation

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.ListForms listForms =
					dataBaseContext.ListForms
					.Where(current => string.Compare(current.ID_Form, idForm) == 0)
					.FirstOrDefault();

				if (listForms == null)
				{
					listForms =
						new Models.ListForms()
						{
							ID_Form = idForm,
							Name_Form = nameForm,
						};

					dataBaseContext.ListForms.Add(listForms);
					dataBaseContext.SaveChanges();
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


		public static void ShowForm1(int capacityRemaning)
		{
			Form1.CapacityRemaning = capacityRemaning;
			Form1.ShowDialog();
		}


		public static void ShowForm2(int capacityRemaning)
		{
			Form2.CapacityRemaning = capacityRemaning;

			Form2.CheckShortcut = false;

			Form2.ShowDialog();
		}


		public static void ShowForm3(int capacityRemaning)
		{
			Form3.CapacityRemaning = capacityRemaning;

			Form3.CheckShortcut = false;

			Form3.ShowDialog();
		}

		public static void ShowForm4(int capacityRemaning)
		{
			Form4.CapacityRemaning = capacityRemaning;

			Form4.CheckShortcut = false;

			Form4.ShowDialog();
		}

		public static void ShowForm5(int capacityRemaning)
		{
			Form5.CapacityRemaning = capacityRemaning;

			Form5.CheckShortcut = false;

			Form5.ShowDialog();
		}


	}
}
