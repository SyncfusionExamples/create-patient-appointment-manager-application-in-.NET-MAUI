using Microsoft.Maui.Controls.Shapes;
using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManageAppointments
{
	public partial class PrifilePage : ContentPage
	{
		public PrifilePage()
		{
			InitializeComponent();
			this.dataForm.RegisterEditor("Image", new ImageEditor());
            dataForm.RegisterEditor("Country", DataFormEditorType.AutoComplete);
            this.dataForm.ItemsSourceProvider = new DataFormItemsSourceProvider();
            this.dataForm.RegisterEditor("Gender", DataFormEditorType.RadioGroup);
            this.dataForm.GenerateDataFormItem += DataForm_GenerateDataFormItem;

        }

        private void DataForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
        {
            if(e.DataFormItem != null) 
            {
                e.DataFormItem.Background = Color.FromHex("#F6F6F6");   
            }
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
            else if (sourceName == "Country")
            {
                List<string> countries = new List<string>
                {
                    "Afghanistan",
                    "Albania",
                    "Algeria",
                    "American Samoa",
                    "Andorra",
                    "Angola",
                    "Anguilla",
                    "Antarctica",
                    "Antigua and Barbuda",
                    "Argentina",
                    "Armenia",
                    "Aruba",
                    "Australia",
                    "Austria",
                    "Azerbaijan",
                    "Bahamas",
                    "Bahrain",
                    "Bangladesh",
                    "Barbados",
                    "Belarus",
                    "Belgium",
                    "Belize",
                    "Benin",
                    "Bermuda",
                    "Bhutan",
                    "Bolivia",
                    "Bosnia and Herzegovina",
                    "Botswana",
                    "Brazil",
                    "Brunei",
                    "Bulgaria",
                    "Burma",
                    "Burundi",
                    "Cambodia",
                    "Cameroon",
                    "Canada",
                    "Cape Verde",
                    "Cayman Islands",
                    "Central African Republic",
                    "Chad",
                    "Chile",
                    "China",
                    "Christmas Island",
                    "Cocos (Keeling) Islands",
                    "Colombia",
                    "Comoros",
                    "Congo",
                    "Cook Islands",
                    "Costa Rica",
                    "Cote d'Ivoire",
                    "Croatia",
                    "Cuba",
                    "Cyprus",
                    "Czech Republic",
                    "Denmark",
                    "Djibouti",
                    "Dominica",
                    "Dominican Republic",
                    "Ecuador",
                    "Egypt",
                    "El Salvador",
                    "Equatorial Guinea",
                    "Eritrea",
                    "Estonia",
                    "Ethiopia",
                    "Europa Island",
                    "Falkland Islands",
                    "Faroe Islands",
                    "Fiji",
                    "Finland",
                    "France",
                    "French Guiana",
                    "French Polynesia",
                    "French Southern Territories",
                    "Gabon",
                    "The Gambia",
                    "Gaza Strip",
                    "Georgia",
                    "Germany",
                    "Ghana",
                    "Gibraltar",
                    "Greece",
                    "Greenland",
                    "Grenada",
                    "Guadeloupe",
                    "Guam",
                    "Guatemala",
                    "Guernsey",
                    "Guinea",
                    "Guinea-Bissau",
                    "Guyana",
                    "Haiti",
                    "Holy See",
                    "Honduras",
                    "Hong Kong",
                    "Hungary",
                    "Iceland",
                    "India",
                    "Indonesia",
                    "Iran",
                    "Iraq",
                    "Ireland",
                    "Israel",
                    "Italy",
                    "Jamaica",
                    "Japan",
                    "Jordan",
                    "Kazakhstan",
                    "Kenya",
                    "Kiribati",
                    "Korea, North",
                    "Korea, South",
                    "Kuwait",
                    "Kyrgyzstan",
                    "Laos",
                    "Latvia",
                    "Lebanon",
                    "Lesotho",
                    "Liberia",
                    "Libya",
                    "Liechtenstein",
                    "Lithuania",
                    "Luxembourg",
                    "Macau",
                    "Madagascar",
                    "Malawi",
                    "Malaysia",
                    "Maldives",
                    "Mali",
                    "Malta",
                    "Marshall Islands",
                    "Martinique",
                    "Mauritania",
                    "Mauritius",
                    "Mayotte",
                    "Mexico",
                    "Micronesia",
                    "Moldova",
                    "Monaco",
                    "Mongolia",
                    "Montserrat",
                    "Morocco",
                    "Mozambique",
                    "Namibia",
                    "Nauru",
                    "Nepal",
                    "Netherlands",
                    "Netherlands Antilles",
                    "New Caledonia",
                    "New Zealand",
                    "Nicaragua",
                    "Niger",
                    "Nigeria",
                    "Niue",
                    "Norway",
                    "Oman",
                    "Pakistan",
                    "Palau",
                    "Panama",
                    "Papua New Guinea",
                    "Paracel Islands",
                    "Paraguay",
                    "Peru",
                    "Philippines",
                    "Pitcairn Islands",
                    "Poland",
                    "Portugal",
                    "Puerto Rico",
                    "Qatar",
                    "Romania",
                    "Russia",
                    "Rwanda",
                    "Saint Kitts and Nevis",
                    "Saint Lucia",
                    "Saint Vincent",
                    "Samoa",
                    "San Marino",
                    "Saudi Arabia",
                    "Senegal",
                    "Serbia",
                    "Seychelles",
                    "Sierra Leone",
                    "Singapore",
                    "Slovakia",
                    "Slovenia",
                    "Solomon Islands",
                    "Somalia",
                    "South Africa",
                    "South Georgia",
                    "Spain",
                    "Sri Lanka",
                    "Sudan",
                    "Suriname",
                    "Svalbard",
                    "Swaziland",
                    "Sweden",
                    "Switzerland",
                    "Syria",
                    "Taiwan",
                    "Tajikistan",
                    "Tanzania",
                    "Thailand",
                    "Timor-Leste",
                    "Togo",
                    "Tokelau",
                    "Tonga",
                    "Trinidad and Tobago",
                    "Tunisia",
                    "Turkey",
                    "Turkmenistan",
                    "Turks and Caicos Islands",
                    "Tuvalu",
                    "Uganda",
                    "Ukraine",
                    "United Arab Emirates",
                    "United Kingdom",
                    "United States",
                    "Uruguay",
                    "Uzbekistan",
                    "Vanuatu",
                    "Venezuela",
                    "Vietnam",
                    "Virgin Islands",
                    "Wallis and Futuna",
                    "West Bank",
                    "Western Sahara",
                    "Yemen",
                    "Zambia",
                    "Zimbabwe"
                };
                return countries;
            }
            return new List<string>();
        }
    }
}