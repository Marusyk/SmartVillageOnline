﻿using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class EducationDegreeEntity : BaseDictionaryEntity
	{
		public virtual ICollection<EducationEntity> Educations { get; set; }
	}
}
