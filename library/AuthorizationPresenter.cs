using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class AuthorizationPresenter
    {
        private readonly AutorizationForm autorizationForm;

        public AuthorizationPresenter(AutorizationForm autorizationForm) 
        {
            this.autorizationForm = autorizationForm;
        }

        public void HandleLogin(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                string errorMessage = string.IsNullOrEmpty(login) ? "Заповніть логін!" : "Заповніть пароль!";
                if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(password))
                    errorMessage = "Заповніть логін та пароль!";

                autorizationForm.ShowError(errorMessage);
                return;
            }

            DataBaseHelper dataBaseHelper = new DataBaseHelper();
            if (dataBaseHelper.CheckUser(login, password))
            {
                UserSession.Login = login;
                dataBaseHelper.GetUserData(login);
                autorizationForm.NavigateToHome();
            }
            else
            {
                autorizationForm.ShowError("Неправильний логін або пароль!");
            }
        }
    }
}
