using System.Collections.Generic;

namespace TiaFileViewer.Model
{
    public class TiaFile : BaseModel
    {
        private string _name;

        private Dictionary<string, List<TiaNode>> _tiaNodes;

        public TiaFile()
        {
            _tiaNodes = new Dictionary<string, List<TiaNode>>();
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public Dictionary<string, List<TiaNode>> TiaNodes
        {
            get => _tiaNodes;
            set
            {
                _tiaNodes = value;
                OnPropertyChanged();
            }
        }
    }
}