﻿using Microsoft.AspNetCore.Mvc;
using mypracticework.Domain;
using mypracticework.Repository;

namespace mypracticework.Controllers
{
    [ApiController]
    [Route("/Photo")]
    public class PhotoController : ControllerBase
    {
        [HttpPut]
        public Photo Create(Photo photo)
        {
            Storage.PhotoStorage.Create(photo);
            return photo;
        }

        [HttpGet]
        public Photo Read(int photoId)
        {
            return Storage.PhotoStorage.Read(photoId);
        }

        [HttpPost]
        public Photo Update(int photoId, Photo newPhoto)
        {
            return Storage.PhotoStorage.Update(photoId, newPhoto);
        }

        [HttpDelete]
        public bool Delete(int billId)
        {
            return Storage.PhotoStorage.Delete(photoId);
        }
    }

}
