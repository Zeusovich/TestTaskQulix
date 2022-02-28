using System.Diagnostics.CodeAnalysis;

namespace TestTaskQulix.Models
{
    public class Text
    {
        public int Id { get; set; }
        /// <summary>
        /// Название текста
        /// </summary>
        [AllowNull]
        public string TextName { get; set; }
        /// <summary>
        /// Контент текста
        /// </summary>
        [AllowNull]
        public string TextContent { get; set; }
        /// <summary>
        /// Размеры
        /// </summary>
        [AllowNull]
        public string TextSize { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        [AllowNull]
        public DateTime TextCreateDate { get; set; }
        /// <summary>
        /// СТоимость
        /// </summary>
        [AllowNull]
        public double TextCost { get; set; }
        /// <summary>
        /// Автор текста
        /// </summary>
        [AllowNull]
        public Author? Author { get; set; }
        /// <summary>
        /// ID автора текста
        /// </summary>
        [AllowNull]
        public int AuthorId { get; set; }
        /// <summary>
        /// Количество покупок
        /// </summary>
        [AllowNull]
        public int TextNumberOfPurches { get; set; }
    }
}
