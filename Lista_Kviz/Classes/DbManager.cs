using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Kviz.Manager
{
    internal class DbManager
    {
        Adatbazis AB = new Adatbazis();
        public void ABmentesHandler(String Tablanev)
        {
            AB.SaveChanges();
        }
        public DbManager()
        {
            Kerdesszerkeszto KS = new Kerdesszerkeszto();
            KS.MentesEsemeny += this.ABmentesHandler;

            FormFelhasznalok FF = new FormFelhasznalok();
            FF.MentesEsemeny += this.ABmentesHandler;

            Register_Screen RS = new Register_Screen();
            RS.MentesEsemeny += this.ABmentesHandler;

            Temavalaszto TV = new Temavalaszto();
            TV.MentesEsemeny += this.ABmentesHandler;
        }
    }
}
