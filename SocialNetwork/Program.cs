using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL;
using SocialNetwork.PLL.Views;
using System;
using System.Linq;

namespace SocialNetwork
{
    class Program
    {
        static MessageService messageService;
        static UserService userService;
        public static MainView mainView;
        public static RegistrationView registrationView;
        public static AuthenticationView authenticationView;
        public static UserMenuView userMenuView;
        public static UserInfoView userInfoView;
        public static UserDataUpdateView userDataUpdateView;
        public static MessageSendingView messageSendingView;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserOutcomingMessageView userOutcomingMessageView;
        public static AddFriendView userAddFriendViewView;

        static void Main(string[] args)
        {
            userService = new ();
            messageService = new ();

            mainView = new ();
            registrationView = new (userService);
            authenticationView = new (userService);
            userMenuView = new (userService);
            userInfoView = new ();
            userDataUpdateView = new (userService);
            messageSendingView = new (messageService, userService);
            userIncomingMessageView = new ();
            userOutcomingMessageView = new ();
            userAddFriendViewView = new (userService);
            while (true)
            {
                mainView.Show();
            }
        }
    }
}
