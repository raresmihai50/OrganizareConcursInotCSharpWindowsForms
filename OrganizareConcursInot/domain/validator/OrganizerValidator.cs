using System;

namespace OrganizareConcursInot.domain.validator
{
    public class OrganizerValidator
    {
        public void validate(Organizer entity)
        {
            if (entity.getId()<1)
            {
                throw new Exception("ID can't be < 1");
            }

            if (entity.getPassword() == "")
            {
                throw new Exception("Password can't be null");
            }

            if (entity.getUsername()=="")
            {
                throw new Exception("Username can't be null");
            }
        }
    }
}