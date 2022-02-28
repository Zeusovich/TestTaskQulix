using System.Diagnostics.CodeAnalysis;

namespace TestTaskQulix.Models
{
    public class Author
    {
        public int Id { get; set; }
        /// <summary>
        /// Имя автора
        /// </summary>
        [AllowNull]
        public string AuthorName { get; set; }
        /// <summary>
        /// Никнейм автора
        /// </summary>
        [AllowNull]
        public string Nickname { get; set; }
        /// <summary>
        /// Возраст автора
        /// </summary>
        [AllowNull]
        public int Age { get; set; }
        /// <summary>
        /// Дата создания аккаунта
        /// </summary>
        [AllowNull]
        public DateTime DateOfAccCreation { get; set; }

    }
}
