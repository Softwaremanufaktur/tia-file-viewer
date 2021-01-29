namespace TiaFileViewer.Model
{
    public class TiaProperty : BaseModel
    {
        private string _key;

        private string _value;

        public string Key
        {
            get => _key;
            set
            {
                _key = value;
                OnPropertyChanged();
            }
        }

        public string Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged();
            }
        }
    }
}