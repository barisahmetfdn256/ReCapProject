using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            if (color.ColorName.Length <4)
            {
                return new  ErrorResult(Messages.InvalidColor);
            }
            return new Result(true , Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            if (color.ColorName.Length < 4)
            {
                return new ErrorResult(Messages.InvalidColor);
            }
            return new Result(true, Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>();    
        }

        public IDataResult<List<Color>> GetByColor(string color)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(co=>co.ColorName == color));
        }

        public IDataResult<Color> GetById(int İd)
        {
            return new SuccessDataResult<Color>(_colorDal.Get());
        }

        public IResult Update(Color color)
        {
           if (color.ColorName.Length < 4)
            {
                return new ErrorResult(Messages.InvalidColor);
            }
            return new Result(true, Messages.ColorAdded);
        }
    }
}
