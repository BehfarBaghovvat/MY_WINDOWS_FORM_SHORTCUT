using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MY_WINDOWS_FORM_SHORTCUT
{
	internal static class Program
	{
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



		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
