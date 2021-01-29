using System;
using System.Collections.Generic;
using System.Linq;

namespace TiaFileViewer.Model
{
    public class TiaNode : BaseModel
    {
        private List<TiaProperty> _tiaProperties;

        private string _type;

        public TiaNode()
        {
            _tiaProperties = new List<TiaProperty>();
        }

        public string Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get
            {
                var nameProperty =
                    _tiaProperties.FirstOrDefault(p => p.Key.Equals("name", StringComparison.OrdinalIgnoreCase));
                if (nameProperty == null)
                {
                    var idProperty =
                        _tiaProperties.FirstOrDefault(p => p.Key.Equals("id", StringComparison.OrdinalIgnoreCase));
                    if (idProperty == null) return "N/A";

                    return idProperty.Value;
                }

                return nameProperty.Value;
            }
        }

        public List<TiaProperty> TiaProperties
        {
            get => _tiaProperties;
            set
            {
                _tiaProperties = value;
                OnPropertyChanged();
            }
        }
    }
}