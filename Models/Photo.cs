using System.Diagnostics.CodeAnalysis;

namespace TestTaskQulix.Models
{
    public class Photo
    {
        public int Id { get; set; }
        /// <summary>
        /// Название фото
        /// </summary>
        [AllowNull]
        public string PhotoName { get; set; }
        /// <summary>
        /// Ссылка на контент
        /// </summary>
        [AllowNull]
        public string ContentLink { get; set; }
        /// <summary>
        /// Размеры
        /// </summary>
        [AllowNull]
        public string PhotoSize { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        [AllowNull]
        public DateTime PhotoCreatedDate { get; set; }
        /// <summary>
        /// Автор фото
        /// </summary>
        [AllowNull]
        public Author? Author { get; set; }
        /// <summary>
        /// ID автора фото
        /// </summary>
        [AllowNull]
        public int AuthorId { get; set; }
        /// <summary>
        /// Стоимость
        /// </summary>
        [AllowNull]
        public double PhotoCost { get; set; }
        /// <summary>
        /// Количество покупок
        /// </summary>
        [AllowNull]
        public int PhotoNumberOfPurchase { get; set; }
        /// <summary>
        /// Рейтинг
        /// </summary>
        [AllowNull]
        public int PhotoRating { get; set; }

    }
}
