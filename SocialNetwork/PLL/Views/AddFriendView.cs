using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class AddFriendView
    {
        UserService userService;
        public AddFriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            try
            {
                var NewFriendData = new AddFriendData();

                Console.WriteLine("Введите почтовый адрес пользователя, которого хотите добавить в друзья: ");

                NewFriendData.FriendEmail = Console.ReadLine();
                NewFriendData.UserId = user.Id;

                this.userService.AddFriend(NewFriendData);

                SuccessMessage.Show("Вы успешно добавили пользователя в друзья!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователя с указанным почтовым адресом не существует!");
            }
            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при добавлении пользователя в друзья!");
            }
        }
    }
}
