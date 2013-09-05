using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Xml.Serialization;
using Apex.Common.Data;
using HCMIS.Extensions.Repository;
using Ninject;

namespace HCMIS.Extensions.Business
{
    public class BusinessRuleWrapper : IBusinessRuleWrapper<List<Guid>>
    {
        #region Fields
        private readonly IUnitOfWork _unitOfWork;
        private readonly BusinessRuleRepository _repository;
        #endregion

        #region Constructors
        public BusinessRuleWrapper()
        {
            _unitOfWork = new BusinessRuleEntities();
            _repository = new BusinessRuleRepository(_unitOfWork);
        }
        #endregion

        #region IBusinessRuleWrapper Members
        /// <summary>
        /// Gets Guids from the specified business rule. Throws Exception if 
        /// </summary>
        /// <param name="businessRuleID">Business rule identifier</param>
        /// <returns>List of rowguids of the entities in the business rule result set</returns>
        public List<Guid> Get(string businessRuleID)
        {
            var businessRule = _repository.FindSingle(m => m.BusinessRuleID == businessRuleID);
            if(businessRule == null)
                throw new ObjectNotFoundException("The specified business rule doesn't exist in the database.");
            return DeserializeToGuid(businessRule.DefinitionString);
        }

        List<Guid> DeserializeToGuid(string xml)
        {
            var rule = XmlDeserializeFromString(xml, typeof (Rule));
            if ((rule as Rule) != null)
                return (rule as Rule).KeyList;
            return null;
        }

        public static object XmlDeserializeFromString(string objectData, Type type)
        {
            var serializer = new XmlSerializer(type);
            object result;

            using (TextReader reader = new StringReader(objectData))
            {
                result = serializer.Deserialize(reader);
            }

            return result;
        }
        #endregion
    }
}
