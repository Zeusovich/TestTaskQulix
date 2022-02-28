using TestTaskQulix.Models;

namespace TestTaskQulix.Interfaces
{
    public interface IDataService 
    {
        Task<IEnumerable<Photo>> GetAllPhotos();
        object GetAllModels();        
        Task<Photo> GetPhotoById(int id);
        Task<Photo> UpdatePhoto(Photo photo);
        Task<Photo> SendRating(Photo photo);
        Task<IEnumerable<Text>> GetText();
        Task AddText(Text text);


    }
}
