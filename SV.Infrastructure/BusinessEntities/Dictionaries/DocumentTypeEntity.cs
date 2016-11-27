﻿using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace DataModel.Dictionaries
{
	public class DocumentTypeEntity : BaseDictionaryCouncilEntity
	{
		public string Code { get; set; }

		public virtual ICollection<DocumentEntity> Documents { get; set; }
	}
}