using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_INIS4_PR2._2_z4
{
    class Model
    {

        /*Prawdopodobnie brakuje jawnego pola z listą, właściwości jawnie zaimplementowanej i notyfikacji o zmianie*/
        public ObservableCollection<Album> Lista { get; set; } = new ObservableCollection<Album>(new Album[] {
            new Album() {
                _Tytuł = "Majtrix",
                _Wydawca = "Wiśniewski",
                _Nosnik = "CD",
                _Długość = "128minut",
                _Reżyser_autor = "Iluminaci"
            },
            new Album() {
                  _Tytuł = "GimmeOneMoreTime",
                _Wydawca = "JorgeBush",
                _Nosnik = "DVD",
                _Długość = "60minut",
                _Reżyser_autor = "BritnejSpirs"
            },
            new Album() {
                _Tytuł = "LordOfTheRins",
                _Wydawca = "WarnerBrothers",
                _Nosnik = "CD",
                _Długość = "228minut",
                _Reżyser_autor = "TomHanks"
            },

        });

        internal void OtwórzSzczegóły(Album wybrany)
        {
            Szczegóły szczegóły = new Szczegóły(wybrany);
            szczegóły.Show();
        }
        internal void DodajNowy()
        {
            Album nowa = new Album();
            Lista.Add(nowa);
            Szczegóły szczegóły = new Szczegóły(nowa);
            szczegóły.Show();
            /*aktualizowanie widoku samej listy*/
        }
    }
}
