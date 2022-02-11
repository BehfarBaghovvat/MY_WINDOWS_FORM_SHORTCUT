namespace Models
{
    public class ListForms
    {
		public ListForms() : base()
		{

		}

		[System.ComponentModel.DataAnnotations.Key]
		public int Id
		{ 
			get; set;
		}

		public string ID_Form
		{
			get; set;
		}

		public string Name_Form
		{
			get; set;
		}
	}
}
