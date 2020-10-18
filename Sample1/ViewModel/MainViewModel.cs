using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Sample1.Model;

namespace Sample1.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            ///
            WelcomeModel = new WelcomeModel() { WelcomeMsg = "Welcome to MVVMLight World!" };
        }


        private WelcomeModel welcomeModel;
        public WelcomeModel WelcomeModel
        {
            get { return welcomeModel; }
            set { welcomeModel = value; RaisePropertyChanged(() => WelcomeModel); }
        }


        private string userList = "Mary";

        public string UserList
        {
            get { return userList; }
            set
            {
                userList = value;
                RaisePropertyChanged();
            }
        }
        private string user = "";

        public string User
        {
            get { return user; }
            set { 
                user = value;
                RaisePropertyChanged();
            }
        }
        private bool isCanAddUser;

        public bool IsCanAddUser
        {
            get { return isCanAddUser; }
            set { 
                isCanAddUser = value;
                RaisePropertyChanged();
            }
        }

        #region Command
        private RelayCommand addUserCommand;

        public RelayCommand AddUserCommand
        {
            get
            {
                if (addUserCommand == null)
                {
                    addUserCommand = new RelayCommand(AddUser, () => { return true; });
                }
                return addUserCommand;
            }
            set { 
                addUserCommand = value;
                RaisePropertyChanged();
            }
        }
        private void AddUser()
        {
            UserList = UserList + "  " + User;
        }
        #endregion
    }
}