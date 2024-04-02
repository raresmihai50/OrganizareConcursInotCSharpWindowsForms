using System;

namespace OrganizareConcursInot.domain.validator
{
    public class TrialValidator
    {
        public void validate(Trial entity)
        {
            if (entity.getId() < 1)
            {
                throw new Exception("ID can't be < 1");
            }

            if (entity.getDetails() == "")
            {
                throw new Exception("Details can't be null");
            }

            if (entity.getType() == "")
            {
                throw new Exception("Type can't be null");
            }
        }
    }
}