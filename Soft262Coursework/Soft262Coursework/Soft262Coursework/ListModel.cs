using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Soft262Coursework
{
    public class ListModel : INotifyPropertyChanged
    {
        private string filename;
        private string titles;
        private string descs;
        public event PropertyChangedEventHandler PropertyChanged;

        public string FileName { get => filename; set => filename = value; }

        public string Title
        {
            get => titles;
            set
            {
                if (titles != value)
                {
                    titles = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Description
        {
            get => descs;
            set
            {
                if (descs != value)
                {
                    descs = value;
                    OnPropertyChanged();
                }
            }
        }

        //Create events when properties change
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Default constructor
        public ListModel()
        {
            Title = "Title 1";
            Description = "Desc 1";
            //Title[0] = "Title 1";
            //Description[0] = "Desc 1";

            //Title[1] = "Title 2";
            //Description[1] = "Desc 2";

            //Title[2] = "Title 3";
            //Description[2] = "Desc 3";

            //Title[3] = "Title 4";
            //Description[4] = "Desc 4";
        }
        public ListModel(string n = "Title 1", string y = "Desc 1")
        {
            Title = n;
            Description = y;
        }

        //Copy Constructor
        public ListModel(ListModel m)
        {
            Description = m.Description;
            Title = m.Title;
        }

        //Copy instance-method
        public ListModel Copy() => new ListModel(Title, Description);

        //Copy - static method
        public static ListModel Copy(ListModel m) => new ListModel(m.Title, m.Description);

        //Serialise this instance to an XML file
        public void Save()
        {
            if (FileName != null)
            {
                Save(FileName);
            }
            else
            {
                throw new Exception("No filename set");
            }
        }

        public void Save(string fn)
        {
            this.FileName = fn;
            using (var writer = new System.IO.StreamWriter(fn))
            {
                var serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(writer, this);
                writer.Flush();
            }
        }

        //Deserialise an XML file to a new instance of this type
        public static ListModel Load(string fn)
        {
            try
            {
                using (FileStream stream = File.OpenRead(fn))
                {
                    var serializer = new XmlSerializer(typeof(ListModel));
                    ListModel m = serializer.Deserialize(stream) as ListModel;
                    return m;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }



    }
}
