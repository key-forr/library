using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class AuthorizationPresenter
    {
        private readonly AutorizationForm view;

        public AuthorizationPresenter(AutorizationForm view) 
        {
            this.view = view;
        }

        public void HandleLogin(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                string errorMessage = string.IsNullOrEmpty(login) ? "Заповніть логін!" : "Заповніть пароль!";
                if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(password))
                    errorMessage = "Заповніть логін та пароль!";

                view.ShowError(errorMessage);
                return;
            }

            DataBaseHelper dataBaseHelper = new DataBaseHelper();
            if (dataBaseHelper.CheckUser(login, password))
            {
                UserSession.CurrentUserLogin = login;
                UserSession.UserId = dataBaseHelper.GetUserId(login);
                view.NavigateToHome();
            }
            else
            {
                view.ShowError("Неправильний логін або пароль!");
            }
        }
    }
}
