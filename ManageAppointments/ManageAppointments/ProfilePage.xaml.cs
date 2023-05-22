using Microsoft.Maui.Controls.Shapes;
using Syncfusion.Maui.DataForm;

namespace ManageAppointments
{
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage()
		{
			InitializeComponent();
			this.dataForm.RegisterEditor("Image", new ImageEditor());
            this.dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
            this.dataForm.RegisterEditor("Gender", DataFormEditorType.RadioGroup);
        }
    }

    public class ImageEditor : IDataFormEditor
    {
        public void CommitValue(DataFormItem dataFormItem, View view)
        {
        }

        public View CreateEditorView(DataFormItem dataFormItem)
        {
            Image image = new Image();
            image.Source = "profile.png";
            image.HeightRequest = 150;  
            image.HorizontalOptions = LayoutOptions.Center;
            return image;   
        }

        public void UpdateReadyOnly(DataFormItem dataFormItem)
        {
        }
    }

    public class DataFormItemsSourceProvider : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "Gender")
            {
                List<string> list = new List<string>() { "Male", "Female" };
                return list;
            }
            return new List<string>();
        }
    }
}