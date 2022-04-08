using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_Ricciotti.ClassiFinestre.ViewModel
{
    internal class CurrPage: Osservazione
    {
        public Comando HomeView { get; set; }

        public Comando PaneView { get; set; }

        public Comando HamburgerView { get; set; }

        public Comando FormaggioView { get; set; }

        public Comando SalsaView { get; set; }

        public Comando ContoView { get; set; }    

        public MainPage Home { get; set; }

        public PanePage Pane { get; set; }

        public HamburgerPage Hamburger { get; set; }

        public FormaggioPage Formaggio { get; set; }

        public SalsaPage Salsa { get; set; }    

        public ContoPage Conto { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView= value;
                OnPropertyChanged();
            }
        }


        public CurrPage()
        {
            Home = new MainPage();
            Pane= new PanePage();
            Hamburger= new HamburgerPage();
            Formaggio= new FormaggioPage();
            Salsa= new SalsaPage();
            Conto=new ContoPage();

            CurrentView = Home;

            HomeView = new Comando(o =>{ CurrentView = Home;});
            PaneView = new Comando(o =>{ CurrentView = Pane;});
            HamburgerView=new Comando(o => { CurrentView = Hamburger;});
            FormaggioView = new Comando(o => { CurrentView = Formaggio; });
            SalsaView = new Comando(o => { CurrentView = Salsa; });
            ContoView=new Comando(o=> { CurrentView = Conto; });


        }
    }

}
