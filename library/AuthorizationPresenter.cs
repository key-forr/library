using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    //Клас для реалізації основно логіки
    public class AuthorizationPresenter
    {
        private readonly AutorizationForm view;

        public AuthorizationPresenter(AutorizationForm view) 
        {
            this.view = view;
        }

        public void HandleLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                view.ShowError("Заповніть логін та пароль!");
                return;
            }

            DataBaseHelper dataBaseHelper = new DataBaseHelper();
            if (dataBaseHelper.CheckUser(username, password))
            {
                view.NavigateToHome();
            }
            else
            {
                view.ShowError("Не правильний логін або пароль!");
            }
        }


    }
}
