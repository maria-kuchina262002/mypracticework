using mypracticework.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace mypracticework.Repository
{
    public class Photo
    {
        public class PhotoStorage
        {
            private Dictionary<int, Photo> Photoes { get; } = new Dictionary<int, Photo>();

            public void Create(Photo photo)
            {
                Photoes.Add(photo.PhotoId, photo);
            }

            public Photo Read(int photoId)
            {
                return Photoes[photoId];
            }

            public Photo Update(int photoId, Photo newPhoto)
            {
                Photoes[photoId] = newPhoto;
                return Photoes[photoId];
            }

            public bool Delete(int photoId)
            {
                return Photoes.Remove(photoId);
            }

        }
    }
}
