using Microsoft.EntityFrameworkCore;
using TestTaskQulix.Context;
using TestTaskQulix.Interfaces;
using TestTaskQulix.Models;

namespace TestTaskQulix.Services
{
    public class DataService : IDataService
    {
        private readonly DataContext _dataContext;
        public DataService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }
        /// <summary>
        /// Метод возвращает контент сущности Текст
        /// </summary>
        /// <returns> IEnumerable<Text></returns>
        public async Task<IEnumerable<Text>> GetText() => await _dataContext.Texts.ToListAsync();

        /// <summary>
        /// Добавляет новый экземпляр текста в контент Текст
        /// </summary>
        /// <param name="text"> Свойства Текста </param>
        /// <returns> Добавляет в бд новый экземпляр</returns>
        public async Task AddText(Text text)
        {
            if (text != null)
            {
                await _dataContext.Texts.AddAsync(text);
                _dataContext.SaveChanges();
            }
        }

        /// <summary>
        /// Получение всех сущностей в один список
        /// </summary>
        /// <returns></returns>
        public object GetAllModels()
        {
            var content = from author in _dataContext.Authors
                        join photo in _dataContext.Photos on author.Id equals photo.AuthorId
                        join text in _dataContext.Texts on author.Id equals text.AuthorId
                        select new
                        {
                            AuthorName = author.AuthorName,
                            Nickname = author.Nickname,
                            Age = author.Age,
                            DateOfAccCreation = author.DateOfAccCreation,
                            PhotoName = photo.PhotoName,
                            ContentLink = photo.ContentLink,
                            PhotoSize = photo.PhotoSize,
                            PhotoCreatedDate = photo.PhotoCreatedDate,
                            PhotoCost = photo.PhotoCost,
                            PhotoNumberOfPurchase = photo.PhotoNumberOfPurchase,
                            PhotoRating = photo.PhotoRating,
                            TextName = text.TextName,
                            TextContent = text.TextContent,
                            TextSize = text.TextSize,
                            TextCreateDate = text.TextCreateDate,
                            TextCost = text.TextCost,
                            TextNumberOfPurches = text.TextNumberOfPurches,
                        };
            return content;
        }
        /// <summary>
        /// Получение всех контент сущностей Фотография
        /// </summary>
        /// <returns> IEnumerable<Photo> </returns>
        public async Task<IEnumerable<Photo>> GetAllPhotos() => await _dataContext.Photos.ToListAsync();

        /// <summary>
        /// Получение по идентификатору контент сущность Фотография
        /// </summary>
        /// <param name="id"> id Фотографии </param>
        /// <returns> Фотография </returns>
        public async Task<Photo> GetPhotoById(int id)
        {
            
            var photo = await _dataContext.Photos.Where(p => p.Id == id).SingleOrDefaultAsync();
            if (photo == null)
            {
                throw new ArgumentNullException($"Contact with id {photo.Id} not found");
            };
            return photo;

        }
        /// <summary>
        /// Проставление оценки для контент сущности Фотография
        /// </summary>
        /// <param name="id"></param>
        /// <param name="rating"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<Photo> SendRating(Photo photo)
        {
            var newPhoto = await _dataContext.Photos.Where(o => o.Id == photo.Id).SingleOrDefaultAsync();
            if (photo == null)
            {
                throw new ArgumentNullException($"Contact with id {photo.Id} not found");
            };
            newPhoto.PhotoRating = photo.PhotoRating;

            _dataContext.SaveChanges();
            return newPhoto;
        }

        /// <summary>
        /// Измненение контент сущности фотография
        /// </summary>
        /// <param name="id"> id изменяемой фотографии </param>
        /// <param name="photo"> свойства новой фотографии </param>
        /// <returns> Измененное фото </returns>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<Photo> UpdatePhoto(Photo photo)
        {
            var newPhoto = await _dataContext.Photos.Where(o => o.Id == photo.Id).SingleOrDefaultAsync();
            if (newPhoto == null)
            {
                throw new ArgumentNullException($"Contact with id {newPhoto.Id} not found");
            };
            newPhoto.PhotoName = photo.PhotoName;
            newPhoto.ContentLink = photo.ContentLink;
            newPhoto.PhotoSize = photo.PhotoSize;
            newPhoto.PhotoCreatedDate = photo.PhotoCreatedDate;
            newPhoto.AuthorId = photo.AuthorId;
            newPhoto.PhotoCost = photo.PhotoCost;
            newPhoto.PhotoNumberOfPurchase = photo.PhotoNumberOfPurchase;
            newPhoto.PhotoRating = photo.PhotoRating;

            _dataContext.SaveChanges();
            return photo;
        }
    }
}
