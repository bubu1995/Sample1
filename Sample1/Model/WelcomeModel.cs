using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1.Model
{
    public class WelcomeModel: ObservableObject
    {
        public WelcomeModel()
        {

        }

        private string welcomeMsg;
        public string WelcomeMsg
        {
            get { return welcomeMsg; }
            set { welcomeMsg = value; RaisePropertyChanged(() => WelcomeMsg); }
        }
    }
}
