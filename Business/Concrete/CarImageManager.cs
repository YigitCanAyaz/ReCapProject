using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation.CarImageValidator;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal, IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        [SecuredOperation("user, admin")]
        [ValidationAspect(typeof(AddCarImageValidator))]
        [CacheRemoveAspect("ICarImageService.Get")]
        public IResult Add(IFormFile file, CarImage carImage)
        {
            var carImageResult = AddCarImage(file);

            IResult result = BusinessRoles.Run(CheckIfCarImageCountOfCarCorrect(carImage.CarId), carImageResult);

            if (result != null)
            {
                return result;
            }

            carImage.ImagePath = carImageResult.Message;

            carImage.Date = DateTime.Now;

            _carImageDal.Add(carImage);

            return new SuccessResult(Messages.CarImageAdded);
        }

        [SecuredOperation("user, admin")]
        [ValidationAspect(typeof(DeleteCarImageValidator))]
        [CacheRemoveAspect("ICarImageService.Get")]
        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);

            return new SuccessResult(Messages.CarImageDeleted);
        }

        [CacheAspect]
        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarImagesListed);
        }

        [CacheAspect]
        public IDataResult<List<CarImage>> GetAllByCarId(int carId)
        {
            IResult result = BusinessRoles.Run(CheckIfCarHasAPhoto(carId));

            if (result != null)
            {
                return new SuccessDataResult<List<CarImage>>(ShowDefaultPhoto(carId), Messages.CarImagesListed);
            }

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId), Messages.CarImagesListed);
        }

        [CacheAspect]
        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == id), Messages.CarImageGetById);
        }

        [SecuredOperation("user, admin")]
        [ValidationAspect(typeof(UpdateCarImageValidator))]
        [CacheRemoveAspect("ICarImageService.Get")]
        public IResult Update(IFormFile file, CarImage carImage)
        {
            var carImageResult = AddCarImage(file);

            IResult result = BusinessRoles.Run(CheckIfCarIdIsSame(carImage), carImageResult);

            if (result != null)
            {
                return result;
            }

            carImage.ImagePath = carImageResult.Message;

            carImage.Date = DateTime.Now;

            _carImageDal.Update(carImage);

            return new SuccessResult(Messages.CarImageUpdated);
        }

        private IResult CheckIfCarImageCountOfCarCorrect(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;

            if (result >= 5)
            {
                return new ErrorResult(Messages.CarImageCountOfCarError);
            }

            return new SuccessResult();
        }

        private IResult CheckIfCarHasAPhoto(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Any();

            if (result)
            {
                return new SuccessResult();
            }

            return new ErrorResult();

        }

        private IResult CheckIfCarIdIsSame(CarImage carImage)
        {
            var result = _carImageDal.Get(c => c.Id == carImage.Id);

            if (result.CarId == carImage.CarId)
            {
                return new SuccessResult();
            }

            return new ErrorResult(Messages.CarIdIsNotSame);
        }

        private List<CarImage> ShowDefaultPhoto(int carId)
        {
            List<CarImage> carImages = new List<CarImage>();

            carImages.Add(new CarImage { CarId = carId, ImagePath = @"/Images/default.png" });

            return carImages;
        }

        private IResult AddCarImage(IFormFile file)
        {
            var carImageResult = _fileHelper.Upload(file);

            if (!carImageResult.Success)
            {
                return new ErrorResult(carImageResult.Message);
            }

            return new SuccessResult(carImageResult.Message);
        }
    }
}
