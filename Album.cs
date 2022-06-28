using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NET_INIS4_PR2._2_z4
{
    public class Album : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly static Dictionary<string, string[]> relatedProperties = new Dictionary<string, string[]>()
        {
            ["Tytuł"] = new string[] { "Tytuł", "FormatListy" },
            ["Wydawca"] = new string[] { "Wydawca", "FormatListy" },
            ["Nośnik"] = new string[] { "Nośnik", "FormatListy" },
            ["Długość"] = new string[] { "Długość", "FormatListy" },
            ["Reżyser_autor"] = new string[] { "Reżyser_autor", "FormatListy" }
        };
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            if(relatedProperties.ContainsKey(propertyName))
                foreach(string relatedProperty in relatedProperties[propertyName])
                    OnPropertyChanged(relatedProperty);
            //śledzenie zapobiegające stack overflow?
        }

        static uint następneID = 0;
        /*uint wiek = 0;*/
        string
            Tytuł,
            Wydawca,
            Nośnik,
            Długość
            ;
        string
            Reżyser_autor = null
            ;
 

        public string _Tytuł {
            get => Tytuł;
            set
            {
                Tytuł = value;
                OnPropertyChanged();
            }
        }
        public string _Wydawca {
            get => Wydawca;
            set
            {
                Wydawca = value;
                OnPropertyChanged();
            }
        }
        public string _Nosnik
        {
            get => Nośnik;
            set
            {
                Nośnik = value;
                OnPropertyChanged();
            }
        }
        public string _Długość {
            get => Długość;
            set
            {
                Długość = value;
                OnPropertyChanged();
            }
        }
        public string _Reżyser_autor
        {
            get => Reżyser_autor;
            set
            {
                Reżyser_autor = value;
                OnPropertyChanged();
            }
        }
        public string FormatListy { get => $"{Tytuł},{Wydawca},{Nośnik},{Długość}, {Reżyser_autor}"; } 
   
        public uint ID { get; } = następneID++;
        public string FormatID { get => "ID: " + ID; }
    }
}
