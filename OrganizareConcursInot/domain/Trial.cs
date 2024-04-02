using System;

namespace OrganizareConcursInot.domain
{
    public class Trial : Entity<int>
    {
        private int id;
        private string type;
        private string details;

        public Trial(int id, string type, string details)
        {
            this.id = id;
            this.type = type;
            this.details = details;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getType()
        {
            return type;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public string getDetails()
        {
            return details;
        }

        public void setDetails(string details)
        {
            this.details = details;
        }
        public String toString() {
            return "Id=" + id + " " + type + ' ' + details;
        }
    }
}