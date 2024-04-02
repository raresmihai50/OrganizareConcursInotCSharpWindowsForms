using System;

namespace OrganizareConcursInot.domain.validator
{
    public class Participantvalidator
    {
        public void validate(Participant entity)
        {
            if (entity.getAge() < 4)
            {
                throw new Exception("Age can't be < 4");
            }

            if (entity.getId() < 1)
            {
                throw new Exception("ID can't be < 1");
            }

            if (entity.getName() == "")
            {
                throw new Exception("Name can't be null");
            }

            if (entity.getTrials().Count == 0)
            {
                throw new Exception("There must be at least 1 trial");
            }
        }
    }
}