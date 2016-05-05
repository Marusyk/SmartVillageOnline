using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Dictionaries;
using DataModel.Entities.Dictionaries;
using DataModel.UnitOfWork;
using AutoMapper;
using Infrastructure.Interfaces;

namespace Infrastructure
{
    public class AnimalService : BaseServices<AnimalEntity, Animal>
    {
        public AnimalService(UnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }        
    }
}
