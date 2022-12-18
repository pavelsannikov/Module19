using NUnit.Framework;

using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
namespace SocialNetwork.Tests
{
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// Проверка на добавление в БД нового пользователя, поиск по email и удаление
        /// </summary>
        [Test]
        public void AddingAndDeletingUser()
        {
            IUserRepository userRepository = new UserRepository();
            var DummyUserEntity = new UserEntity()
            {
                firstname = "dummy_firstname",
                lastname = "dummy_lastname",
                password = "dummy_password",
                email = "dummy_email"
            };
            Assert.False(userRepository.Create(DummyUserEntity) == 0);
            DummyUserEntity = userRepository.FindByEmail("dummy_email");
            Assert.True(DummyUserEntity != null);
            Assert.False(userRepository.DeleteById(DummyUserEntity.id) == 0);
        }
    }
}