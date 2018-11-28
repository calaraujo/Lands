namespace Lands.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Models;
    using Helpers;

    public class MainViewModel
    {
        #region Properties
        public List<Land> LandsList
        {
            get;
            set;
        }

        public TokenResponse Token
        {
            get;
            set;
        }

        public ObservableCollection<MenuItemViewModel> Menus;

        #endregion

        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }

        public LandsViewModel Lands
        {
            get;
            set;
        }

        public LandViewModel Land
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
            this.LoadMenu();
        }


        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
        #endregion

        #region Methods
        private void LoadMenu()
        {
            this.Menus = new ObservableCollection<MenuItemViewModel>();

            Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_action_settings.png",
                PageName = "MyProfilePage",
                Title = Languages.MyProfile,
            });

            Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_action_exit.png",
                PageName = "LoginPage",
                Title = Languages.Logout,
            });

            Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_action_insert_chart.png",
                PageName = "StatisticsPage",
                Title = Languages.Statistics,
            });

        }
        #endregion
    }
}